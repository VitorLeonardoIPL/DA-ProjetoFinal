using System;
using System.Collections.Generic;
using System.Linq;
using iShopping.Data;
using iShopping.Models;

namespace iShopping.Controllers
{
    /// <summary>
    /// Controlador de Compras (Shopping Lists).
    /// Responsável pela gestão de compras planeadas e em execução.
    /// 
    /// Funcionalidades:
    /// - Criar nova compra planeada
    /// - Adicionar/remover itens previstos
    /// - Fechar compra (regista data/hora e utilizador)
    /// - Listar compras (todas, abertas, fechadas)
    /// </summary>
    public class ShoppingController
    {
        // ================================================================
        // GESTÃO DE COMPRAS (ShoppingList)
        // ================================================================

        /// <summary>
        /// Lista todas as compras de um utilizador.
        /// </summary>
        public List<ShoppingList> GetAllShoppingLists(int userId)
        {
            using (var context = new iShoppingContext())
            {
                return context.ShoppingLists
                    .Where(sl => sl.UserId == userId)
                    .OrderByDescending(sl => sl.CreatedAt)
                    .ToList();
            }
        }

        /// <summary>
        /// Lista apenas as compras abertas de um utilizador.
        /// </summary>
        public List<ShoppingList> GetOpenShoppingLists(int userId)
        {
            using (var context = new iShoppingContext())
            {
                return context.ShoppingLists
                    .Where(sl => sl.UserId == userId && sl.IsOpen == true)
                    .OrderByDescending(sl => sl.CreatedAt)
                    .ToList();
            }
        }

        /// <summary>
        /// Lista apenas as compras fechadas de um utilizador.
        /// </summary>
        public List<ShoppingList> GetClosedShoppingLists(int userId)
        {
            using (var context = new iShoppingContext())
            {
                return context.ShoppingLists
                    .Where(sl => sl.UserId == userId && sl.IsOpen == false)
                    .OrderByDescending(sl => sl.ClosedAt)
                    .ToList();
            }
        }

        /// <summary>
        /// Obtém uma compra pelo seu ID.
        /// Inclui também os itens previstos e não previstos.
        /// </summary>
        public ShoppingList GetShoppingListById(int id)
        {
            using (var context = new iShoppingContext())
            {
                return context.ShoppingLists
                    .Include("Items")
                    .Include("Items.Article")
                    .Include("Items.Article.ArticleType")
                    .Include("UnplannedItems")
                    .FirstOrDefault(sl => sl.Id == id);
            }
        }

        /// <summary>
        /// Cria uma nova compra planeada.
        /// Retorna o ID da nova compra, ou -1 se falhar.
        /// </summary>
        public int CreateShoppingList(int userId, string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return -1;
            }

            using (var context = new iShoppingContext())
            {
                var shoppingList = new ShoppingList
                {
                    Name = name.Trim(),
                    Description = description != null ? description.Trim() : "",
                    IsOpen = true,
                    CreatedAt = DateTime.Now,
                    UserId = userId
                };

                context.ShoppingLists.Add(shoppingList);
                context.SaveChanges();
                return shoppingList.Id;
            }
        }

