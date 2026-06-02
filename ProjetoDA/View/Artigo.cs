using ProjetoDA.Controller;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class Artigo : UserControl
    {
        private Model.ProjetoDAContext db = new Model.ProjetoDAContext();
        private Model.Artigo artigoSelecionado;

        public Artigo()
        {
            InitializeComponent();
            CarregarTipos();
            CarregarArtigos();
        }

        private void CarregarTipos()
        {
            var tipos = ArtigoController.ListarTipos(db).ToList();

            cmbFiltrarTipo.Items.Clear();
            cmbFiltrarTipo.Items.Add("(Todos)");
            cmbFiltrarTipo.Items.AddRange(tipos.ToArray());
            cmbFiltrarTipo.DisplayMember = "Nome";
            cmbFiltrarTipo.SelectedIndex = 0;

            cmbTipoArtigo.Items.Clear();
            cmbTipoArtigo.Items.AddRange(tipos.ToArray());
            cmbTipoArtigo.DisplayMember = "Nome";
        }

        private void CarregarArtigos()
        {
            int? tipoId = null;
            if (cmbFiltrarTipo.SelectedIndex > 0)
            {
                var tipo = cmbFiltrarTipo.SelectedItem as Model.TipoArtigo;
                tipoId = tipo?.Id;
            }

            listArtigos.DataSource = ArtigoController.ListarArtigos(db, tipoId).ToList();
            listArtigos.DisplayMember = "Nome";
            listArtigos.ValueMember = "Id";
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            cmbTipoArtigo.SelectedIndex = -1;
            artigoSelecionado = null;
        }

        private void listArtigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            artigoSelecionado = listArtigos.SelectedItem as Model.Artigo;
            if (artigoSelecionado != null)
            {
                txtNome.Text = artigoSelecionado.Nome;
                txtDescricao.Text = artigoSelecionado.Descricao;

                for (int i = 0; i < cmbTipoArtigo.Items.Count; i++)
                {
                    var tipo = cmbTipoArtigo.Items[i] as Model.TipoArtigo;
                    if (tipo != null && tipo.Id == artigoSelecionado.TipoArtigoId)
                    {
                        cmbTipoArtigo.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void cmbFiltrarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarArtigos();
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

            var tipo = cmbTipoArtigo.SelectedItem as Model.TipoArtigo;
            if (tipo == null)
            {
                MessageBox.Show("Selecione um tipo de artigo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (artigoSelecionado == null)
            {
                ArtigoController.InserirArtigo(db, txtNome.Text.Trim(), txtDescricao.Text.Trim(), tipo.Id);
            }
            else
            {
                artigoSelecionado.Nome = txtNome.Text.Trim();
                artigoSelecionado.Descricao = txtDescricao.Text.Trim();
                artigoSelecionado.TipoArtigoId = tipo.Id;
                ArtigoController.AtualizarArtigo(db, artigoSelecionado);
            }

            LimparCampos();
            CarregarArtigos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (artigoSelecionado == null)
            {
                MessageBox.Show("Selecione um artigo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show($"Eliminar o artigo \"{artigoSelecionado.Nome}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                ArtigoController.EliminarArtigo(db, artigoSelecionado.Id);
                LimparCampos();
                CarregarArtigos();
            }
        }
    }
}
