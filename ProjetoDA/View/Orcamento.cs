using ProjetoDA.Controller;
using ProjetoDA.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class OrcamentoControl : UserControl
    {
        private ProjetoDAContext db = new ProjetoDAContext();
        private Orcamento orcamentoSelecionado;

        public OrcamentoControl()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            listBoxOrcamentos.DataSource = null;
            listBoxOrcamentos.DataSource = OrcamentoController.Listar(db);
            listBoxOrcamentos.DisplayMember = "Nome";
            listBoxOrcamentos.ValueMember = "Id";
        }

        private void LimparCampos()
        {
            textBoxNomeOrcamento.Text = "";
            textBoxValor.Text = "";
            dateTimePickerDataInicio.Value = DateTime.Today;
            dateTimePickerDataFim.Value = DateTime.Today;
            orcamentoSelecionado = null;
            listBoxOrcamentos.ClearSelected();
        }

        private void listBoxOrcamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            orcamentoSelecionado = listBoxOrcamentos.SelectedItem as Orcamento;
            if (orcamentoSelecionado != null)
            {
                textBoxNomeOrcamento.Text = orcamentoSelecionado.Nome;
                textBoxValor.Text = orcamentoSelecionado.Valor.ToString("F2");
                dateTimePickerDataInicio.Value = orcamentoSelecionado.DataInicio;
                dateTimePickerDataFim.Value = orcamentoSelecionado.DataFim;
            }
        }

        private void buttonNovoOrcamento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomeOrcamento.Text))
            {
                MessageBox.Show("O nome é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBoxValor.Text, out decimal valor) || valor <= 0)
            {
                MessageBox.Show("Insira um valor válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (orcamentoSelecionado == null)
            {
                OrcamentoController controller = new OrcamentoController();
                controller.Inserir(textBoxNomeOrcamento.Text.Trim(), valor, dateTimePickerDataInicio.Value, dateTimePickerDataFim.Value);
            }
            else
            {
                orcamentoSelecionado.Nome = textBoxNomeOrcamento.Text.Trim();
                orcamentoSelecionado.Valor = valor;
                orcamentoSelecionado.DataInicio = dateTimePickerDataInicio.Value;
                orcamentoSelecionado.DataFim = dateTimePickerDataFim.Value;
                OrcamentoController.Atualizar(db, orcamentoSelecionado);
            }

            LimparCampos();
            AtualizarLista();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (orcamentoSelecionado == null)
            {
                MessageBox.Show("Selecione um orçamento para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show($"Eliminar o orçamento \"{orcamentoSelecionado.Nome}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                OrcamentoController.Eliminar(db, orcamentoSelecionado.Id);
                LimparCampos();
                AtualizarLista();
            }
        }
    }
}
