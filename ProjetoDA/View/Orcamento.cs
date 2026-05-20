using ProjetoDA.Controller;
using ProjetoDA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class Orcamento : UserControl
    {
        public Orcamento()
        {
            InitializeComponent();

            // Recarrega a lista sempre que o ecrã se torna visível
            // (o UserControl é criado uma vez e reutilizado — Load só dispara uma vez)
            this.VisibleChanged += (s, e) =>
            {
                if (this.Visible)
                    CarregarOrcamentos();
            };
        }

        // Vai buscar todos os orçamentos à base de dados e preenche a listBox
        private void CarregarOrcamentos()
        {
            listBoxOrcamentos.Items.Clear();

            try
            {
                using (var db = new ProjetoDAContext())
                {
                    var orcamentos = OrcamentoController.Listar(db).ToList();

                    if (orcamentos.Count == 0)
                    {
                        listBoxOrcamentos.Items.Add("Sem orçamentos registados.");
                        return;
                    }

                    foreach (var orc in orcamentos)
                    {
                        // Formato: Nome | Mês/Ano | Valor: X €
                        string linha = $"{orc.Nome} | {orc.Mes:D2}/{orc.Ano} | Valor: {orc.Valor:F2} €";
                        listBoxOrcamentos.Items.Add(linha);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar orçamentos:\n{ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNovoOrcamento_Click(object sender, EventArgs e)
        {
            var mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
                mainForm.ShowNovoOrcamento();
        }

        // Evento gerado pelo Designer — reservado para futura interação com a seleção
        private void listBoxOrcamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
