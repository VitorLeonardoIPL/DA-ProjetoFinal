using ProjetoDA.Controller;
using ProjetoDA.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class CompraPlaneamento : UserControl
    {
        public CompraPlaneamento()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            listBoxCompras.DataSource = null;

            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                string filtro = comboBoxFiltro.SelectedItem?.ToString();

                IQueryable<Compra> query = db.Compras.Include("UtilizadorCriado");

                if (filtro == "Abertas")
                    query = query.Where(c => !c.Fechada);
                else if (filtro == "Fechadas")
                    query = query.Where(c => c.Fechada);

                listBoxCompras.DataSource = query.OrderByDescending(c => c.DataCriacao).ToList();
                listBoxCompras.DisplayMember = "ToString";
            }
        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void buttonNovaCompra_Click(object sender, EventArgs e)
        {
            CompraEditar form = new CompraEditar();
            form.ShowDialog();
            AtualizarLista();
        }

        private void buttonEditarCompra_Click(object sender, EventArgs e)
        {
            Compra compra = listBoxCompras.SelectedItem as Compra;
            if (compra == null)
            {
                MessageBox.Show("Selecionar uma compra");
                return;
            }

            if (compra.Fechada)
            {
                MessageBox.Show("Não é possível editar uma compra fechada");
                return;
            }

            CompraEditar form = new CompraEditar(compra.Id);
            form.ShowDialog();
            AtualizarLista();
        }

        private void listBoxCompras_DoubleClick(object sender, EventArgs e)
        {
            Compra compra = listBoxCompras.SelectedItem as Compra;
            if (compra == null) return;

            CompraEditar form = new CompraEditar(compra.Id);
            form.ShowDialog();
            AtualizarLista();
        }

        private void buttonModoCompra_Click(object sender, EventArgs e)
        {
            Compra compra = listBoxCompras.SelectedItem as Compra;
            if (compra == null)
            {
                MessageBox.Show("Selecionar uma compra");
                return;
            }

            if (compra.Fechada)
            {
                MessageBox.Show("Não é possível abrir o modo compra de uma compra fechada");
                return;
            }

            CompraModo form = new CompraModo(compra.Id);
            form.ShowDialog();
            AtualizarLista();
        }
    }
}
