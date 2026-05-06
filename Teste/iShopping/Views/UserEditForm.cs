using System;
using System.Windows.Forms;
using iShopping.Controllers;
using iShopping.Models;

namespace iShopping.Views
{
    /// <summary>
    /// Formulário de Edição/Criação de Utilizador.
    /// Este formulário serve para DOIS propósitos:
    /// 1. Criar um novo utilizador (quando não recebe um utilizador)
    /// 2. Editar um utilizador existente (quando recebe um utilizador)
    /// 
    /// O modo de operação é definido pelo construtor.
    /// </summary>
    public partial class UserEditForm : Form
    {
        private UserController _userController;
        private User _userToEdit; // Se for null, estamos a criar. Se tiver valor, estamos a editar.

        /// <summary>
        /// Construtor para criar um NOVO utilizador.
        /// </summary>
        public UserEditForm()
        {
            InitializeComponent();
            _userController = new UserController();
            _userToEdit = null; // Sem utilizador = modo criação
            this.Text = "Novo Utilizador";
        }

        /// <summary>
        /// Construtor para EDITAR um utilizador existente.
        /// Recebe o utilizador a editar como parâmetro.
        /// </summary>
        public UserEditForm(User user)
        {
            InitializeComponent();
            _userController = new UserController();
            _userToEdit = user; // Utilizador recebido = modo edição
            this.Text = "Editar Utilizador";

            // Preencher os campos com os dados atuais do utilizador
            txtUsername.Text = _userToEdit.Username;
        }

        /// <summary>
        /// Evento ao clicar no botão "Guardar".
        /// Cria ou atualiza o utilizador na base de dados.
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Obter valores dos campos
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validar campos obrigatórios
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Por favor, insira um username.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            bool success = false;

            if (_userToEdit == null)
            {
                // ========================================================
                // MODO CRIAÇÃO: Criar um novo utilizador
                // ========================================================
                
                // Em modo criação, a password é obrigatória
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Por favor, insira uma password.",
                        "Campo obrigatório",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                success = _userController.Register(username, password);

                if (success)
                {
                    MessageBox.Show("Utilizador criado com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Esse username já existe. Escolha outro.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                // ========================================================
                // MODO EDIÇÃO: Atualizar um utilizador existente
                // ========================================================
                
                // Em modo edição, a password é opcional (só altera se for preenchida)
                success = _userController.UpdateUser(_userToEdit.Id, username, 
                    string.IsNullOrEmpty(password) ? null : password);

                if (success)
                {
                    MessageBox.Show("Utilizador atualizado com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar o utilizador. Verifique se o username já existe.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            // Se a operação foi bem-sucedida, fechar o formulário com resultado OK
            // Isto sinaliza ao formulário pai que a lista precisa de ser recarregada
            if (success)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        /// <summary>
        /// Evento ao clicar no botão "Cancelar".
        /// Fecha o formulário sem guardar alterações.
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
