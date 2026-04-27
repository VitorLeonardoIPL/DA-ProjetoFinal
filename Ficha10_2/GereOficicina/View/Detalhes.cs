using GereOficicina.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GereOficicina.View
{
    public partial class Detalhes : Form
    {
        public Detalhes(Cliente cliente)
        {
            InitializeComponent();

            labelNome.Text = cliente.Nome;
            labelNif.Text = cliente.Nif;
        }


        private void Detalhes_Load(object sender, EventArgs e)
        {

        }
    }
}
