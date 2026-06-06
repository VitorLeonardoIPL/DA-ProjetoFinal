using ProjetoDA.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDA.Controller
{
    public class ArtigoController
    {


        // ---------- Tipos de Artigo ----------


        public void InserirTipo(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new InvalidOperationException("Nome não pode ser vazio.");

            using (ProjetoDAContext context = new ProjetoDAContext())
            {
                TipoArtigo tipoArtigo = new TipoArtigo();
                tipoArtigo.Nome = nome;

                context.TiposArtigo.Add(tipoArtigo);
                context.SaveChanges();
            }
        }

        public void EditarTipo(int id, string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new InvalidOperationException("Nome não pode ser vazio.");

            using (ProjetoDAContext context = new ProjetoDAContext())
            {
                var tipo = context.TiposArtigo.Find(id);
                if (tipo == null) return;

                tipo.Nome = nome;
                context.SaveChanges();
            }
        }

        public void EliminarTipo(int id)
        {
            using (ProjetoDAContext context = new ProjetoDAContext())
            {
                var tipo = context.TiposArtigo.Find(id);
                if (tipo != null)
                {
                    context.TiposArtigo.Remove(tipo);
                    context.SaveChanges();
                }
            }
        }




        // ---------- Artigos ----------


        public void InserirArtigo(string nome, double preco, int tipoArtigoId)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new InvalidOperationException("Nome não pode ser vazio.");
            if (preco <= 0)
                throw new InvalidOperationException("Preço deve ser maior que zero.");

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

        public void EditarArtigo(int id, string nome, double preco, int tipoArtigoId)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new InvalidOperationException("Nome não pode ser vazio.");
            if (preco <= 0)
                throw new InvalidOperationException("Preço deve ser maior que zero.");

            using (ProjetoDAContext context = new ProjetoDAContext())
            {
                var artigo = context.Artigos.Find(id);
                if (artigo == null) return;

                artigo.Nome = nome;
                artigo.Preco = preco;
                artigo.TipoArtigoId = tipoArtigoId;
                context.SaveChanges();
            }
        }

        public void EliminarArtigo(int id)
        {
            using (ProjetoDAContext context = new ProjetoDAContext())
            {
                var artigo = context.Artigos.Find(id);
                if (artigo != null)
                {
                    context.Artigos.Remove(artigo);
                    context.SaveChanges();
                }
            }
        }
    }
}
