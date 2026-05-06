using System;
using System.Windows.Forms;
using iShopping.Controllers;
using iShopping.Models;

namespace iShopping.Views
{
    /// <summary>
    /// Formulário de criação/edição de Tipo de Artigo.
    /// Serve para criar um novo tipo ou editar um existente.
    /// </summary>
    public partial class ArticleTypeEditForm : Form
    {
        private ArticleTypeController _typeController;
        private ArticleType _typeToEdit;

        /// <summary>
        /// Construtor para criar um NOVO tipo de artigo.
        /// </summary>
        public ArticleTypeEditForm()
        {
            InitializeComponent();
            _typeController = new ArticleTypeController();
            _typeToEdit = null;
            this.Text = "Novo Tipo de Artigo";
        }

        /// <summary>
        /// Construtor para EDITAR um tipo existente.
        /// </summary>
        public ArticleTypeEditForm(ArticleType type)
        {
            InitializeComponent();
            _typeController = new ArticleTypeController();
            _typeToEdit = type;
            this.Text = "Editar Tipo de Artigo";
            txtName.Text = _typeToEdit.Name;
        }

        /// <summary>
        /// Guardar alterações.
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Por favor, insira o nome do tipo.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            bool success;

            if (_typeToEdit == null)
            {
                // Modo criação
                success = _typeController.CreateType(name);
            }
            else
            {
                // Modo edição
                success = _typeController.UpdateType(_typeToEdit.Id, name);
            }

            if (success)
            {
                string msg = _typeToEdit == null ? "Tipo criado com sucesso!" : "Tipo atualizado com sucesso!";
                MessageBox.Show(msg, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Esse nome já existe. Escolha outro.",
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
