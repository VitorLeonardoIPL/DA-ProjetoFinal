using System;
using System.Collections.Generic;
using System.Windows.Forms;
using iShopping.Controllers;
using iShopping.Models;

namespace iShopping.Views
{
    /// <summary>
    /// Formulário de Gestão de Utilizadores.
    /// Permite:
    /// - Listar todos os utilizadores
    /// - Adicionar novos utilizadores
    /// - Editar utilizadores existentes
    /// - Eliminar utilizadores
    /// 
    /// Este é um CRUD completo (Create, Read, Update, Delete).
    /// </summary>
    public partial class UserManagementForm : Form
    {
        private UserController _userController;

        public UserManagementForm()
        {
            InitializeComponent();
            _userController = new UserController();
            LoadUsers(); // Carregar a lista ao abrir o formulário
        }

        /// <summary>
        /// Carrega todos os utilizadores da base de dados para o DataGridView.
        /// Este método é chamado sempre que a lista precisa de ser atualizada
        /// (após criar, editar ou eliminar).
        /// </summary>
        private void LoadUsers()
        {
            // Obter todos os utilizadores do controlador
            List<User> users = _userController.GetAllUsers();

            // Limpar a DataGridView
            dgvUsers.Rows.Clear();

            // Adicionar cada utilizador à DataGridView
            foreach (User user in users)
            {
                // Adicionar uma nova linha com os dados do utilizador
                int rowIndex = dgvUsers.Rows.Add();
                dgvUsers.Rows[rowIndex].Cells["colId"].Value = user.Id;
                dgvUsers.Rows[rowIndex].Cells["colUsername"].Value = user.Username;
            }
        }

        /// <summary>
        /// Evento ao clicar no botão "Novo".
        /// Abre um diálogo para criar um novo utilizador.
        /// </summary>
        private void BtnNew_Click(object sender, EventArgs e)
        {
            UserEditForm form = new UserEditForm(); // Modo de criação
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Se o utilizador foi criado com sucesso, recarregar a lista
                LoadUsers();
            }
        }

        /// <summary>
        /// Evento ao clicar no botão "Editar".
        /// Abre um diálogo para editar o utilizador selecionado.
        /// </summary>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // Verificar se há uma linha selecionada
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Selecione um utilizador para editar.",
                    "Nenhuma seleção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Obter o ID do utilizador da linha selecionada
            int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["colId"].Value);
            User user = _userController.GetUserById(userId);

            // Abrir formulário de edição com o utilizador
            UserEditForm form = new UserEditForm(user); // Modo de edição
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        /// <summary>
        /// Evento ao clicar no botão "Eliminar".
        /// Remove o utilizador selecionado da base de dados.
        /// </summary>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Verificar se há uma linha selecionada
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Selecione um utilizador para eliminar.",
                    "Nenhuma seleção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Obter o ID e o username do utilizador selecionado
            int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["colId"].Value);
            string username = dgvUsers.CurrentRow.Cells["colUsername"].Value.ToString();

            // Confirmar com o utilizador antes de eliminar
            DialogResult result = MessageBox.Show("Tem a certeza que deseja eliminar o utilizador '" + username + "'?",
                "Confirmar eliminação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool success = _userController.DeleteUser(userId);

                if (success)
                {
                    MessageBox.Show("Utilizador eliminado com sucesso.",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadUsers(); // Recarregar a lista
                }
                else
                {
                    MessageBox.Show("Erro ao eliminar o utilizador.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Evento ao clicar duas vezes numa linha da DataGridView.
        /// Abre o formulário de edição para esse utilizador.
        /// </summary>
        private void DgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Chamar o mesmo código do botão Editar
            BtnEdit_Click(sender, e);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
