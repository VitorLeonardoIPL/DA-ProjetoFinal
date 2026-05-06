using System;
using System.Collections.Generic;
using System.Windows.Forms;
using iShopping.Controllers;
using iShopping.Models;
using iShopping.Utils;

namespace iShopping.Views
{
    /// <summary>
    /// Formulário de criação/edição de Artigos.
    /// 
    /// Regra importante: ao criar ou editar um artigo,
    /// o utilizador deve primeiro escolher o Tipo de Artigo,
    /// e depois escrever o nome do artigo.
    /// </summary>
    public partial class ArticleEditForm : Form
    {
        private ArticleController _articleController;
        private ArticleTypeController _typeController;
        private Article _articleToEdit;

        /// <summary>
        /// Construtor para criar um NOVO artigo.
        /// </summary>
        public ArticleEditForm()
        {
            InitializeComponent();
            _articleController = new ArticleController();
            _typeController = new ArticleTypeController();
            _articleToEdit = null;
            this.Text = "Novo Artigo";
            LoadTypesDropdown();
        }

        /// <summary>
        /// Construtor para EDITAR um artigo existente.
        /// </summary>
        public ArticleEditForm(Article article)
        {
            InitializeComponent();
            _articleController = new ArticleController();
            _typeController = new ArticleTypeController();
            _articleToEdit = article;
            this.Text = "Editar Artigo";
            LoadTypesDropdown();

            // Preencher campos com dados atuais
            txtName.Text = _articleToEdit.Name;
            SelectTypeInDropdown(_articleToEdit.ArticleTypeId);
        }

        /// <summary>
        /// Carrega todos os tipos de artigo no dropdown.
        /// O utilizador deve escolher um tipo para o artigo.
        /// </summary>
        private void LoadTypesDropdown()
        {
            List<ArticleType> types = _typeController.GetAllTypes();

            cmbType.Items.Clear();
            foreach (ArticleType type in types)
            {
                // ComboBoxItem = classe auxiliar com Display (texto) e Value (ID)
                cmbType.Items.Add(new ComboBoxItem(type.Name, type.Id));
            }

            // Selecionar o primeiro tipo se houver algum
            if (cmbType.Items.Count > 0)
            {
                cmbType.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Seleciona um tipo específico no dropdown (usado em modo edição).
        /// </summary>
        private void SelectTypeInDropdown(int typeId)
        {
            for (int i = 0; i < cmbType.Items.Count; i++)
            {
                ComboBoxItem item = (ComboBoxItem)cmbType.Items[i];
                if (item.Value == typeId)
                {
                    cmbType.SelectedIndex = i;
                    return;
                }
            }
        }

        /// <summary>
        /// Guardar o artigo (criar ou atualizar).
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            // Validar nome
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Por favor, insira o nome do artigo.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validar que um tipo foi selecionado
            if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um tipo de artigo.\n\n" +
                    "Se não houver tipos disponíveis, crie primeiro um Tipo de Artigo.",
                    "Tipo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Obter o ID do tipo selecionado
            ComboBoxItem selectedItem = (ComboBoxItem)cmbType.SelectedItem;
            int typeId = selectedItem.Value;

            bool success;

            if (_articleToEdit == null)
            {
                // Modo criação
                success = _articleController.CreateArticle(name, typeId);
            }
            else
            {
                // Modo edição
                success = _articleController.UpdateArticle(_articleToEdit.Id, name, typeId);
            }

            if (success)
            {
                string msg = _articleToEdit == null ? "Artigo criado com sucesso!" : "Artigo atualizado com sucesso!";
                MessageBox.Show(msg, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Já existe um artigo com esse nome neste tipo.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
