using ProjetoDA.Controller;
using ProjetoDA.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class Dashboard : UserControl
    {
        private ProjetoDAContext db = new ProjetoDAContext();

        public Dashboard()
        {
            InitializeComponent();
            CarregarCompras();
        }

        private void CarregarCompras()
        {
            listCompras.DataSource = CompraController.Listar(db).ToList();
            listCompras.DisplayMember = "DisplayText";
            listCompras.ValueMember = "Id";
        }
    }
}
