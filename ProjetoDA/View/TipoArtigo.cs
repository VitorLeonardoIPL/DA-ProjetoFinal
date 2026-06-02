using ProjetoDA.Controller;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class TipoArtigo : UserControl
    {
        private Model.ProjetoDAContext db = new Model.ProjetoDAContext();
        private Model.TipoArtigo tipoSelecionado;

        public TipoArtigo()
        {
            InitializeComponent();
            CarregarLista();
        }

        private void CarregarLista()
        {
            listTipos.DataSource = ArtigoController.ListarTipos(db).ToList();
            listTipos.DisplayMember = "Nome";
            listTipos.ValueMember = "Id";
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            tipoSelecionado = null;
        }

        private void listTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoSelecionado = listTipos.SelectedItem as Model.TipoArtigo;
            if (tipoSelecionado != null)
            {
                txtNome.Text = tipoSelecionado.Nome;
                txtDescricao.Text = tipoSelecionado.Descricao;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtNome.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tipoSelecionado == null)
            {
                ArtigoController.InserirTipo(db, txtNome.Text.Trim(), txtDescricao.Text.Trim());
            }
            else
            {
                tipoSelecionado.Nome = txtNome.Text.Trim();
                tipoSelecionado.Descricao = txtDescricao.Text.Trim();
                ArtigoController.AtualizarTipo(db, tipoSelecionado);
            }

            LimparCampos();
            CarregarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tipoSelecionado == null)
            {
                MessageBox.Show("Selecione um tipo de artigo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show($"Eliminar o tipo \"{tipoSelecionado.Nome}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                ArtigoController.EliminarTipo(db, tipoSelecionado.Id);
                LimparCampos();
                CarregarLista();
            }
        }
    }
}
