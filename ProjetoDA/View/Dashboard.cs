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
            listBox1.DataSource = null;
            listBox1.DataSource = CompraController.Listar(db).ToList();
            listBox1.DisplayMember = "Nome";
            listBox1.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: Abrir formulário de nova compra
        }
    }
}
