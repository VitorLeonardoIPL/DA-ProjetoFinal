using System;

namespace ProjetoDA.Model
{
    public class Orcamento
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public DateTime DataCriacao { get; set; }

        public int UtilizadorCriadoId { get; set; }
        public Utilizador UtilizadorCriado { get; set; }

        public int? UtilizadorEditouId { get; set; }
        public Utilizador UtilizadorEditou { get; set; }
    }
}
