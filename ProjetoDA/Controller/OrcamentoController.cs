using ProjetoDA.Model;
using System;
using System.Linq;

namespace ProjetoDA.Controller
{
    public static class OrcamentoController
    {
        public static IQueryable<Orcamento> Listar(ProjetoDAContext db)
        {
            return db.Orcamentos
                .Include("UtilizadorCriado")
                .Include("UtilizadorEditou")
                .OrderByDescending(o => o.Ano)
                .ThenByDescending(o => o.Mes);
        }

        public static Orcamento Obter(ProjetoDAContext db, int id)
        {
            return db.Orcamentos.Find(id);
        }

        /// <summary>
        /// Retorna o orçamento de um mês/ano específico, ou null se não existir.
        /// </summary>
        public static Orcamento ObterPorMes(ProjetoDAContext db, int mes, int ano)
        {
            return db.Orcamentos.FirstOrDefault(o => o.Mes == mes && o.Ano == ano);
        }

        public static void Inserir(ProjetoDAContext db, int mes, int ano, decimal valor)
        {
            db.Orcamentos.Add(new Orcamento
            {
                Mes = mes,
                Ano = ano,
                Valor = valor,
                DataCriacao = DateTime.Now,
                UtilizadorCriadoId = SessaoAtual.UtilizadorLogado?.Id ?? 0
            });
            db.SaveChanges();
        }

        public static void Atualizar(ProjetoDAContext db, Orcamento orcamento)
        {
            var existente = db.Orcamentos.Find(orcamento.Id);
            if (existente == null) return;

            existente.Valor = orcamento.Valor;
            existente.Mes = orcamento.Mes;
            existente.Ano = orcamento.Ano;
            existente.UtilizadorEditouId = SessaoAtual.UtilizadorLogado?.Id;
            db.SaveChanges();
        }

        public static void Eliminar(ProjetoDAContext db, int id)
        {
            var orcamento = db.Orcamentos.Find(id);
            if (orcamento != null)
            {
                db.Orcamentos.Remove(orcamento);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Calcula o total gasto em compras fechadas num determinado mês/ano.
        /// </summary>
        public static decimal TotalComprasMes(ProjetoDAContext db, int mes, int ano)
        {
            return db.Compras
                .Where(c => c.Fechada && c.DataFechada.Value.Year == ano && c.DataFechada.Value.Month == mes)
                .Join(db.ItensCompra, c => c.Id, ic => ic.CompraId, (c, ic) => ic)
                .Sum(ic => (decimal?)ic.QuantidadeAdquirida * ic.PrecoUnitario) ?? 0;
        }
    }
}
