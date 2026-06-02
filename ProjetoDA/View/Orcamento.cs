using ProjetoDA.Controller;
using ProjetoDA.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class Orcamento : UserControl
    {
        private ProjetoDAContext db = new ProjetoDAContext();
        private Model.Orcamento orcamentoSelecionado;

        public Orcamento()
        {
            InitializeComponent();
            CarregarLista();
        }

        private void CarregarLista()
        {
            listOrcamentos.DataSource = OrcamentoController.Listar(db).ToList();
            listOrcamentos.DisplayMember = "DisplayText";
            listOrcamentos.ValueMember = "Id";
        }

        private void LimparCampos()
        {
            txtValor.Text = "";
            cmbMes.SelectedIndex = -1;
            txtAno.Text = "";
            orcamentoSelecionado = null;
        }

        private void listOrcamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            orcamentoSelecionado = listOrcamentos.SelectedItem as Model.Orcamento;
            if (orcamentoSelecionado != null)
            {
                txtValor.Text = orcamentoSelecionado.Valor.ToString("F2");
                cmbMes.SelectedItem = orcamentoSelecionado.Mes.ToString("D2");
                txtAno.Text = orcamentoSelecionado.Ano.ToString();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtValor.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtValor.Text, out decimal valor) || valor <= 0)
            {
                MessageBox.Show("Insira um valor válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMes.SelectedItem == null)
            {
                MessageBox.Show("Selecione o mês.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAno.Text, out int ano) || ano < 2000 || ano > 2100)
            {
                MessageBox.Show("Insira um ano válido (2000-2100).", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int mes = int.Parse(cmbMes.SelectedItem.ToString().Split('-')[0].Trim());

            if (orcamentoSelecionado == null)
            {
                OrcamentoController.Inserir(db, mes, ano, valor);
            }
            else
            {
                orcamentoSelecionado.Valor = valor;
                orcamentoSelecionado.Mes = mes;
                orcamentoSelecionado.Ano = ano;
                OrcamentoController.Atualizar(db, orcamentoSelecionado);
            }

            LimparCampos();
            CarregarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (orcamentoSelecionado == null)
            {
                MessageBox.Show("Selecione um orçamento para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show($"Eliminar orçamento de {orcamentoSelecionado.Mes:D2}/{orcamentoSelecionado.Ano}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                OrcamentoController.Eliminar(db, orcamentoSelecionado.Id);
                LimparCampos();
                CarregarLista();
            }
        }
    }
}
