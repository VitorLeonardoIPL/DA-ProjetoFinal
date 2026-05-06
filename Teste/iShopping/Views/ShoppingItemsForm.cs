using System;
using System.Collections.Generic;
using System.Windows.Forms;
using iShopping.Controllers;
using iShopping.Models;
using iShopping.Utils;

namespace iShopping.Views
{
    /// <summary>
    /// Formulário de gestão de itens previstos numa compra.
    /// Permite:
    /// - Adicionar artigos planeados à compra
    /// - Remover artigos planeados
    /// - Alterar quantidades planeadas
    /// 
    /// Regra: ao escolher um artigo, primeiro seleciona-se o Tipo de Artigo,
    /// depois o Artigo específico.
    /// </summary>
    public partial class ShoppingItemsForm : Form
    {
        private ShoppingController _shoppingController;
        private ArticleController _articleController;
        private ArticleTypeController _typeController;
        private ShoppingList _shoppingList;

        public ShoppingItemsForm(ShoppingList shoppingList)
        {
            InitializeComponent();
            _shoppingList = shoppingList;
            _shoppingController = new ShoppingController();
            _articleController = new ArticleController();
            _typeController = new ArticleTypeController();

            // Mostrar nome da compra no título
            this.Text = "Itens Previstos - " + shoppingList.Name;
            lblShoppingName.Text = "Compra: " + shoppingList.Name;

            LoadTypesDropdown();
            LoadItems();

            // Se compra fechada, desabilitar botões de edição
            if (!_shoppingList.IsOpen)
            {
                btnAdd.Enabled = false;
                btnRemove.Enabled = false;
                cmbType.Enabled = false;
                cmbArticle.Enabled = false;
                numQuantity.Enabled = false;
            }
        }

        /// <summary>
        /// Carrega os tipos de artigo no dropdown.
        /// </summary>
        private void LoadTypesDropdown()
        {
            List<ArticleType> types = _typeController.GetAllTypes();
            cmbType.Items.Clear();

            foreach (ArticleType type in types)
            {
                cmbType.Items.Add(new ComboBoxItem(type.Name, type.Id));
            }

            if (cmbType.Items.Count > 0)
            {
                cmbType.SelectedIndex = 0;
                LoadArticlesByType(); // Carregar artigos do primeiro tipo
            }
        }

        /// <summary>
        /// Carrega os artigos do tipo selecionado no dropdown de artigos.
        /// Chamado quando o utilizador muda o tipo.
        /// </summary>
        private void LoadArticlesByType()
        {
            if (cmbType.SelectedItem == null) return;

            ComboBoxItem selectedType = (ComboBoxItem)cmbType.SelectedItem;
            List<Article> articles = _articleController.GetArticlesByType(selectedType.Value);

            cmbArticle.Items.Clear();
            foreach (Article article in articles)
            {
                cmbArticle.Items.Add(new ComboBoxItem(article.Name, article.Id));
            }

            if (cmbArticle.Items.Count > 0)
            {
                cmbArticle.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Quando o tipo muda, recarregar os artigos.
        /// </summary>
        private void CmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadArticlesByType();
        }

        /// <summary>
        /// Carrega os itens previstos na DataGridView.
        /// </summary>
        private void LoadItems()
        {
            List<ShoppingItem> items = _shoppingController.GetShoppingItems(_shoppingList.Id);
            dgvItems.Rows.Clear();

            foreach (ShoppingItem item in items)
            {
                int rowIndex = dgvItems.Rows.Add();
                dgvItems.Rows[rowIndex].Cells["colId"].Value = item.Id;
                dgvItems.Rows[rowIndex].Cells["colArticleType"].Value = item.Article.ArticleType.Name;
                dgvItems.Rows[rowIndex].Cells["colArticleName"].Value = item.Article.Name;
                dgvItems.Rows[rowIndex].Cells["colPlannedQty"].Value = item.PlannedQuantity;

                // Quantidade adquirida (só aparece se já foi comprada)
                if (item.AcquiredQuantity.HasValue)
                {
                    dgvItems.Rows[rowIndex].Cells["colAcquiredQty"].Value = item.AcquiredQuantity.Value;
                    dgvItems.Rows[rowIndex].Cells["colUnitPrice"].Value = item.UnitPrice.Value.ToString("C2");
                }
                else
                {
                    dgvItems.Rows[rowIndex].Cells["colAcquiredQty"].Value = "-";
                    dgvItems.Rows[rowIndex].Cells["colUnitPrice"].Value = "-";
                }
            }
        }

        /// <summary>
        /// Adicionar um item previsto à compra.
        /// </summary>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (cmbArticle.SelectedItem == null)
            {
                MessageBox.Show("Selecione um artigo.",
                    "Artigo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int quantity = (int)numQuantity.Value;
            if (quantity < 1)
            {
                MessageBox.Show("A quantidade deve ser pelo menos 1.",
                    "Quantidade inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            ComboBoxItem selectedArticle = (ComboBoxItem)cmbArticle.SelectedItem;
            int articleId = selectedArticle.Value;

            bool success = _shoppingController.AddShoppingItem(_shoppingList.Id, articleId, quantity);

            if (success)
            {
                MessageBox.Show("Artigo adicionado à lista de compras.",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadItems();
            }
            else
            {
                MessageBox.Show("Este artigo já está na lista de compras.",
                    "Artigo duplicado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Remover um item previsto da compra.
        /// </summary>
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null)
            {
                MessageBox.Show("Selecione um item para remover.",
                    "Nenhuma seleção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int itemId = Convert.ToInt32(dgvItems.CurrentRow.Cells["colId"].Value);

            bool success = _shoppingController.RemoveShoppingItem(itemId);

            if (success)
            {
                MessageBox.Show("Item removido da lista.",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadItems();
            }
            else
            {
                MessageBox.Show("Não é possível remover este item.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
