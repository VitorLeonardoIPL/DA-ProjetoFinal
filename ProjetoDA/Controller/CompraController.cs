using ProjetoDA.Model;
using System;
using System.Linq;

namespace ProjetoDA.Controller
{
    public class CompraController
    {
        public Compra Obter(int id)
        {
            using (ProjetoDAContext db = new ProjetoDAContext())
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
        }

        public int Inserir(string nome, string descricao)
        {
            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                var compra = new Compra
                {
                    Nome = nome,
                    Descricao = descricao,
                    Fechada = false,
                    DataCriacao = DateTime.Now,
                    UtilizadorCriadoId = SessaoAtual.UtilizadorLogado?.Id ?? 0
                };
                db.Compras.Add(compra);
                db.SaveChanges();
                return compra.Id;
            }
        }

        public void Atualizar(int compraId, string nome, string descricao)
        {
            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                var existente = db.Compras.Find(compraId);
                if (existente == null || existente.Fechada) return;

                existente.Nome = nome;
                existente.Descricao = descricao;
                existente.UtilizadorEditouId = SessaoAtual.UtilizadorLogado?.Id;
                db.SaveChanges();
            }
        }

        public void Fechar(int compraId)
        {
            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                var compra = db.Compras.Find(compraId);
                if (compra == null || compra.Fechada) return;

                compra.Fechada = true;
                compra.DataFechada = DateTime.Now;
                compra.UtilizadorFechouId = SessaoAtual.UtilizadorLogado?.Id;
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                var compra = db.Compras.Find(id);
                if (compra != null && !compra.Fechada)
                {
                    db.Compras.Remove(compra);
                    db.SaveChanges();
                }
            }
        }

        public int AdicionarItemPrevisto(int compraId, int artigoId, decimal quantidadePrevista)
        {
            using (ProjetoDAContext db = new ProjetoDAContext())
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
                    QuantidadePrevista = quantidadePrevista
                });
                db.SaveChanges();

                return itemCompra.Id;
            }
        }

        public int AdicionarItemNaoPrevisto(int compraId, int artigoId, decimal quantidade, decimal precoUnitario, string observacoes)
        {
            using (ProjetoDAContext db = new ProjetoDAContext())
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
                    Observacoes = observacoes
                });
                db.SaveChanges();

                return itemCompra.Id;
            }
        }

        public void AtualizarItemCompra(int itemCompraId, decimal quantidadeAdquirida, decimal precoUnitario)
        {
            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                var item = db.ItensCompra.Find(itemCompraId);
                if (item == null) return;

                item.QuantidadeAdquirida = quantidadeAdquirida;
                item.PrecoUnitario = precoUnitario;
                db.SaveChanges();
            }
        }

        public void AtualizarItemPrevisto(int itemCompraId, decimal quantidadePrevista)
        {
            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                var previsto = db.ItensPrevisto.Find(itemCompraId);
                if (previsto != null)
                {
                    previsto.QuantidadePrevista = quantidadePrevista;
                    db.SaveChanges();
                }
            }
        }

        public void RemoverItem(int itemCompraId)
        {
            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                var previsto = db.ItensPrevisto.Find(itemCompraId);
                if (previsto != null)
                {
                    db.ItensPrevisto.Remove(previsto);
                    db.SaveChanges();
                }

                var naoPrevisto = db.ItensNaoPrevisto.Find(itemCompraId);
                if (naoPrevisto != null)
                {
                    db.ItensNaoPrevisto.Remove(naoPrevisto);
                    db.SaveChanges();
                }

                var item = db.ItensCompra.Find(itemCompraId);
                if (item != null)
                {
                    db.ItensCompra.Remove(item);
                    db.SaveChanges();
                }
            }
        }

        public decimal TotalCompra(int compraId)
        {
            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                return db.ItensCompra
                    .Where(ic => ic.CompraId == compraId)
                    .Sum(ic => (decimal?)ic.QuantidadeAdquirida * ic.PrecoUnitario) ?? 0;
            }
        }
    }
}
