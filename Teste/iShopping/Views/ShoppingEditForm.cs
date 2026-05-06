using System;
using System.Windows.Forms;
using iShopping.Controllers;
using iShopping.Models;
using iShopping.Utils;

namespace iShopping.Views
{
    /// <summary>
    /// Formulário de criação/edição de uma compra planeada.
    /// Permite definir o nome e a descrição da compra.
    /// </summary>
    public partial class ShoppingEditForm : Form
    {
        private ShoppingController _shoppingController;
        private ShoppingList _shoppingListToEdit;

        /// <summary>
        /// Construtor para criar uma NOVA compra.
        /// </summary>
        public ShoppingEditForm()
        {
            InitializeComponent();
            _shoppingController = new ShoppingController();
            _shoppingListToEdit = null;
            this.Text = "Nova Compra";
        }

        /// <summary>
        /// Construtor para EDITAR uma compra existente.
        /// </summary>
        public ShoppingEditForm(ShoppingList shoppingList)
        {
            InitializeComponent();
            _shoppingController = new ShoppingController();
            _shoppingListToEdit = shoppingList;
            this.Text = "Editar Compra";

            // Preencher campos
            txtName.Text = _shoppingListToEdit.Name;
            txtDescription.Text = _shoppingListToEdit.Description;
        }

        /// <summary>
        /// Guardar a compra.
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Por favor, insira um nome para a compra.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            bool success;

            if (_shoppingListToEdit == null)
            {
                // Modo criação
                int userId = SessionManager.GetUserId();
                int newId = _shoppingController.CreateShoppingList(userId, name, description);

                if (newId > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                    MessageBox.Show("Erro ao criar a compra.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Modo edição
                success = _shoppingController.UpdateShoppingList(_shoppingListToEdit.Id, name, description);
            }

            if (success)
            {
                string msg = _shoppingListToEdit == null ? "Compra criada com sucesso!" : "Compra atualizada com sucesso!";
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
