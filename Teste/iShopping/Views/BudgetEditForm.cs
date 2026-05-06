using System;
using System.Windows.Forms;
using iShopping.Controllers;
using iShopping.Models;

namespace iShopping.Views
{
    /// <summary>
    /// Formulário de criação/edição de Orçamento.
    /// Permite definir o orçamento para um determinado mês e ano.
    /// </summary>
    public partial class BudgetEditForm : Form
    {
        private BudgetController _budgetController;
        private Budget _budgetToEdit;

        /// <summary>
        /// Construtor para criar um NOVO orçamento.
        /// </summary>
        public BudgetEditForm()
        {
            InitializeComponent();
            _budgetController = new BudgetController();
            _budgetToEdit = null;
            this.Text = "Novo Orçamento";
            LoadMonthsDropdown();
        }

        /// <summary>
        /// Construtor para EDITAR um orçamento existente.
        /// </summary>
        public BudgetEditForm(Budget budget)
        {
            InitializeComponent();
            _budgetController = new BudgetController();
            _budgetToEdit = budget;
            this.Text = "Editar Orçamento";
            LoadMonthsDropdown();

            // Preencher campos
            txtAmount.Text = budget.Amount.ToString("F2"); // Formato com 2 casas decimais
            
            // Selecionar o mês correto no dropdown
            SelectMonthInDropdown(budget.Month);
            
            // Ano
            numYear.Value = budget.Year;

            // Desabilitar mudança de mês/ano em modo edição (não faz sentido alterar)
            cmbMonth.Enabled = false;
            numYear.Enabled = false;
        }

        /// <summary>
        /// Carrega os 12 meses no dropdown.
        /// </summary>
        private void LoadMonthsDropdown()
        {
            string[] monthNames = {
                "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
            };

            cmbMonth.Items.Clear();
            foreach (string name in monthNames)
            {
                cmbMonth.Items.Add(name);
            }

            // Selecionar o mês atual por defeito
            int currentMonth = DateTime.Now.Month;
            cmbMonth.SelectedIndex = currentMonth - 1; // Índice começa em 0

            // Definir ano atual por defeito
            numYear.Value = DateTime.Now.Year;
            numYear.Minimum = 2020;
            numYear.Maximum = 2030;
        }

        /// <summary>
        /// Seleciona um mês específico no dropdown.
        /// </summary>
        private void SelectMonthInDropdown(int month)
        {
            if (month >= 1 && month <= 12)
            {
                cmbMonth.SelectedIndex = month - 1;
            }
        }

        /// <summary>
        /// Guardar orçamento.
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validar valor
            decimal amount;
            if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Por favor, insira um valor válido para o orçamento.",
                    "Valor inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            bool success;

            if (_budgetToEdit == null)
            {
                // Modo criação
                int month = cmbMonth.SelectedIndex + 1; // Índice 0 = Janeiro (mês 1)
                int year = (int)numYear.Value;
                int userId = Utils.SessionManager.GetUserId();

                success = _budgetController.CreateBudget(userId, month, year, amount);

                if (!success)
                {
                    string monthName = BudgetController.GetMonthName(month);
                    MessageBox.Show("Já existe um orçamento para " + monthName + " de " + year + ".",
                        "Orçamento existente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Modo edição
                success = _budgetController.UpdateBudget(_budgetToEdit.Id, amount);
            }

            if (success)
            {
                string msg = _budgetToEdit == null ? "Orçamento criado com sucesso!" : "Orçamento atualizado com sucesso!";
                MessageBox.Show(msg, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
