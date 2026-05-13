using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereOficicina.Model
{
    public class Carro
    {
        public int Id { get; set; }

        public string Matricula { get; set; }

        public Cliente Dono { get; set; }    
    }
}
