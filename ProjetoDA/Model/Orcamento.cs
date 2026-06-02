using System;

namespace ProjetoDA.Model
{
    public class Orcamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        /*  public int UtilizadorCriadoId { get; set; }
          public Utilizador UtilizadorCriado { get; set; }

          public int? UtilizadorEditouId { get; set; }
          public Utilizador UtilizadorEditou { get; set; }


          */

        public override string ToString()
        {
            string descricao = $"{Nome,-30} {Valor,-5} {DataInicio,20} {DataFim,30}";

            return descricao;
        }




    }
}
