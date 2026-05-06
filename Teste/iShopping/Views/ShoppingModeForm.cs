using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using iShopping.Controllers;
using iShopping.Models;
using iShopping.Utils;

namespace iShopping.Views
{
    /// <summary>
    /// Formulário do Modo Compra.
    /// É aqui que o utilizador regista o que efetivamente comprou.
    /// 
    /// Funcionalidades:
    /// - Lista de itens previstos (preencher Quantidade Adquirida e Preço Unitário)
    /// - Adicionar itens não previstos (artigo novo, observações, quantidade, preço)
    /// - Visualização do Orçamento Disponível em tempo real
    /// - Aviso visual (vermelho) se o orçamento for ultrapassado
    /// - Botão "Fechar Compra" (finaliza a compra)
    /// </summary>
    public partial class ShoppingModeForm : Form
    {
        private ShoppingController _shoppingController;
        private BudgetController _budgetController;
        private ShoppingList _shoppingList;
        private int _currentUserId;

        // Variável para guardar o orçamento do mês atual
        private decimal _currentBudgetAmount = 0;

        public ShoppingModeForm(ShoppingList shoppingList)
        {
            InitializeComponent();
            _shoppingList = shoppingList;
            _shoppingController = new ShoppingController();
            _budgetController = new BudgetController();
            _currentUserId = SessionManager.GetUserId();

            // Configurar interface
            lblShoppingName.Text = "Compra: " + shoppingList.Name;
            LoadPlannedItems();
            LoadUnplannedItems();
            UpdateBudgetDisplay();

            // Se já estiver fechada, bloquear edição
            if (!_shoppingList.IsOpen)
            {
                SetReadOnlyMode();
            }
        }

        /// <summary>
        /// Carrega os itens previstos na DataGridView de itens planeados.
        /// </summary>
        private void LoadPlannedItems()
        {
            List<ShoppingItem> items = _shoppingController.GetShoppingItems(_shoppingList.Id);
            dgvPlanned.Rows.Clear();

            foreach (ShoppingItem item in items)
            {
                int rowIndex = dgvPlanned.Rows.Add();
                dgvPlanned.Rows[rowIndex].Cells["colItemId"].Value = item.Id;
                dgvPlanned.Rows[rowIndex].Cells["colArticleName"].Value = item.Article.Name;
                dgvPlanned.Rows[rowIndex].Cells["colPlannedQty"].Value = item.PlannedQuantity;
                
                // Se já tem quantidade adquirida, mostrar
                if (item.AcquiredQuantity.HasValue)
                {
                    dgvPlanned.Rows[rowIndex].Cells["colAcquiredQty"].Value = item.AcquiredQuantity.Value;
                }
                else
                {
                    dgvPlanned.Rows[rowIndex].Cells["colAcquiredQty"].Value = 0;
                }

                // Se já tem preço, mostrar
                if (item.UnitPrice.HasValue)
                {
                    dgvPlanned.Rows[rowIndex].Cells["colUnitPrice"].Value = item.UnitPrice.Value.ToString("F2");
                }
                else
                {
                    dgvPlanned.Rows[rowIndex].Cells["colUnitPrice"].Value = "0.00";
                }

                // Subtotal (Qtd Adquirida × Preço)
                decimal subtotal = 0;
                if (item.AcquiredQuantity.HasValue && item.UnitPrice.HasValue)
                {
                    subtotal = item.AcquiredQuantity.Value * item.UnitPrice.Value;
                }
                dgvPlanned.Rows[rowIndex].Cells["colSubtotal"].Value = subtotal.ToString("C2");
            }
        }

        /// <summary>
        /// Carrega os itens não previstos na DataGridView.
        /// </summary>
        private void LoadUnplannedItems()
        {
            List<UnplannedItem> items = _shoppingController.GetUnplannedItems(_shoppingList.Id);
            dgvUnplanned.Rows.Clear();

            foreach (UnplannedItem item in items)
            {
                int rowIndex = dgvUnplanned.Rows.Add();
                dgvUnplanned.Rows[rowIndex].Cells["colUnplannedId"].Value = item.Id;
                dgvUnplanned.Rows[rowIndex].Cells["colUnplannedName"].Value = item.ArticleName;
                dgvUnplanned.Rows[rowIndex].Cells["colUnplannedObs"].Value = item.Observations;
                dgvUnplanned.Rows[rowIndex].Cells["colUnplannedQty"].Value = item.Quantity;
                dgvUnplanned.Rows[rowIndex].Cells["colUnplannedPrice"].Value = item.UnitPrice.ToString("C2");

                decimal subtotal = item.Quantity * item.UnitPrice;
                dgvUnplanned.Rows[rowIndex].Cells["colUnplannedSubtotal"].Value = subtotal.ToString("C2");
            }
        }

