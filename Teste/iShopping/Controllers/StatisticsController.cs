using System;
using System.Collections.Generic;
using System.Linq;
using iShopping.Data;
using iShopping.Models;

namespace iShopping.Controllers
{
    /// <summary>
    /// Controlador de Estatísticas.
    /// Responsável por calcular dados para o formulário de estatísticas.
    /// 
    /// Funcionalidades:
    /// - Estatísticas mensais (Orçamento vs Gasto vs Diferença)
    /// - Percentagem de artigos previstos vs não previstos
    /// - Sugestão de orçamento para o próximo mês
    /// - Sugestão de lista de compras baseada na semana do mês
    /// </summary>
    public class StatisticsController
    {
        /// <summary>
        /// Obtém dados mensais de orçamento para o utilizador.
        /// Retorna uma lista de objetos com Mês/Ano, Orçamento, Total Gasto e Diferença.
        /// </summary>
        public List<MonthlyStats> GetMonthlyStats(int userId)
        {
            using (var context = new iShoppingContext())
            {
                // Obter todos os orçamentos do utilizador
                var budgets = context.Budgets
                    .Where(b => b.UserId == userId)
                    .OrderByDescending(b => b.Year)
                    .ThenByDescending(b => b.Month)
                    .ToList();

                List<MonthlyStats> stats = new List<MonthlyStats>();

                foreach (var budget in budgets)
                {
                    // Calcular total gasto no mês
                    decimal spent = 0;

                    // Compras fechadas no mês/ano
                    var closedLists = context.ShoppingLists
                        .Where(sl => sl.UserId == userId 
                            && sl.IsOpen == false 
                            && sl.ClosedAt.HasValue
                            && sl.ClosedAt.Value.Month == budget.Month 
                            && sl.ClosedAt.Value.Year == budget.Year)
                        .ToList();

                    foreach (var list in closedLists)
                    {
                        // Itens previstos adquiridos
                        var items = context.ShoppingItems
                            .Where(si => si.ShoppingListId == list.Id && si.AcquiredQuantity.HasValue && si.UnitPrice.HasValue)
                            .ToList();

                        foreach (var item in items)
                        {
                            spent += item.AcquiredQuantity.Value * item.UnitPrice.Value;
                        }

                        // Itens não previstos
                        var unplanned = context.UnplannedItems
                            .Where(ui => ui.ShoppingListId == list.Id)
                            .ToList();

                        foreach (var uItem in unplanned)
                        {
                            spent += uItem.Quantity * uItem.UnitPrice;
                        }
                    }

                    stats.Add(new MonthlyStats
                    {
                        Month = budget.Month,
                        Year = budget.Year,
                        MonthName = BudgetController.GetMonthName(budget.Month),
                        BudgetAmount = budget.Amount,
                        TotalSpent = spent,
                        Difference = budget.Amount - spent
                    });
                }

                return stats;
            }
        }

        /// <summary>
        /// Calcula a percentagem de artigos previstos vs não previstos em compras fechadas.
        /// </summary>
        public ArticlePercentageStats GetArticlePercentages(int userId)
        {
            using (var context = new iShoppingContext())
            {
                // Obter todas as compras fechadas do utilizador
                var closedLists = context.ShoppingLists
                    .Where(sl => sl.UserId == userId && sl.IsOpen == false)
                    .Select(sl => sl.Id)
                    .ToList();

                int plannedCount = 0;
                int unplannedCount = 0;

                // Contar itens previstos
                plannedCount = context.ShoppingItems
                    .Count(si => closedLists.Contains(si.ShoppingListId));

                // Contar itens não previstos
                unplannedCount = context.UnplannedItems
                    .Count(ui => closedLists.Contains(ui.ShoppingListId));

                int total = plannedCount + unplannedCount;

                return new ArticlePercentageStats
                {
                    PlannedCount = plannedCount,
                    UnplannedCount = unplannedCount,
                    TotalCount = total,
                    PlannedPercentage = total > 0 ? (plannedCount * 100.0 / total) : 0,
                    UnplannedPercentage = total > 0 ? (unplannedCount * 100.0 / total) : 0
                };
            }
        }

