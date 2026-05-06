using System;
using System.Collections.Generic;
using System.Windows.Forms;
using iShopping.Controllers;
using iShopping.Models;
using iShopping.Utils;

namespace iShopping.Views
{
    /// <summary>
    /// Formulário de Planeamento de Compras.
    /// Mostra a listagem de todas as compras do utilizador.
    /// Permite:
    /// - Filtrar por estado (Todas / Abertas / Fechadas)
    /// - Criar nova compra
    /// - Editar compra (só se aberta)
    /// - Eliminar compra (só se aberta)
    /// - Abrir Modo Compra
    /// - Abrir formulário de edição de itens previstos
    /// </summary>
    public partial class ShoppingPlanForm : Form
    {
        private ShoppingController _shoppingController;
        private int _currentUserId;

        public ShoppingPlanForm()
        {
            InitializeComponent();
            _shoppingController = new ShoppingController();
            _currentUserId = SessionManager.GetUserId();
            LoadFilterDropdown();
            LoadShoppingLists();
        }

        /// <summary>
        /// Carrega o dropdown de filtro com opções: Todas, Abertas, Fechadas.
        /// </summary>
        private void LoadFilterDropdown()
        {
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add(new ComboBoxItem("Todas", 0));
            cmbFilter.Items.Add(new ComboBoxItem("Abertas", 1));
            cmbFilter.Items.Add(new ComboBoxItem("Fechadas", 2));
            cmbFilter.SelectedIndex = 0; // "Todas" por defeito
        }

        /// <summary>
        /// Carrega as compras na DataGridView conforme o filtro selecionado.
        /// </summary>
        private void LoadShoppingLists()
        {
            try
            {
                List<ShoppingList> shoppingLists;

                ComboBoxItem selectedItem = (ComboBoxItem)cmbFilter.SelectedItem;
                int filterValue = selectedItem.Value;

                // Carregar conforme filtro
                switch (filterValue)
                {
                    case 1: // Abertas
                        shoppingLists = _shoppingController.GetOpenShoppingLists(_currentUserId);
                        break;
                    case 2: // Fechadas
                        shoppingLists = _shoppingController.GetClosedShoppingLists(_currentUserId);
                        break;
                    default: // Todas
                        shoppingLists = _shoppingController.GetAllShoppingLists(_currentUserId);
                        break;
                }

                dgvShopping.Rows.Clear();

            foreach (ShoppingList list in shoppingLists)
            {
                int rowIndex = dgvShopping.Rows.Add();
                dgvShopping.Rows[rowIndex].Cells["colId"].Value = list.Id;
                dgvShopping.Rows[rowIndex].Cells["colName"].Value = list.Name;
                dgvShopping.Rows[rowIndex].Cells["colDescription"].Value = list.Description;
                dgvShopping.Rows[rowIndex].Cells["colCreatedAt"].Value = list.CreatedAt.ToString("dd/MM/yyyy HH:mm");
                
                // Estado
                dgvShopping.Rows[rowIndex].Cells["colStatus"].Value = list.IsOpen ? "Aberta" : "Fechada";
                
                // Se fechada, mostrar data de fecho
                string closedInfo = list.ClosedAt.HasValue ? list.ClosedAt.Value.ToString("dd/MM/yyyy HH:mm") : "-";
                dgvShopping.Rows[rowIndex].Cells["colClosedAt"].Value = closedInfo;

                // Pintar estado: verde = aberta, vermelho = fechada
                if (list.IsOpen)
                {
                    dgvShopping.Rows[rowIndex].Cells["colStatus"].Style.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    dgvShopping.Rows[rowIndex].Cells["colStatus"].Style.ForeColor = System.Drawing.Color.Red;
                }
            }
            }
            catch (Exception ex)
            {
                ErrorHelper.ShowDatabaseError(ex);
            }
        }

        /// <summary>
        /// Filtro mudou → recarregar lista.
        /// </summary>
        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadShoppingLists();
        }

        /// <summary>
        /// Criar nova compra.
        /// </summary>
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ShoppingEditForm form = new ShoppingEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadShoppingLists();
            }
        }

        /// <summary>
        /// Editar dados da compra (nome, descrição).
        /// Só possível se estiver aberta.
        /// </summary>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvShopping.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma compra para editar.",
                    "Nenhuma seleção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int shoppingId = Convert.ToInt32(dgvShopping.CurrentRow.Cells["colId"].Value);
            ShoppingList shoppingList = _shoppingController.GetShoppingListById(shoppingId);

            if (shoppingList == null)
            {
                MessageBox.Show("Erro ao carregar a compra.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!shoppingList.IsOpen)
            {
                MessageBox.Show("Não é possível editar uma compra já fechada.",
                    "Compra fechada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShoppingEditForm form = new ShoppingEditForm(shoppingList);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadShoppingLists();
            }
        }

        /// <summary>
        /// Abrir o formulário de gestão de itens previstos.
        /// </summary>
        private void BtnItems_Click(object sender, EventArgs e)
        {
            if (dgvShopping.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma compra para gerir os itens.",
                    "Nenhuma seleção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int shoppingId = Convert.ToInt32(dgvShopping.CurrentRow.Cells["colId"].Value);
            ShoppingList shoppingList = _shoppingController.GetShoppingListById(shoppingId);

            if (shoppingList != null)
            {
                // Abrir formulário de edição de itens
                ShoppingItemsForm form = new ShoppingItemsForm(shoppingList);
                form.ShowDialog();
                LoadShoppingLists(); // Recarregar (itens podem ter mudado)
            }
        }

        /// <summary>
        /// Abrir Modo Compra.
        /// </summary>
        private void BtnShoppingMode_Click(object sender, EventArgs e)
        {
            if (dgvShopping.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma compra para entrar no Modo Compra.",
                    "Nenhuma seleção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int shoppingId = Convert.ToInt32(dgvShopping.CurrentRow.Cells["colId"].Value);
            ShoppingList shoppingList = _shoppingController.GetShoppingListById(shoppingId);

            if (shoppingList == null) return;

            if (!shoppingList.IsOpen)
            {
                MessageBox.Show("Esta compra já está fechada. Não é possível abrir o Modo Compra.",
                    "Compra fechada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShoppingModeForm form = new ShoppingModeForm(shoppingList);
            form.ShowDialog();
            LoadShoppingLists();
        }

        /// <summary>
        /// Eliminar compra.
        /// </summary>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvShopping.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma compra para eliminar.",
                    "Nenhuma seleção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int shoppingId = Convert.ToInt32(dgvShopping.CurrentRow.Cells["colId"].Value);
            string shoppingName = dgvShopping.CurrentRow.Cells["colName"].Value.ToString();

            DialogResult result = MessageBox.Show(
                "Tem a certeza que deseja eliminar a compra '" + shoppingName + "'?\n" +
                "Todos os itens previstos e não previstos serão eliminados.",
                "Confirmar eliminação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool success = _shoppingController.DeleteShoppingList(shoppingId);

                if (success)
                {
                    MessageBox.Show("Compra eliminada com sucesso.",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadShoppingLists();
                }
                else
                {
                    MessageBox.Show("Não é possível eliminar uma compra fechada.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DgvShopping_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Duplo clique = abrir gestão de itens
            BtnItems_Click(sender, e);
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