        /// <summary>
        /// Atualiza a visualização do orçamento.
        /// Calcula: Orçamento - Total Gasto (previstos + não previstos)
        /// Se ultrapassado, muda a cor para vermelho.
        /// </summary>
        private void UpdateBudgetDisplay()
        {
            // Obter orçamento do mês atual
            Budget budget = _budgetController.GetCurrentMonthBudget(_currentUserId);

            if (budget == null)
            {
                lblBudgetStatus.Text = "Sem orçamento definido para este mês.";
                lblBudgetStatus.ForeColor = Color.Gray;
                return;
            }

            _currentBudgetAmount = budget.Amount;

            // Calcular total gasto
            decimal totalSpent = CalculateCurrentTotal();
            decimal balance = _currentBudgetAmount - totalSpent;

            // Atualizar labels
            lblBudgetAmount.Text = "Orçamento: " + _currentBudgetAmount.ToString("C2");
            lblSpent.Text = "Gasto: " + totalSpent.ToString("C2");
            lblBalance.Text = "Saldo: " + balance.ToString("C2");

            // Mudar cor conforme o saldo
            if (balance < 0)
            {
                // Orçamento ultrapassado!
                lblBalance.ForeColor = Color.Red;
                lblBudgetStatus.Text = "⚠ ATENÇÃO: Orçamento ultrapassado!";
                lblBudgetStatus.ForeColor = Color.Red;
                lblBudgetStatus.Font = new Font(lblBudgetStatus.Font, FontStyle.Bold);
            }
            else if (balance < _currentBudgetAmount * 0.1m)
            {
                // Perto do limite (menos de 10%)
                lblBalance.ForeColor = Color.Orange;
                lblBudgetStatus.Text = "⚠ Atenção: Orçamento quase esgotado!";
                lblBudgetStatus.ForeColor = Color.Orange;
                lblBudgetStatus.Font = new Font(lblBudgetStatus.Font, FontStyle.Regular);
            }
            else
            {
                // Tudo OK
                lblBalance.ForeColor = Color.Green;
                lblBudgetStatus.Text = "Orçamento dentro do limite.";
                lblBudgetStatus.ForeColor = Color.Green;
                lblBudgetStatus.Font = new Font(lblBudgetStatus.Font, FontStyle.Regular);
            }
        }

        /// <summary>
        /// Calcula o total gasto atualmente na compra.
        /// Soma itens previstos adquiridos + itens não previstos.
        /// </summary>
        private decimal CalculateCurrentTotal()
        {
            decimal total = 0;

            // Somar da DataGridView de previstos
            foreach (DataGridViewRow row in dgvPlanned.Rows)
            {
                if (row.Cells["colAcquiredQty"].Value != null && row.Cells["colUnitPrice"].Value != null)
                {
                    int qty = Convert.ToInt32(row.Cells["colAcquiredQty"].Value);
                    decimal price = 0;
                    decimal.TryParse(row.Cells["colUnitPrice"].Value.ToString(), out price);

                    total += qty * price;
                }
            }

            // Somar da DataGridView de não previstos
            foreach (DataGridViewRow row in dgvUnplanned.Rows)
            {
                if (row.Cells["colUnplannedSubtotal"].Value != null)
                {
                    decimal subtotal = 0;
                    decimal.TryParse(row.Cells["colUnplannedSubtotal"].Value.ToString().Replace("€", "").Trim(), out subtotal);
                    total += subtotal;
                }
            }

            return total;
        }

        /// <summary>
        /// Quando o utilizador altera a quantidade ou preço de um item previsto,
        /// recalcula o subtotal e atualiza o orçamento.
        /// </summary>
        private void DgvPlanned_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPlanned.Rows[e.RowIndex];

            // Obter valores
            int qty = 0;
            decimal price = 0;
            int.TryParse(row.Cells["colAcquiredQty"].Value?.ToString(), out qty);
            decimal.TryParse(row.Cells["colUnitPrice"].Value?.ToString(), out price);

