using System;
using System.Windows.Forms;
using iShopping.Utils;

namespace iShopping.Views
{
    /// <summary>
    /// Formulário Principal (Menu Principal).
    /// Aparece após o login bem-sucedido.
    /// 
    /// Este formulário funciona como o "hub" central da aplicação.
    /// A partir daqui, o utilizador pode aceder a todas as funcionalidades:
    /// - Gestão de Utilizadores
    /// - Gestão de Tipos de Artigo
    /// - Gestão de Artigos
    /// - Gestão de Orçamentos
    /// - Planeamento de Compras
    /// - Modo Compra
    /// - Estatísticas
    /// - Logout
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Mostrar o nome do utilizador logado na label
            lblWelcome.Text = "Bem-vindo, " + SessionManager.GetUsername() + "!";
        }

        // ================================================================
        // Eventos dos Botões do Menu
        // Cada botão abre um formulário diferente
        // ================================================================

        /// <summary>
        /// Abrir formulário de Gestão de Utilizadores.
        /// </summary>
        private void BtnUsers_Click(object sender, EventArgs e)
        {
            UserManagementForm form = new UserManagementForm();
            form.ShowDialog(); // ShowDialog = abre como janela modal
        }

        /// <summary>
        /// Abrir formulário de Gestão de Tipos de Artigo.
        /// </summary>
        private void BtnArticleTypes_Click(object sender, EventArgs e)
        {
            ArticleTypeForm form = new ArticleTypeForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Abrir formulário de Gestão de Artigos.
        /// </summary>
        private void BtnArticles_Click(object sender, EventArgs e)
        {
            ArticleForm form = new ArticleForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Abrir formulário de Gestão de Orçamentos.
        /// </summary>
        private void BtnBudgets_Click(object sender, EventArgs e)
        {
            BudgetForm form = new BudgetForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Abrir formulário de Planeamento de Compras.
        /// </summary>
        private void BtnShoppingPlans_Click(object sender, EventArgs e)
        {
            ShoppingPlanForm form = new ShoppingPlanForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Abrir formulário de Estatísticas.
        /// </summary>
        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm form = new StatisticsForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Fazer logout.
        /// Limpa a sessão e volta ao formulário de Login.
        /// </summary>
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // Confirmar se o utilizador quer mesmo sair
            DialogResult result = MessageBox.Show("Tem a certeza que deseja sair?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Limpar a sessão (remove o utilizador logado)
                SessionManager.Logout();

                // Fechar o formulário principal
                // Isto faz com que o LoginForm reapareça (ou a aplicação feche)
                this.Close();
            }
        }
    }
}
