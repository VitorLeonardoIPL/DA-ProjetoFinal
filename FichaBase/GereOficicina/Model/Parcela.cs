using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereOficicina.Model
{
    public class Parcela
    {
        public int Id { get; set; }

        public Decimal Valor { get; set; }

        public string Descricao { get; set; }

        public List<Servico> Servicos { get; set; }
    }
}
