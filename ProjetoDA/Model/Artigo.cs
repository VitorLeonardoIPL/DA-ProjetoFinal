using System;

namespace ProjetoDA.Model
{
    public class Artigo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int TipoArtigoId { get; set; }

        public double Preco {  get; set; }
        public DateTime DataCriacao { get; set; }

        public TipoArtigo TipoArtigo { get; set; }



        public override string ToString()
        {
            string descricao = $"{TipoArtigoId,-5} {Nome,-30} {Preco,10}"; ;

            return descricao;
        }

    }
}
