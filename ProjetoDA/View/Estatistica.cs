using ProjetoDA.Controller;
using ProjetoDA.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class Estatistica : UserControl
    {
        public Estatistica()
        {
            InitializeComponent();
        }

        private void tabControlEstatistica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlEstatistica.SelectedTab == tabPageMensal)
                CarregarListagemMensal();
            else if (tabControlEstatistica.SelectedTab == tabPageSugestoes)
                CarregarSugestoes();
        }

        private void CarregarListagemMensal()
        {
            listBoxMensal.DataSource = null;

            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                var dados = EstatisticaController.ListagemMensal(db);
                listBoxMensal.DataSource = dados;
                listBoxMensal.DisplayMember = "Item1";
                listBoxMensal.ValueMember = "Item1";

                listBoxMensal.DataSource = null;
                listBoxMensal.Items.Clear();
                foreach (var item in dados)
                    listBoxMensal.Items.Add($"Mês: {item[0]}  |  Orçamento: {item[1]}€  |  Total Compras: {item[2]}€  |  Diferença: {item[3]}€");
            }
        }

        private void CarregarSugestoes()
        {
            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                decimal? sugestao = EstatisticaController.SugerirOrcamento(db);
                textBoxSugestaoOrcamento.Text = sugestao.HasValue
                    ? $"{sugestao.Value:F2}€ (média dos últimos 3 meses)"
                    : "Sem dados suficientes";

                listBoxSugestoes.DataSource = null;
                listBoxSugestoes.Items.Clear();
                var sugestaoCompras = EstatisticaController.SugerirListaCompras(db);
                if (sugestaoCompras.Count == 0)
                {
                    listBoxSugestoes.Items.Add("Sem dados de compras anteriores para esta semana.");
                }
                else
                {
                    listBoxSugestoes.Items.Add("Artigo".PadRight(35) + "Qtd. Média");
                    listBoxSugestoes.Items.Add(new string('-', 50));
                    foreach (var item in sugestaoCompras)
                        listBoxSugestoes.Items.Add($"{item[0],-35} {item[1],10:F2}");
                }

                listBoxAnalise.DataSource = null;
                listBoxAnalise.Items.Clear();
                var percentagens = EstatisticaController.PercentagensPorCompra(db);
                if (percentagens.Count == 0)
                {
                    listBoxAnalise.Items.Add("Sem compras fechadas para análise.");
                }
                else
                {
                    listBoxAnalise.Items.Add("Compra".PadRight(30) + "%Previsto".PadLeft(12) + "%NãoPrev".PadLeft(12));
                    listBoxAnalise.Items.Add(new string('-', 55));
                    foreach (var item in percentagens)
                        listBoxAnalise.Items.Add($"{item[0],-30} {item[1],10:F2}% {item[2],10:F2}%");
                }
            }
        }

        private void buttonRefreshMensal_Click(object sender, EventArgs e)
        {
            CarregarListagemMensal();
        }

        private void buttonRefreshSugestoes_Click(object sender, EventArgs e)
        {
            CarregarSugestoes();
        }

        private void buttonExportarCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            sfd.FileName = $"{DateTime.Now:yyyy-MM-dd}_compras.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (ProjetoDAContext db = new ProjetoDAContext())
                {
                    EstatisticaController.ExportarCSV(db, sfd.FileName);
                }
                MessageBox.Show($"CSV exportado para:\n{sfd.FileName}", "Exportado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
