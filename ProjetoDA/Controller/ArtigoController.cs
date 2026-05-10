using ProjetoDA.Model;
using System;
using System.Linq;

namespace ProjetoDA.Controller
{
    public static class ArtigoController
    {
        // ---------- Tipos de Artigo ----------

        public static IQueryable<TipoArtigo> ListarTipos(ProjetoDAContext db)
        {
            return db.TiposArtigo.OrderBy(t => t.Nome);
        }

        public static TipoArtigo ObterTipo(ProjetoDAContext db, int id)
        {
            return db.TiposArtigo.Find(id);
        }

        public static void InserirTipo(ProjetoDAContext db, string nome, string descricao)
        {
            db.TiposArtigo.Add(new TipoArtigo
            {
                Nome = nome,
                Descricao = descricao,
                DataCriacao = DateTime.Now
            });
            db.SaveChanges();
        }

        public static void AtualizarTipo(ProjetoDAContext db, TipoArtigo tipo)
        {
            var existente = db.TiposArtigo.Find(tipo.Id);
            if (existente == null) return;

            existente.Nome = tipo.Nome;
            existente.Descricao = tipo.Descricao;
            db.SaveChanges();
        }

        public static void EliminarTipo(ProjetoDAContext db, int id)
        {
            var tipo = db.TiposArtigo.Find(id);
            if (tipo != null)
            {
                db.TiposArtigo.Remove(tipo);
                db.SaveChanges();
            }
        }

        // ---------- Artigos ----------

        public static IQueryable<Artigo> ListarArtigos(ProjetoDAContext db, int? tipoArtigoId = null)
        {
            var query = db.Artigos.Include("TipoArtigo").AsQueryable();

            if (tipoArtigoId.HasValue)
                query = query.Where(a => a.TipoArtigoId == tipoArtigoId.Value);

            return query.OrderBy(a => a.Nome);
        }

        public static Artigo ObterArtigo(ProjetoDAContext db, int id)
        {
            return db.Artigos.Include("TipoArtigo").FirstOrDefault(a => a.Id == id);
        }

        public static void InserirArtigo(ProjetoDAContext db, string nome, string descricao, int tipoArtigoId)
        {
            db.Artigos.Add(new Artigo
            {
                Nome = nome,
                Descricao = descricao,
                TipoArtigoId = tipoArtigoId,
                DataCriacao = DateTime.Now
            });
            db.SaveChanges();
        }

        public static void AtualizarArtigo(ProjetoDAContext db, Artigo artigo)
        {
            var existente = db.Artigos.Find(artigo.Id);
            if (existente == null) return;

            existente.Nome = artigo.Nome;
            existente.Descricao = artigo.Descricao;
            existente.TipoArtigoId = artigo.TipoArtigoId;
            db.SaveChanges();
        }

        public static void EliminarArtigo(ProjetoDAContext db, int id)
        {
            var artigo = db.Artigos.Find(id);
            if (artigo != null)
            {
                db.Artigos.Remove(artigo);
                db.SaveChanges();
            }
        }
    }
}
