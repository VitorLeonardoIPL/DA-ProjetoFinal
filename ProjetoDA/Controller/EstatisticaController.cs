using ProjetoDA.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjetoDA.Controller
{
    public static class EstatisticaController
    {
        /// <summary>
        /// Listagem mensal: orçamento, total de compras e diferença.
        /// </summary>
      

        /// <summary>
        /// Percentagem de artigos previstos e não previstos por compra fechada.
        /// </summary>
        public static List<object[]> PercentagensPorCompra(ProjetoDAContext db)
        {
            var compras = db.Compras
                .Where(c => c.Fechada)
                .Include("ItensCompra")
                .Include("ItensCompra.ItemPrevisto")
                .Include("ItensCompra.ItemNaoPrevisto")
                .ToList();

            var resultado = new List<object[]>();

            foreach (var compra in compras)
            {
                var total = compra.ItensCompra.Count;
                var previstos = compra.ItensCompra.Count(ic => ic.ItemPrevisto != null);
                var naoPrevistos = compra.ItensCompra.Count(ic => ic.ItemNaoPrevisto != null);

                resultado.Add(new object[]
                {
                    compra.Nome,
                    total > 0 ? (double)previstos / total * 100 : 0,
                    total > 0 ? (double)naoPrevistos / total * 100 : 0
                });
            }

            return resultado;
        }

        /// <summary>
        /// Sugere um orçamento para o próximo mês com base na média dos últimos 3 meses.
        /// </summary>
      

        /// <summary>
        /// Sugere uma lista de artigos com base na semana atual do mês em meses anteriores.
        /// </summary>
        public static List<object[]> SugerirListaCompras(ProjetoDAContext db)
        {
            var hoje = DateTime.Now;
            var semanaAtual = (hoje.Day - 1) / 7 + 1; // 1ª, 2ª, 3ª ou 4ª semana

            var comprasSemana = db.Compras
                .Where(c => c.Fechada && c.DataFechada.Value.Year < hoje.Year ||
                            (c.DataFechada.Value.Year == hoje.Year && c.DataFechada.Value.Month < hoje.Month))
                .Include("ItensCompra")
                .Include("ItensCompra.Artigo")
                .Include("ItensCompra.ItemPrevisto")
                .ToList()
                .Where(c => ((c.DataFechada.Value.Day - 1) / 7 + 1) == semanaAtual)
                .ToList();

            var artigos = comprasSemana
                .SelectMany(c => c.ItensCompra)
                .Where(ic => ic.ItemPrevisto != null)
                .GroupBy(ic => ic.Artigo.Nome)
                .Select(g => new object[] { g.Key, g.Average(ic => (double)ic.QuantidadeAdquirida) })
                .ToList();

            return artigos;
        }

        // ---------- Exportação CSV ----------

        public static void ExportarCSV(ProjetoDAContext db, string caminhoFicheiro)
        {
            var compras = db.Compras
                .Where(c => c.Fechada)
                .Include("ItensCompra")
                .Include("ItensCompra.Artigo")
                .Include("ItensCompra.ItemPrevisto")
                .Include("ItensCompra.ItemNaoPrevisto")
                .ToList();

            var sb = new StringBuilder();
            sb.AppendLine("NomeCompra;DataCriacao;DataFechada;NomeArtigo;ArtigoPrevisto;ArtigoNaoPrevisto;QuantidadePrevista;QuantidadeAdquirida;PrecoUnitario");

            foreach (var compra in compras)
            {
                foreach (var item in compra.ItensCompra)
                {
                    var nomeArtigo = item.Artigo?.Nome ?? "";
                    var previsto = item.ItemPrevisto != null ? "Sim" : "Não";
                    var naoPrevisto = item.ItemNaoPrevisto != null ? "Sim" : "Não";
                    var qtdPrevista = item.ItemPrevisto?.QuantidadePrevista.ToString("F2") ?? "";
                    var qtdAdquirida = item.QuantidadeAdquirida.ToString("F2");
                    var preco = item.PrecoUnitario.ToString("F2");

                    sb.AppendLine($"{compra.Nome};{compra.DataCriacao:yyyy-MM-dd HH:mm};{compra.DataFechada:yyyy-MM-dd HH:mm};{nomeArtigo};{previsto};{naoPrevisto};{qtdPrevista};{qtdAdquirida};{preco}");
                }
            }

            File.WriteAllText(caminhoFicheiro, sb.ToString(), Encoding.UTF8);
        }

        // ---------- Helpers ----------

        private static decimal TotalComprasMes(ProjetoDAContext db, int mes, int ano)
        {
            return db.ItensCompra
                .Where(ic => ic.Compra.Fechada && ic.Compra.DataFechada.Value.Year == ano && ic.Compra.DataFechada.Value.Month == mes)
                .Sum(ic => (decimal?)ic.QuantidadeAdquirida * ic.PrecoUnitario) ?? 0;
        }
    }
}
