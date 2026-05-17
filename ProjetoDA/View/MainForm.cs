using ProjetoDA.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA
{
    public partial class MainForm : Form
    {

        bool sidebarExpand;
        private Dashboard dashboardView;
        private TipoArtigo tipoArtigoView;
        private Artigo artigosView;
        private Orcamento orcamentoView;
        private Estatistica estatisticasView;
        public NovaCompra novaCompraView;
        public NovoArtigo novoArtigoView;
        public NovoTipoArtigo novoTipoArtigoView;
        public NovoOrcamento novoOrcamentoView;

        public MainForm()
        {
            InitializeComponent();

            // Criar uma instância de cada UserControl Menu
            dashboardView = new Dashboard();
            tipoArtigoView = new TipoArtigo();
            artigosView = new Artigo();
            orcamentoView = new Orcamento();
            estatisticasView = new Estatistica();

            // Views Para adicionar Entidades
            novaCompraView = new NovaCompra();
            novoArtigoView = new NovoArtigo();
            novoTipoArtigoView = new NovoTipoArtigo();
            novoOrcamentoView = new NovoOrcamento();

            // Mostrar o Dashboard por defeito ao abrir
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(dashboardView);
            dashboardView.Dock = DockStyle.Fill;


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {

            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(dashboardView);
            dashboardView.Dock = DockStyle.Fill;

        }

        private void button_TipoArtigo_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(tipoArtigoView);
            tipoArtigoView.Dock = DockStyle.Fill;
        }

        private void button_Artigos_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(artigosView);
            artigosView.Dock = DockStyle.Fill;
        }

        private void button_Orcamento_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(orcamentoView);
            orcamentoView.Dock = DockStyle.Fill;
        }

        private void button_Estatistica_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(estatisticasView);
            estatisticasView.Dock = DockStyle.Fill;
        }

        public void ShowNovaCompra()
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(novaCompraView);
            novaCompraView.Dock = DockStyle.Fill;
        }

        public void ShowNovoArtigo()
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(novoArtigoView);
            novoArtigoView.Dock = DockStyle.Fill;
        }

        public void ShowNovoTipoArtigo()
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(novoTipoArtigoView);
            novoTipoArtigoView.Dock = DockStyle.Fill;
        }

        public void ShowNovoOrcamento()
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(novoOrcamentoView);
            novoOrcamentoView.Dock = DockStyle.Fill;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new View.Login_Page();
            if (loginForm.ShowDialog() == DialogResult.OK)
                this.Show();
            else
                this.Close();

        }
    }
}
