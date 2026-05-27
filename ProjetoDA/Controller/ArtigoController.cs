using ProjetoDA.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDA.Controller
{
    public class ArtigoController
    {
        // ---------- Tipos de Artigo ----------


        public  void InserirTipo(string nome)
        {

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Nome não pode ser vazio");
                return;
            }

            using (ProjetoDAContext context = new ProjetoDAContext())
            {

                TipoArtigo tipoArtigo = new TipoArtigo();
                tipoArtigo.Nome = nome;

                context.TiposArtigo.Add(tipoArtigo);
                context.SaveChanges();
            }
        }


        public  void EliminarTipo(int id)
        {
            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                var tipo = db.TiposArtigo.Find(id);
                if (tipo != null)
                {
                    db.TiposArtigo.Remove(tipo);
                    db.SaveChanges();
                }
            }
        }

        // ---------- Artigos ----------


        public  void InserirArtigo(string nome, int preco, int tipoArtigoId)
        {
            
            using (ProjetoDAContext context = new ProjetoDAContext())
            {
                Artigo artigo = new Artigo();
                artigo.Nome = nome;
                artigo.DataCriacao = DateTime.Now;
                artigo.Preco = preco;
                artigo.TipoArtigoId = tipoArtigoId;
                context.Artigos.Add(artigo);
                context.SaveChanges();
            }


        }

        public  void AtualizarArtigo(ProjetoDAContext db, Artigo artigo)
        {
            var existente = db.Artigos.Find(artigo.Id);
            if (existente == null) return;

            existente.Nome = artigo.Nome;
            existente.Descricao = artigo.Descricao;
            existente.TipoArtigoId = artigo.TipoArtigoId;
            db.SaveChanges();
        }


        public  void EliminarArtigo(ProjetoDAContext db, int id)
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
