using System;
using System.Windows.Forms;
using iShopping.Controllers;
using iShopping.Models;
using iShopping.Utils;

namespace iShopping.Views
{
    /// <summary>
    /// Formulário de Login.
    /// É o primeiro formulário que o utilizador vê ao abrir a aplicação.
    /// Permite:
    /// - Fazer login com username e password
    /// - Registar um novo utilizador
    /// </summary>
    public partial class LoginForm : Form
    {
        // Instância do controlador de utilizadores (acesso à base de dados)
        private UserController _userController;

        public LoginForm()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        /// <summary>
        /// Evento disparado ao clicar no botão "Login".
        /// Valida as credenciais e, se corretas, abre o formulário principal.
        /// </summary>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Obter valores dos campos de texto
            string username = txtUsername.Text.Trim(); // Trim remove espaços antes/depois
            string password = txtPassword.Text;

            // Validar campos preenchidos
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, preencha o username e a password.",
                    "Campos obrigatórios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return; // Não prosseguir se campos estão vazios
            }

            try
            {
                // Tentar login através do controlador
                User user = _userController.Login(username, password);

                if (user != null)
                {
                    // Login bem-sucedido!
                    // Guardar o utilizador na sessão para acesso global
                    SessionManager.Login(user);

                    // Esconder a janela de Login
                    this.Hide();

                    // Abrir o formulário principal
                    MainForm mainForm = new MainForm();
                    mainForm.FormClosed += (s, args) => this.Close(); // Se fechar o Main, fecha o Login também
                    mainForm.Show();
                }
                else
                {
                    // Login falhou
                    MessageBox.Show("Username ou password incorretos. Tente novamente.",
                        "Login falhou",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.ShowDatabaseError(ex);
            }
        }

        /// <summary>
        /// Evento disparado ao clicar no botão "Registar".
        /// Abre o formulário de registo de novo utilizador.
        /// </summary>
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Abrir formulário de registo
            RegisterForm registerForm = new RegisterForm();
            
            // Mostrar como diálogo (bloqueia o Login até o registo ser fechado)
            registerForm.ShowDialog();
        }

        /// <summary>
        /// Evento disparado ao pressionar Enter num dos campos de texto.
        /// Simula o clique no botão Login para maior comodidade.
        /// </summary>
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
