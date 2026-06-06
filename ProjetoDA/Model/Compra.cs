using System;
using System.Collections.Generic;

namespace ProjetoDA.Model
{
    public class Compra
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double total { get; set; }

        public bool Fechada { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataFechada { get; set; }

        public int UtilizadorCriadoId { get; set; }
        public Utilizador UtilizadorCriado { get; set; }

       

        public int? UtilizadorFechouId { get; set; }
        public Utilizador UtilizadorFechou { get; set; }

        public int? UtilizadorEditouId { get; set; }
        public Utilizador UtilizadorEditou { get; set; }

        public List<ItemCompra> ItensCompra { get; set; }

        public override string ToString()
        {
            string estado = Fechada ? "Fechada" : "Aberta";
            return $"{Nome,-30} {estado,-10} {DataCriacao:dd/MM/yyyy}";
        }
    }
}