            // Atualizar subtotal
            decimal subtotal = qty * price;
            row.Cells["colSubtotal"].Value = subtotal.ToString("C2");

            // Guardar na base de dados (atualizar item)
            int itemId = Convert.ToInt32(row.Cells["colItemId"].Value);
            if (qty > 0)
            {
                // Aqui podíamos chamar o controller para atualizar, 
                // mas para simplificar, guardamos tudo ao fechar a compra.
                // O importante é atualizar o display do orçamento.
            }

            // Atualizar orçamento
            UpdateBudgetDisplay();
        }

        /// <summary>
        /// Adicionar um item não previsto.
        /// </summary>
        private void BtnAddUnplanned_Click(object sender, EventArgs e)
        {
            string name = txtUnplannedName.Text.Trim();
            string observations = txtUnplannedObs.Text.Trim();
            int qty = (int)numUnplannedQty.Value;
            decimal price = 0;
            decimal.TryParse(txtUnplannedPrice.Text, out price);

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Insira o nome do artigo.",
                    "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show("Insira um preço válido.",
                    "Preço inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = _shoppingController.AddUnplannedItem(_shoppingList.Id, name, qty, price, observations);

            if (success)
            {
                // Limpar campos
                txtUnplannedName.Text = "";
                txtUnplannedObs.Text = "";
                numUnplannedQty.Value = 1;
                txtUnplannedPrice.Text = "";

                LoadUnplannedItems();
                UpdateBudgetDisplay();
            }
            else
            {
                MessageBox.Show("Erro ao adicionar o artigo.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remover um item não previsto.
        /// </summary>
        private void BtnRemoveUnplanned_Click(object sender, EventArgs e)
        {
            if (dgvUnplanned.CurrentRow == null) return;

            int itemId = Convert.ToInt32(dgvUnplanned.CurrentRow.Cells["colUnplannedId"].Value);
            bool success = _shoppingController.RemoveUnplannedItem(itemId);

            if (success)
            {
                LoadUnplannedItems();
                UpdateBudgetDisplay();
            }
        }

        /// <summary>
        /// Fechar a compra.
        /// Guarda todas as alterações e marca a compra como fechada.
        /// </summary>
        private void BtnCloseShopping_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem a certeza que deseja fechar esta compra?\n" +
                "Após fechar, não será possível alterar os dados.",
                "Fechar Compra",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // 1. Guardar itens previstos (quantidade e preço)
                    foreach (DataGridViewRow row in dgvPlanned.Rows)
                    {
                        int itemId = Convert.ToInt32(row.Cells["colItemId"].Value);
                        int qty = 0;
                        decimal price = 0;
                        
                        int.TryParse(row.Cells["colAcquiredQty"].Value?.ToString(), out qty);
                        decimal.TryParse(row.Cells["colUnitPrice"].Value?.ToString(), out price);

                        // Atualizar diretamente via contexto (simplificação para o projeto académico)
                        using (var context = new Data.iShoppingContext())
                        {
                            var item = context.ShoppingItems.Find(itemId);
                            if (item != null)
                            {
                                item.AcquiredQuantity = qty > 0 ? qty : (int?)null;
                                item.UnitPrice = price > 0 ? price : (decimal?)null;
                            }
                            context.SaveChanges();
                        }
                    }

                    // 2. Fechar a compra
                    bool success = _shoppingController.CloseShoppingList(_shoppingList.Id, _currentUserId);

                    if (success)
                    {
                        MessageBox.Show("Compra fechada com sucesso!",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao fechar a compra.",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    ErrorHelper.ShowGeneralError(ex, "fecho da compra");
                }
            }
        }

        /// <summary>
        /// Modo somente leitura (quando a compra já está fechada).
        /// </summary>
        private void SetReadOnlyMode()
        {
            dgvPlanned.ReadOnly = true;
            txtUnplannedName.Enabled = false;
            txtUnplannedObs.Enabled = false;
            numUnplannedQty.Enabled = false;
            txtUnplannedPrice.Enabled = false;
            btnAddUnplanned.Enabled = false;
            btnRemoveUnplanned.Enabled = false;
            btnCloseShopping.Enabled = false;
            btnCloseShopping.Text = "Compra Fechada";
        }

        /// <summary>
        /// Evento ao clicar no botão "Fechar".
        /// </summary>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
