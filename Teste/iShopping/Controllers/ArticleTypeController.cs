using System.Collections.Generic;
using System.Linq;
using iShopping.Data;
using iShopping.Models;

namespace iShopping.Controllers
{
    /// <summary>
    /// Controlador de Tipos de Artigo.
    /// Responsável por toda a lógica de gestão de categorias (Tipos de Artigo).
    /// Exemplos de tipos: Alimentação, Limpeza, Higiene, etc.
    /// </summary>
    public class ArticleTypeController
    {
        /// <summary>
        /// Lista todos os tipos de artigo existentes na base de dados.
        /// </summary>
        public List<ArticleType> GetAllTypes()
        {
            using (var context = new iShoppingContext())
            {
                return context.ArticleTypes.ToList();
            }
        }

        /// <summary>
        /// Procura um tipo de artigo pelo seu ID.
        /// </summary>
        public ArticleType GetTypeById(int id)
        {
            using (var context = new iShoppingContext())
            {
                return context.ArticleTypes.FirstOrDefault(t => t.Id == id);
            }
        }

        /// <summary>
        /// Cria um novo tipo de artigo na base de dados.
        /// Retorna true se a criação foi bem-sucedida.
        /// </summary>
        public bool CreateType(string name)
        {
            // Validar que o nome não está vazio
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            using (var context = new iShoppingContext())
            {
                // Verificar se já existe um tipo com o mesmo nome
                bool exists = context.ArticleTypes.Any(t => t.Name.ToLower() == name.ToLower());
                if (exists)
                {
                    return false; // Tipo já existe
                }

                var newType = new ArticleType
                {
                    Name = name.Trim()
                };

                context.ArticleTypes.Add(newType);
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Atualiza o nome de um tipo de artigo existente.
        /// Retorna true se a atualização foi bem-sucedida.
        /// </summary>
        public bool UpdateType(int id, string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                return false;
            }

            using (var context = new iShoppingContext())
            {
                var type = context.ArticleTypes.FirstOrDefault(t => t.Id == id);
                if (type == null)
                {
                    return false; // Tipo não encontrado
                }

                // Verificar se o novo nome já existe noutro tipo
                bool nameExists = context.ArticleTypes.Any(t => t.Name.ToLower() == newName.ToLower() && t.Id != id);
                if (nameExists)
                {
                    return false;
                }

                type.Name = newName.Trim();
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Elimina um tipo de artigo da base de dados.
        /// Retorna true se a eliminação foi bem-sucedida.
        /// </summary>
        public bool DeleteType(int id)
        {
            using (var context = new iShoppingContext())
            {
                var type = context.ArticleTypes.FirstOrDefault(t => t.Id == id);
                if (type == null)
                {
                    return false;
                }

                // Verificar se o tipo tem artigos associados
                bool hasArticles = context.Articles.Any(a => a.ArticleTypeId == id);
                if (hasArticles)
                {
                    return false; // Não se pode eliminar um tipo que tem artigos
                }

                context.ArticleTypes.Remove(type);
                context.SaveChanges();
                return true;
            }
        }
    }
}