        /// <summary>
        /// Sugere um orçamento para o próximo mês baseado na média dos meses anteriores.
        /// Sugestão = Média dos gastos dos últimos 3 meses + 10% de margem.
        /// </summary>
        public decimal SuggestNextBudget(int userId)
        {
            using (var context = new iShoppingContext())
            {
                var stats = GetMonthlyStats(userId);

                if (stats.Count == 0)
                {
                    return 0; // Sem dados para sugerir
                }

                // Pegar nos últimos 3 meses (ou menos se não houver)
                int monthsToConsider = Math.Min(3, stats.Count);
                decimal totalSpent = 0;

                for (int i = 0; i < monthsToConsider; i++)
                {
                    totalSpent += stats[i].TotalSpent;
                }

                decimal average = totalSpent / monthsToConsider;
                
                // Sugerir média + 10% de margem de segurança
                return Math.Ceiling(average * 1.1m);
            }
        }

        /// <summary>
        /// Sugere uma lista de compras baseada nos artigos mais comprados numa semana específica do mês.
        /// Semana 1 = dias 1-7, Semana 2 = dias 8-14, etc.
        /// Retorna os artigos mais frequentes nessa semana.
        /// </summary>
        public List<ArticleSuggestion> SuggestShoppingList(int userId, int weekNumber)
        {
            using (var context = new iShoppingContext())
            {
                // Definir intervalo de dias para a semana
                int startDay = (weekNumber - 1) * 7 + 1;
                int endDay = weekNumber * 7;

                // Obter compras fechadas nessa semana (qualquer mês)
                var closedLists = context.ShoppingLists
                    .Where(sl => sl.UserId == userId 
                        && sl.IsOpen == false 
                        && sl.ClosedAt.HasValue
                        && sl.ClosedAt.Value.Day >= startDay 
                        && sl.ClosedAt.Value.Day <= endDay)
                    .ToList();

                Dictionary<string, int> articleFrequency = new Dictionary<string, int>();

                foreach (var list in closedLists)
                {
                    // Artigos previstos
                    var items = context.ShoppingItems
                        .Include("Article")
                        .Where(si => si.ShoppingListId == list.Id)
                        .ToList();

                    foreach (var item in items)
                    {
                        string articleName = item.Article.Name;
                        if (articleFrequency.ContainsKey(articleName))
                        {
                            articleFrequency[articleName]++;
                        }
                        else
                        {
                            articleFrequency[articleName] = 1;
                        }
                    }

                    // Artigos não previstos
                    var unplanned = context.UnplannedItems
                        .Where(ui => ui.ShoppingListId == list.Id)
                        .ToList();

                    foreach (var uItem in unplanned)
                    {
                        string articleName = uItem.ArticleName;
                        if (articleFrequency.ContainsKey(articleName))
                        {
                            articleFrequency[articleName]++;
                        }
                        else
                        {
                            articleFrequency[articleName] = 1;
                        }
                    }
                }

                // Ordenar por frequência (mais comprados primeiro) e retornar top 10
                var sorted = articleFrequency.OrderByDescending(x => x.Value).Take(10);

                List<ArticleSuggestion> suggestions = new List<ArticleSuggestion>();
                foreach (var pair in sorted)
                {
                    suggestions.Add(new ArticleSuggestion
                    {
                        ArticleName = pair.Key,
                        Frequency = pair.Value
                    });
                }

                return suggestions;
            }
        }
    }

    /// <summary>
    /// Classe auxiliar para guardar estatísticas mensais.
    /// </summary>
    public class MonthlyStats
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public string MonthName { get; set; }
        public decimal BudgetAmount { get; set; }
        public decimal TotalSpent { get; set; }
        public decimal Difference { get; set; }
    }

    /// <summary>
    /// Classe auxiliar para percentagens de artigos.
    /// </summary>
    public class ArticlePercentageStats
    {
        public int PlannedCount { get; set; }
        public int UnplannedCount { get; set; }
        public int TotalCount { get; set; }
        public double PlannedPercentage { get; set; }
        public double UnplannedPercentage { get; set; }
    }

    /// <summary>
    /// Classe auxiliar para sugestão de artigos.
    /// </summary>
    public class ArticleSuggestion
    {
        public string ArticleName { get; set; }
        public int Frequency { get; set; }
    }
}
