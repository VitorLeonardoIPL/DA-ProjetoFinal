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

        public  Orcamento Obter(ProjetoDAContext db, int id)
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

                bool existe = context.Orcamentos.Any(o => o.DataInicio.Month == datainicio.Month && o.DataInicio.Year == datainicio.Year);
                if (existe)
                    throw new InvalidOperationException("Já existe um orçamento para este mês.");

                Orcamento orcamento = new Orcamento();
                orcamento.Nome = nome;
                orcamento.Valor = valor;
                orcamento.DataInicio = datainicio;
                orcamento.DataFim = datafim;
                orcamento.UtilizadorCriadoId = SessaoAtual.UtilizadorLogado.Id;


                context.Orcamentos.Add(orcamento);
                context.SaveChanges();
            }
        }


        public void Editar(int id, string nome, DateTime dataInicio, DateTime dataFim, decimal novoValor)
        {
            using (ProjetoDAContext context = new ProjetoDAContext())
            {
                var orcamento = context.Orcamentos.Find(id);
                 if (orcamento == null) return;

                bool existe = context.Orcamentos.Any(o =>
                o.Id != id &&
                o.DataInicio.Month == dataInicio.Month &&
                o.DataInicio.Year == dataInicio.Year);

                if (existe)
                throw new Exception("Já existe um orçamento para esse mês.");

                orcamento.Nome = nome;
                orcamento.DataInicio = dataInicio;
                orcamento.DataFim = dataFim;
                orcamento.Valor = novoValor;
                orcamento.UtilizadorEditouId = SessaoAtual.UtilizadorLogado.Id;
                context.SaveChanges();
            }
        }



        public void Eliminar(int id)
        {
            using (ProjetoDAContext context = new ProjetoDAContext())
            {
                var orcamento = context.Orcamentos.Find(id);
                if (orcamento != null)
                {
                    context.Orcamentos.Remove(orcamento);
                    context.SaveChanges();
                }
            }
        }

       
      
    }
}