        /// <summary>
        /// Atualiza o nome e descrição de uma compra.
        /// Só é possível se a compra estiver aberta.
        /// </summary>
        public bool UpdateShoppingList(int id, string newName, string newDescription)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                return false;
            }

            using (var context = new iShoppingContext())
            {
                var shoppingList = context.ShoppingLists.FirstOrDefault(sl => sl.Id == id);
                if (shoppingList == null)
                {
                    return false;
                }

                // Não permitir alterar compras fechadas
                if (!shoppingList.IsOpen)
                {
                    return false;
                }

                shoppingList.Name = newName.Trim();
                shoppingList.Description = newDescription != null ? newDescription.Trim() : "";
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Elimina uma compra e todos os seus itens.
        /// Só é possível se a compra estiver aberta.
        /// </summary>
        public bool DeleteShoppingList(int id)
        {
            using (var context = new iShoppingContext())
            {
                var shoppingList = context.ShoppingLists
                    .Include("Items")
                    .Include("UnplannedItems")
                    .FirstOrDefault(sl => sl.Id == id);

                if (shoppingList == null)
                {
                    return false;
                }

                // Não permitir eliminar compras fechadas
                if (!shoppingList.IsOpen)
                {
                    return false;
                }

                // Eliminar itens previstos
                context.ShoppingItems.RemoveRange(shoppingList.Items);

                // Eliminar itens não previstos
                context.UnplannedItems.RemoveRange(shoppingList.UnplannedItems);

                // Eliminar a compra
                context.ShoppingLists.Remove(shoppingList);
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Fecha uma compra.
        /// Regista a data/hora de fecho e o utilizador que fechou.
        /// Só é possível fechar compras abertas.
        /// </summary>
        public bool CloseShoppingList(int shoppingListId, int closedByUserId)
        {
            using (var context = new iShoppingContext())
            {
                var shoppingList = context.ShoppingLists.FirstOrDefault(sl => sl.Id == shoppingListId);
                if (shoppingList == null || !shoppingList.IsOpen)
                {
                    return false;
                }

                shoppingList.IsOpen = false;
                shoppingList.ClosedAt = DateTime.Now;
                shoppingList.ClosedByUserId = closedByUserId;
                context.SaveChanges();
                return true;
            }
        }

        // ================================================================
        // GESTÃO DE ITENS PREVISTOS (ShoppingItem)
        // ================================================================

        /// <summary>
        /// Adiciona um item previsto a uma compra.
        /// </summary>
        public bool AddShoppingItem(int shoppingListId, int articleId, int plannedQuantity)
        {
            if (plannedQuantity < 1)
            {
                return false;
            }

            using (var context = new iShoppingContext())
            {
                // Verificar se a compra existe e está aberta
                var shoppingList = context.ShoppingLists.FirstOrDefault(sl => sl.Id == shoppingListId);
                if (shoppingList == null || !shoppingList.IsOpen)
                {
                    return false;
                }

                // Verificar se o artigo já está na lista
                bool alreadyExists = context.ShoppingItems.Any(si => 
                    si.ShoppingListId == shoppingListId && si.ArticleId == articleId);
                
                if (alreadyExists)
                {
                    return false;
                }

                var newItem = new ShoppingItem
                {
                    ShoppingListId = shoppingListId,
                    ArticleId = articleId,
                    PlannedQuantity = plannedQuantity
                };

                context.ShoppingItems.Add(newItem);
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Remove um item previsto de uma compra.
        /// Só é possível se a compra estiver aberta.
        /// </summary>
        public bool RemoveShoppingItem(int itemId)
        {
            using (var context = new iShoppingContext())
            {
                var item = context.ShoppingItems
                    .Include("ShoppingList")
                    .FirstOrDefault(si => si.Id == itemId);

                if (item == null || !item.ShoppingList.IsOpen)
                {
                    return false;
                }

                context.ShoppingItems.Remove(item);
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Atualiza a quantidade planeada de um item.
        /// </summary>
        public bool UpdateShoppingItem(int itemId, int newQuantity)
        {
            if (newQuantity < 1)
            {
                return false;
            }

            using (var context = new iShoppingContext())
            {
                var item = context.ShoppingItems
                    .Include("ShoppingList")
                    .FirstOrDefault(si => si.Id == itemId);

                if (item == null || !item.ShoppingList.IsOpen)
                {
                    return false;
                }

                item.PlannedQuantity = newQuantity;
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Obtém todos os itens previstos de uma compra.
        /// </summary>
        public List<ShoppingItem> GetShoppingItems(int shoppingListId)
        {
            using (var context = new iShoppingContext())
            {
                return context.ShoppingItems
                    .Include("Article")
                    .Include("Article.ArticleType")
                    .Where(si => si.ShoppingListId == shoppingListId)
                    .ToList();
            }
        }

        // ================================================================
        // GESTÃO DE ITENS NÃO PREVISTOS (UnplannedItem)
        // ================================================================

        /// <summary>
        /// Adiciona um item não previsto a uma compra.
        /// Este item é logo considerado como adquirido.
        /// </summary>
        public bool AddUnplannedItem(int shoppingListId, string articleName, int quantity, decimal unitPrice, string observations)
        {
            if (string.IsNullOrWhiteSpace(articleName) || quantity < 1 || unitPrice <= 0)
            {
                return false;
            }

            using (var context = new iShoppingContext())
            {
                var shoppingList = context.ShoppingLists.FirstOrDefault(sl => sl.Id == shoppingListId);
                if (shoppingList == null || !shoppingList.IsOpen)
                {
                    return false;
                }

                var newItem = new UnplannedItem
                {
                    ShoppingListId = shoppingListId,
                    ArticleName = articleName.Trim(),
                    Quantity = quantity,
                    UnitPrice = unitPrice,
                    Observations = observations != null ? observations.Trim() : ""
                };

                context.UnplannedItems.Add(newItem);
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Remove um item não previsto de uma compra.
        /// </summary>
        public bool RemoveUnplannedItem(int itemId)
        {
            using (var context = new iShoppingContext())
            {
                var item = context.UnplannedItems
                    .Include("ShoppingList")
                    .FirstOrDefault(ui => ui.Id == itemId);

                if (item == null || !item.ShoppingList.IsOpen)
                {
                    return false;
                }

                context.UnplannedItems.Remove(item);
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Obtém todos os itens não previstos de uma compra.
        /// </summary>
        public List<UnplannedItem> GetUnplannedItems(int shoppingListId)
        {
            using (var context = new iShoppingContext())
            {
                return context.UnplannedItems
                    .Where(ui => ui.ShoppingListId == shoppingListId)
                    .ToList();
            }
        }

        /// <summary>
        /// Calcula o total gasto numa compra (aberta ou fechada).
        /// Soma itens previstos adquiridos + itens não previstos.
        /// </summary>
        public decimal CalculateShoppingTotal(int shoppingListId)
        {
            using (var context = new iShoppingContext())
            {
                decimal total = 0;

                // Itens previstos com preço
                var items = context.ShoppingItems
                    .Where(si => si.ShoppingListId == shoppingListId && si.AcquiredQuantity.HasValue && si.UnitPrice.HasValue)
                    .ToList();

                foreach (var item in items)
                {
                    total += item.AcquiredQuantity.Value * item.UnitPrice.Value;
                }

                // Itens não previstos
                var unplanned = context.UnplannedItems
                    .Where(ui => ui.ShoppingListId == shoppingListId)
                    .ToList();

                foreach (var unplannedItem in unplanned)
                {
                    total += unplannedItem.Quantity * unplannedItem.UnitPrice;
                }

                return total;
            }
        }
    }
}
