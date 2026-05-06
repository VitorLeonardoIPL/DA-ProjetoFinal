using System;
using System.Collections.Generic;
using System.Linq;
using iShopping.Data;
using iShopping.Models;

namespace iShopping.Controllers
{
    /// <summary>
    /// Controlador de Orçamentos.
    /// Responsável pela gestão do orçamento mensal de cada utilizador.
    /// 
    /// Regras:
    /// - Cada utilizador pode ter UM orçamento por mês/ano
    /// - O orçamento tem um valor máximo definido
    /// - Podemos calcular quanto já foi gasto nesse mês
    /// - Podemos saber o saldo disponível
    /// </summary>
    public class BudgetController
    {
        /// <summary>
        /// Lista todos os orçamentos de um utilizador específico.
        /// </summary>
        public List<Budget> GetBudgetsByUser(int userId)
        {
            using (var context = new iShoppingContext())
            {
                return context.Budgets
                    .Where(b => b.UserId == userId)
                    .OrderByDescending(b => b.Year)  // Mais recente primeiro
                    .ThenByDescending(b => b.Month)
                    .ToList();
            }
        }

        /// <summary>
        /// Lista todos os orçamentos de todos os utilizadores.
        /// </summary>
        public List<Budget> GetAllBudgets()
        {
            using (var context = new iShoppingContext())
            {
                return context.Budgets
                    .OrderByDescending(b => b.Year)
                    .ThenByDescending(b => b.Month)
                    .ToList();
            }
        }

        /// <summary>
        /// Obtém o orçamento de um utilizador para um mês/ano específico.
        /// Retorna null se não existir.
        /// </summary>
        public Budget GetBudgetByMonth(int userId, int month, int year)
        {
            using (var context = new iShoppingContext())
            {
                return context.Budgets
                    .FirstOrDefault(b => b.UserId == userId && b.Month == month && b.Year == year);
            }
        }

        /// <summary>
        /// Obtém o orçamento do mês atual de um utilizador.
        /// Útil para mostrar o saldo disponível durante as compras.
        /// </summary>
        public Budget GetCurrentMonthBudget(int userId)
        {
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            return GetBudgetByMonth(userId, currentMonth, currentYear);
        }

        /// <summary>
        /// Cria um novo orçamento mensal.
        /// Retorna true se a criação foi bem-sucedida.
        /// Retorna false se já existir orçamento para esse mês/ano.
        /// </summary>
        public bool CreateBudget(int userId, int month, int year, decimal amount)
        {
            using (var context = new iShoppingContext())
            {
                // Verificar se já existe orçamento para este mês/ano
                bool exists = context.Budgets.Any(b => 
                    b.UserId == userId && b.Month == month && b.Year == year);
                
                if (exists)
                {
                    return false; // Já existe orçamento para este mês
                }

                var newBudget = new Budget
                {
                    UserId = userId,
                    Month = month,
                    Year = year,
                    Amount = amount,
                    CreatedAt = DateTime.Now
                };

                context.Budgets.Add(newBudget);
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Atualiza o valor de um orçamento existente.
        /// Retorna true se a atualização foi bem-sucedida.
        /// </summary>
        public bool UpdateBudget(int budgetId, decimal newAmount)
        {
            using (var context = new iShoppingContext())
            {
                var budget = context.Budgets.FirstOrDefault(b => b.Id == budgetId);
                if (budget == null)
                {
                    return false;
                }

                budget.Amount = newAmount;
                budget.UpdatedAt = DateTime.Now;
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Elimina um orçamento.
        /// Retorna true se a eliminação foi bem-sucedida.
        /// </summary>
        public bool DeleteBudget(int budgetId)
        {
            using (var context = new iShoppingContext())
            {
                var budget = context.Budgets.FirstOrDefault(b => b.Id == budgetId);
                if (budget == null)
                {
                    return false;
                }

                context.Budgets.Remove(budget);
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Calcula o total gasto por um utilizador num mês específico.
        /// Soma todas as compras fechadas nesse mês.
        /// Para cada compra fechada, soma:
        /// - (QuantidadeAdquirida × PreçoUnitário) de cada item previsto
        /// - (Quantidade × PreçoUnitário) de cada item não previsto
        /// </summary>
        public decimal CalculateSpentInMonth(int userId, int month, int year)
        {
            using (var context = new iShoppingContext())
            {
                // Obter todas as compras fechadas do utilizador no mês/ano
                var closedShoppingLists = context.ShoppingLists
                    .Where(sl => sl.UserId == userId 
                        && sl.IsOpen == false 
                        && sl.ClosedAt.HasValue
                        && sl.ClosedAt.Value.Month == month 
                        && sl.ClosedAt.Value.Year == year)
                    .ToList();

                decimal totalSpent = 0;

                foreach (var shoppingList in closedShoppingLists)
                {
                    // Somar itens previstos adquiridos
                    var items = context.ShoppingItems
                        .Where(si => si.ShoppingListId == shoppingList.Id && si.AcquiredQuantity.HasValue)
                        .ToList();
                    
                    foreach (var item in items)
                    {
                        if (item.UnitPrice.HasValue)
                        {
                            totalSpent += item.AcquiredQuantity.Value * item.UnitPrice.Value;
                        }
                    }

                    // Somar itens não previstos
                    var unplanned = context.UnplannedItems
                        .Where(ui => ui.ShoppingListId == shoppingList.Id)
                        .ToList();

                    foreach (var unplannedItem in unplanned)
                    {
                        totalSpent += unplannedItem.Quantity * unplannedItem.UnitPrice;
                    }
                }

                return totalSpent;
            }
        }

        /// <summary>
        /// Calcula o saldo disponível no orçamento atual.
        /// Retorna: ValorOrçamento - TotalGasto
        /// Se não houver orçamento para o mês atual, retorna -1.
        /// </summary>
        public decimal GetAvailableBalance(int userId)
        {
            Budget budget = GetCurrentMonthBudget(userId);
            
            if (budget == null)
            {
                return -1; // Não há orçamento definido
            }

            decimal spent = CalculateSpentInMonth(userId, budget.Month, budget.Year);
            return budget.Amount - spent;
        }

        /// <summary>
        /// Retorna os nomes dos meses em português.
        /// Útil para mostrar "Janeiro", "Fevereiro", etc. em vez de 1, 2, ...
        /// </summary>
        public static string GetMonthName(int month)
        {
            string[] monthNames = {
                "", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
            };

            if (month >= 1 && month <= 12)
            {
                return monthNames[month];
            }
            return "";
        }
    }
}
