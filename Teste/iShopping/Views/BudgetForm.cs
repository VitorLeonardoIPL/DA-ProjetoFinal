using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using iShopping.Controllers;
using iShopping.Models;
using iShopping.Utils;

namespace iShopping.Views
{
    /// <summary>
    /// Formulário de Gestão de Orçamentos.
    /// Permite:
    /// - Criar orçamento para um mês/ano
    /// - Editar o valor do orçamento
    /// - Eliminar orçamento
    /// - Ver todos os orçamentos
    /// - Ver saldo disponível (orçamento - gasto)
    /// 
    /// Regra: cada utilizador só pode ter UM orçamento por mês.
    /// </summary>
    public partial class BudgetForm : Form
    {
        private BudgetController _budgetController;
        private int _currentUserId;

        public BudgetForm()
        {
            InitializeComponent();
            _budgetController = new BudgetController();
            _currentUserId = SessionManager.GetUserId();
            LoadBudgets();
        }

        /// <summary>
        /// Carrega todos os orçamentos do utilizador logado.
        /// Mostra: Mês/Ano, Valor, Total Gasto, Saldo.
        /// </summary>
        private void LoadBudgets()
        {
            try
            {
                List<Budget> budgets = _budgetController.GetBudgetsByUser(_currentUserId);
                dgvBudgets.Rows.Clear();

                foreach (Budget budget in budgets)
                {
                    // Calcular quanto foi gasto neste mês
                    decimal spent = _budgetController.CalculateSpentInMonth(budget.UserId, budget.Month, budget.Year);
                    decimal balance = budget.Amount - spent;

                    // Formatar nome do mês
                    string monthName = BudgetController.GetMonthName(budget.Month);

                    int rowIndex = dgvBudgets.Rows.Add();
                    dgvBudgets.Rows[rowIndex].Cells["colId"].Value = budget.Id;
                    dgvBudgets.Rows[rowIndex].Cells["colMonthYear"].Value = monthName + " / " + budget.Year;
                    dgvBudgets.Rows[rowIndex].Cells["colAmount"].Value = budget.Amount.ToString("C2"); // Formato moeda
                    dgvBudgets.Rows[rowIndex].Cells["colSpent"].Value = spent.ToString("C2");
                    dgvBudgets.Rows[rowIndex].Cells["colBalance"].Value = balance.ToString("C2");

                    // Se saldo negativo, pintar a célula a vermelho
                    if (balance < 0)
                    {
                        dgvBudgets.Rows[rowIndex].Cells["colBalance"].Style.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        dgvBudgets.Rows[rowIndex].Cells["colBalance"].Style.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.ShowDatabaseError(ex);
            }
        }

        /// <summary>
        /// Evento ao clicar no botão "Novo".
        /// Abre diálogo para criar orçamento.
        /// </summary>
        private void BtnNew_Click(object sender, EventArgs e)
        {
            BudgetEditForm form = new BudgetEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBudgets();
            }
        }

        /// <summary>
        /// Evento ao clicar no botão "Editar".
        /// </summary>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBudgets.CurrentRow == null)
            {
                MessageBox.Show("Selecione um orçamento para editar.",
                    "Nenhuma seleção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int budgetId = Convert.ToInt32(dgvBudgets.CurrentRow.Cells["colId"].Value);

            // Obter dados do orçamento
            Budget budget = null;
            using (var context = new iShopping.Data.iShoppingContext())
            {
                budget = context.Budgets.FirstOrDefault(b => b.Id == budgetId);
            }

            if (budget != null)
            {
                BudgetEditForm form = new BudgetEditForm(budget);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadBudgets();
                }
            }
        }

        /// <summary>
        /// Evento ao clicar no botão "Eliminar".
        /// </summary>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBudgets.CurrentRow == null)
            {
                MessageBox.Show("Selecione um orçamento para eliminar.",
                    "Nenhuma seleção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int budgetId = Convert.ToInt32(dgvBudgets.CurrentRow.Cells["colId"].Value);
            string monthYear = dgvBudgets.CurrentRow.Cells["colMonthYear"].Value.ToString();

            DialogResult result = MessageBox.Show(
                "Tem a certeza que deseja eliminar o orçamento de " + monthYear + "?",
                "Confirmar eliminação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool success = _budgetController.DeleteBudget(budgetId);

                if (success)
                {
                    MessageBox.Show("Orçamento eliminado com sucesso.",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBudgets();
                }
                else
                {
                    MessageBox.Show("Erro ao eliminar o orçamento.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DgvBudgets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEdit_Click(sender, e);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
