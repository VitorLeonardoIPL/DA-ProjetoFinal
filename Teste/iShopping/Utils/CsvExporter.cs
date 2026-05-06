using System.Collections.Generic;
using System.IO;
using System.Text;
using iShopping.Controllers;
using iShopping.Models;

namespace iShopping.Utils
{
    /// <summary>
    /// Classe responsável por exportar dados de compras para um ficheiro CSV.
    /// Formato: Separado por ponto e vírgula (;), compatível com Excel.
    /// 
    /// Campos exportados:
    /// NomeCompra, DataCriacao, DataFechada, NomeArtigo, ArtigoPrevisto, 
    /// ArtigoNaoPrevisto, QuantidadePrevista, QuantidadeAdquirida, PrecoUnitario
    /// </summary>
    public class CsvExporter
    {
        private ShoppingController _shoppingController;

        public CsvExporter()
        {
            _shoppingController = new ShoppingController();
        }

        /// <summary>
        /// Exporta uma lista de compras fechadas para um ficheiro CSV.
        /// Retorna o caminho do ficheiro criado.
        /// </summary>
        public string ExportToCsv(List<ShoppingList> closedShoppingLists, string filePath)
        {
            // Usar UTF-8 com BOM para garantir que o Excel lê acentos corretamente
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Escrever cabeçalho do CSV
                writer.WriteLine("NomeCompra;DataCriacao;DataFechada;NomeArtigo;ArtigoPrevisto;ArtigoNaoPrevisto;QuantidadePrevista;QuantidadeAdquirida;PrecoUnitario");

                foreach (var shoppingList in closedShoppingLists)
                {
                    // Obter itens previstos
                    var items = _shoppingController.GetShoppingItems(shoppingList.Id);
                    
                    foreach (var item in items)
                    {
                        // Escrever linha para cada item previsto
                        writer.WriteLine(
                            "{0};{1};{2};{3};{4};{5};{6};{7};{8}",
                            EscapeCsv(shoppingList.Name),
                            EscapeCsv(shoppingList.CreatedAt.ToString("dd/MM/yyyy HH:mm")),
                            EscapeCsv(shoppingList.ClosedAt.HasValue ? shoppingList.ClosedAt.Value.ToString("dd/MM/yyyy HH:mm") : ""),
                            EscapeCsv(item.Article.Name),
                            "Sim", // É artigo previsto
                            "Não",
                            item.PlannedQuantity,
                            item.AcquiredQuantity.HasValue ? item.AcquiredQuantity.Value.ToString() : "0",
                            item.UnitPrice.HasValue ? item.UnitPrice.Value.ToString("F2") : "0.00"
                        );
                    }

                    // Obter itens não previstos
                    var unplanned = _shoppingController.GetUnplannedItems(shoppingList.Id);

                    foreach (var unplannedItem in unplanned)
                    {
                        // Escrever linha para cada item não previsto
                        writer.WriteLine(
                            "{0};{1};{2};{3};{4};{5};{6};{7};{8}",
                            EscapeCsv(shoppingList.Name),
                            EscapeCsv(shoppingList.CreatedAt.ToString("dd/MM/yyyy HH:mm")),
                            EscapeCsv(shoppingList.ClosedAt.HasValue ? shoppingList.ClosedAt.Value.ToString("dd/MM/yyyy HH:mm") : ""),
                            EscapeCsv(unplannedItem.ArticleName),
                            "Não", // Não é artigo previsto
                            "Sim",
                            "0", // Não havia quantidade prevista
                            unplannedItem.Quantity,
                            unplannedItem.UnitPrice.ToString("F2")
                        );
                    }
                }
            }

            return filePath;
        }

        /// <summary>
        /// Garante que o texto não quebra o formato CSV.
        /// Se o texto contiver ponto e vírgula ou aspas, envolve-o em aspas.
        /// </summary>
        private string EscapeCsv(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "";
            }

            if (text.Contains(";") || text.Contains("\"") || text.Contains("\n"))
            {
                return "\"" + text.Replace("\"", "\"\"") + "\"";
            }

            return text;
        }
    }
}
