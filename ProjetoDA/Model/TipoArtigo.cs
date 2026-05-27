using System;

namespace ProjetoDA.Model
{
    public class TipoArtigo
    {
         public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            string descricao = $"{Nome,-5}";

            return descricao;
        }

    }

}
