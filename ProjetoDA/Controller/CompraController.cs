using ProjetoDA.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoDA.Controller
{
    public static class CompraController
    {
        // ---------- Compras ----------

        public static IQueryable<Compra> Listar(ProjetoDAContext db, bool? apenasAbertas = null)
        {
            var query = db.Compras
                .Include("UtilizadorCriado")
                .Include("UtilizadorFechou")
                .Include("ItensCompra")
                .AsQueryable();

            if (apenasAbertas.HasValue)
                query = query.Where(c => c.Fechada != apenasAbertas.Value);

            return query.OrderByDescending(c => c.DataCriacao);
        }

        public static Compra Obter(ProjetoDAContext db, int id)
        {
            return db.Compras
                .Include("UtilizadorCriado")
                .Include("UtilizadorFechou")
                .Include("UtilizadorEditou")
                .Include("ItensCompra")
                .Include("ItensCompra.Artigo")
                .Include("ItensCompra.ItemPrevisto")
                .Include("ItensCompra.ItemNaoPrevisto")
                .FirstOrDefault(c => c.Id == id);
        }

        public static void Inserir(ProjetoDAContext db, string nome, string descricao)
        {
            db.Compras.Add(new Compra
            {
                Nome = nome,
                Descricao = descricao,
                Fechada = false,
                DataCriacao = DateTime.Now,
                UtilizadorCriadoId = SessaoAtual.UtilizadorLogado?.Id ?? 0
            });
            db.SaveChanges();
        }

        public static void Atualizar(ProjetoDAContext db, Compra compra)
        {
            var existente = db.Compras.Find(compra.Id);
            if (existente == null || existente.Fechada) return;

            existente.Nome = compra.Nome;
            existente.Descricao = compra.Descricao;
            existente.UtilizadorEditouId = SessaoAtual.UtilizadorLogado?.Id;
            db.SaveChanges();
        }

        public static void Fechar(ProjetoDAContext db, int compraId)
        {
            var compra = db.Compras.Find(compraId);
            if (compra == null || compra.Fechada) return;

            compra.Fechada = true;
            compra.DataFechada = DateTime.Now;
            compra.UtilizadorFechouId = SessaoAtual.UtilizadorLogado?.Id;
            db.SaveChanges();
        }

        public static void Eliminar(ProjetoDAContext db, int id)
        {
            var compra = db.Compras.Find(id);
            if (compra != null && !compra.Fechada)
            {
                db.Compras.Remove(compra);
                db.SaveChanges();
            }
        }

        // ---------- Itens ----------

        public static void AdicionarItemPrevisto(ProjetoDAContext db, int compraId, int artigoId, decimal quantidadePrevista)
        {
            var itemCompra = new ItemCompra
            {
                CompraId = compraId,
                ArtigoId = artigoId,
                QuantidadeAdquirida = 0,
                PrecoUnitario = 0
            };
            db.ItensCompra.Add(itemCompra);
            db.SaveChanges();

            db.ItensPrevisto.Add(new ItemPrevisto
            {
                Id = itemCompra.Id,
                ArtigoId = artigoId,
                QuantidadePrevista = quantidadePrevista
            });
            db.SaveChanges();
        }

        public static void AdicionarItemNaoPrevisto(ProjetoDAContext db, int compraId, int artigoId, decimal quantidade, decimal precoUnitario)
        {
            var itemCompra = new ItemCompra
            {
                CompraId = compraId,
                ArtigoId = artigoId,
                QuantidadeAdquirida = quantidade,
                PrecoUnitario = precoUnitario
            };
            db.ItensCompra.Add(itemCompra);
            db.SaveChanges();

            db.ItensNaoPrevisto.Add(new ItemNaoPrevisto
            {
                Id = itemCompra.Id,
                ArtigoId = artigoId,
                QuantidadeAdquirida = quantidade
            });
            db.SaveChanges();
        }

        public static void AtualizarItemCompra(ProjetoDAContext db, int itemCompraId, decimal quantidadeAdquirida, decimal precoUnitario)
        {
            var item = db.ItensCompra.Find(itemCompraId);
            if (item == null) return;

            item.QuantidadeAdquirida = quantidadeAdquirida;
            item.PrecoUnitario = precoUnitario;
            db.SaveChanges();
        }

        public static void RemoverItem(ProjetoDAContext db, int itemCompraId)
        {
            var item = db.ItensCompra.Find(itemCompraId);
            if (item != null)
            {
                db.ItensCompra.Remove(item);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Calcula o total gasto numa compra (soma de quantidade * preco de todos os itens).
        /// </summary>
        public static decimal TotalCompra(ProjetoDAContext db, int compraId)
        {
            return db.ItensCompra
                .Where(ic => ic.CompraId == compraId)
                .Sum(ic => (decimal?)ic.QuantidadeAdquirida * ic.PrecoUnitario) ?? 0;
        }
    }
}
