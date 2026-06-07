using ProjetoDA.Controller;
using ProjetoDA.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class UtilizadorControl : UserControl
    {
        public UtilizadorControl()
        {
            InitializeComponent();
            AtualizarUtilizadores();
        }

        private void AtualizarUtilizadores()
        {
            listBoxUtilizadores.DataSource = null;

            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                listBoxUtilizadores.DataSource = UtilizadorController.Listar(db).ToList();
            }
        }

        private void listBoxUtilizadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilizador user = listBoxUtilizadores.SelectedItem as Utilizador;
            if (user != null)
            {
                textBoxUsername.Text = user.Username;
                textBoxPassword.Text = user.Password;
                textBoxEmail.Text = user.Email;
            }
            else
            {
                LimparCampos();
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Username e Password são obrigatórios.");
                return;
            }

            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                bool ok = UtilizadorController.Registar(db, textBoxUsername.Text, textBoxPassword.Text, textBoxEmail.Text);
                if (!ok)
                {
                    MessageBox.Show("Username já existe.");
                    return;
                }
            }

            AtualizarUtilizadores();
            LimparCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Utilizador user = listBoxUtilizadores.SelectedItem as Utilizador;
            if (user == null)
            {
                MessageBox.Show("Selecionar um utilizador.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Username e Password são obrigatórios.");
                return;
            }

            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                user.Username = textBoxUsername.Text;
                user.Password = textBoxPassword.Text;
                user.Email = textBoxEmail.Text;
                UtilizadorController.Atualizar(db, user);
            }

            AtualizarUtilizadores();
            LimparCampos();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            Utilizador user = listBoxUtilizadores.SelectedItem as Utilizador;
            if (user == null)
            {
                MessageBox.Show("Selecionar um utilizador.");
                return;
            }

            if (MessageBox.Show($"Remover utilizador '{user.Username}'?", "Confirmar",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                using (ProjetoDAContext db = new ProjetoDAContext())
                {
                    UtilizadorController.Eliminar(db, user.Id);
                }

                AtualizarUtilizadores();
                LimparCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Não é possível remover este utilizador pois existem registos (compras, orçamentos) associados a ele.");
            }
        }

        private void LimparCampos()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxEmail.Clear();
        }
    }
}
