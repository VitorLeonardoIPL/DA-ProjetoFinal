using System;
using System.Windows.Forms;
using iShopping.Controllers;

namespace iShopping.Views
{
    /// <summary>
    /// Formulário de registo de novo utilizador.
    /// Permite criar uma conta com username e password.
    /// Validações:
    /// - Username único (não pode existir outro igual)
    /// - Campos obrigatórios
    /// </summary>
    public partial class RegisterForm : Form
    {
        private UserController _userController;

        public RegisterForm()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        /// <summary>
        /// Evento ao clicar no botão "Registar".
        /// Cria um novo utilizador na base de dados.
        /// </summary>
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Obter valores dos campos
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Validar campos preenchidos
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Por favor, preencha todos os campos.",
                    "Campos obrigatórios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validar que as passwords são iguais
            if (password != confirmPassword)
            {
                MessageBox.Show("As passwords não coincidem. Tente novamente.",
                    "Erro de password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Tentar registar
            bool success = _userController.Register(username, password);

            if (success)
            {
                // Registo bem-sucedido!
                MessageBox.Show("Utilizador registado com sucesso! Já pode fazer login.",
                    "Registo concluído",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Fechar o formulário de registo e voltar ao Login
                this.Close();
            }
            else
            {
                // Username já existe
                MessageBox.Show("Esse username já está em uso. Escolha outro.",
                    "Username indisponível",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento ao clicar no botão "Cancelar".
        /// Fecha o formulário sem criar utilizador.
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
