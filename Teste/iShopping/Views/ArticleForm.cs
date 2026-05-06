using System;
using System.Collections.Generic;
using System.Windows.Forms;
using iShopping.Controllers;
using iShopping.Models;
using iShopping.Utils;

namespace iShopping.Views
{
    /// <summary>
    /// Formulário de Gestão de Artigos.
    /// Permite:
    /// - Listar todos os artigos
    /// - Filtrar artigos por Tipo de Artigo (dropdown no topo)
    /// - Criar novos artigos
    /// - Editar artigos existentes
    /// - Eliminar artigos
    /// 
    /// O filtro é importante: primeiro escolhe-se o tipo, depois veem-se só os artigos desse tipo.
    /// </summary>
    public partial class ArticleForm : Form
    {
        private ArticleController _articleController;
        private ArticleTypeController _typeController;

        public ArticleForm()
        {
            InitializeComponent();
            _articleController = new ArticleController();
            _typeController = new ArticleTypeController();
            LoadTypesDropdown(); // Carregar os tipos no dropdown
            LoadArticles(); // Carregar lista de artigos
        }

        /// <summary>
        /// Carrega todos os tipos de artigo no dropdown de filtro.
        /// Adiciona também uma opção "Todos" para mostrar tudo.
        /// </summary>
        private void LoadTypesDropdown()
        {
            List<ArticleType> types = _typeController.GetAllTypes();

            // Limpar o dropdown
            cmbFilterType.Items.Clear();

            // Adicionar opção "Todos" no início (valor -1 = mostrar tudo)
            cmbFilterType.Items.Add(new ComboBoxItem("Todos", -1));

            // Adicionar cada tipo de artigo
            foreach (ArticleType type in types)
            {
                cmbFilterType.Items.Add(new ComboBoxItem(type.Name, type.Id));
            }

            // Selecionar "Todos" por defeito
            cmbFilterType.SelectedIndex = 0;
        }

        /// <summary>
        /// Carrega os artigos na DataGridView.
        /// Se um tipo estiver selecionado no filtro, mostra só artigos desse tipo.
        /// Se "Todos" estiver selecionado, mostra todos os artigos.
        /// </summary>
        private void LoadArticles()
        {
            List<Article> articles;

            // Obter o tipo selecionado no dropdown
            ComboBoxItem selectedItem = (ComboBoxItem)cmbFilterType.SelectedItem;
            int selectedTypeId = selectedItem.Value;

            // Carregar artigos conforme o filtro
            if (selectedTypeId == -1)
            {
                // -1 = mostrar todos
                articles = _articleController.GetAllArticles();
            }
            else
            {
                // Mostrar só artigos do tipo selecionado
                articles = _articleController.GetArticlesByType(selectedTypeId);
            }

            // Limpar e repovoar a DataGridView
            dgvArticles.Rows.Clear();

            foreach (Article article in articles)
            {
                int rowIndex = dgvArticles.Rows.Add();
                dgvArticles.Rows[rowIndex].Cells["colId"].Value = article.Id;
                dgvArticles.Rows[rowIndex].Cells["colName"].Value = article.Name;
                dgvArticles.Rows[rowIndex].Cells["colType"].Value = article.ArticleType.Name;
            }
        }

        /// <summary>
        /// Evento disparado quando o utilizador muda o tipo no dropdown.
        /// Recarrega os artigos conforme o filtro selecionado.
        /// </summary>
        private void CmbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadArticles();
        }

        /// <summary>
        /// Evento ao clicar no botão "Novo".
        /// Abre formulário para criar artigo.
        /// </summary>
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ArticleEditForm form = new ArticleEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadTypesDropdown(); // Recarregar dropdown (pode haver novos tipos)
                LoadArticles();
            }
        }

        /// <summary>
        /// Evento ao clicar no botão "Editar".
        /// </summary>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvArticles.CurrentRow == null)
            {
                MessageBox.Show("Selecione um artigo para editar.",
                    "Nenhuma seleção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int articleId = Convert.ToInt32(dgvArticles.CurrentRow.Cells["colId"].Value);
            Article article = _articleController.GetArticleById(articleId);

            ArticleEditForm form = new ArticleEditForm(article);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadTypesDropdown();
                LoadArticles();
            }
        }

        /// <summary>
        /// Evento ao clicar no botão "Eliminar".
        /// </summary>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvArticles.CurrentRow == null)
            {
                MessageBox.Show("Selecione um artigo para eliminar.",
                    "Nenhuma seleção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int articleId = Convert.ToInt32(dgvArticles.CurrentRow.Cells["colId"].Value);
            string articleName = dgvArticles.CurrentRow.Cells["colName"].Value.ToString();

            DialogResult result = MessageBox.Show(
                "Tem a certeza que deseja eliminar o artigo '" + articleName + "'?",
                "Confirmar eliminação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool success = _articleController.DeleteArticle(articleId);

                if (success)
                {
                    MessageBox.Show("Artigo eliminado com sucesso.",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadArticles();
                }
                else
                {
                    MessageBox.Show("Erro ao eliminar o artigo.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Duplo clique = editar.
        /// </summary>
        private void DgvArticles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEdit_Click(sender, e);
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
