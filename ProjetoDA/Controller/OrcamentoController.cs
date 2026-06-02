using ProjetoDA.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoDA.Controller
{
    public  class OrcamentoController
    {
        public static List<Orcamento> Listar(ProjetoDAContext db)
        {
            return db.Orcamentos.OrderBy(o => o.DataInicio).ToList();
        }

        public static void Atualizar(ProjetoDAContext db, Orcamento orcamento)
        {
            var existente = db.Orcamentos.Find(orcamento.Id);
            if (existente == null) return;
            existente.Nome = orcamento.Nome;
            existente.Valor = orcamento.Valor;
            existente.DataInicio = orcamento.DataInicio;
            existente.DataFim = orcamento.DataFim;
            db.SaveChanges();
        }

        public static Orcamento Obter(ProjetoDAContext db, int id)
        {
            return db.Orcamentos.Find(id);
        }

        /// <summary>
        /// Retorna o orçamento de um mês/ano específico, ou null se não existir.
        /// </summary>
       

        public void Inserir(string nome, decimal valor, DateTime datainicio, DateTime datafim)
        {
            using (ProjetoDAContext context = new ProjetoDAContext())
            {

                Orcamento orcamento = new Orcamento();
                orcamento.Nome = nome;
                orcamento.Valor = valor;
                orcamento.DataInicio = datainicio;
                orcamento.DataFim = datafim;


                context.Orcamentos.Add(orcamento);
                context.SaveChanges();
            }
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
