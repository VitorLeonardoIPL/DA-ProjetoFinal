using ProjetoDA.Controller;
using ProjetoDA.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class TipoArtigoControl : UserControl
    {
        private ProjetoDAContext db = new ProjetoDAContext();
        private TipoArtigo tipoSelecionado;

        public TipoArtigoControl()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            listboxTiposArtigo.DataSource = null;
            listboxTiposArtigo.DataSource = ArtigoController.ListarTipos(db);
            listboxTiposArtigo.DisplayMember = "Nome";
            listboxTiposArtigo.ValueMember = "Id";
        }

        private void LimparCampos()
        {
            textBoxNome.Text = "";
            tipoSelecionado = null;
            listboxTiposArtigo.ClearSelected();
        }

        private void listboxTiposArtigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoSelecionado = listboxTiposArtigo.SelectedItem as TipoArtigo;
            if (tipoSelecionado != null)
            {
                textBoxNome.Text = tipoSelecionado.Nome;
            }
        }

        private void buttonAddTipoArtigo(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                MessageBox.Show("O nome é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tipoSelecionado == null)
            {
                // Inserir novo
                ArtigoController controller = new ArtigoController();
                controller.InserirTipo(textBoxNome.Text.Trim());
            }
            else
            {
                // Atualizar existente
                tipoSelecionado.Nome = textBoxNome.Text.Trim();
                ArtigoController controller = new ArtigoController();
                controller.AtualizarTipo(db, tipoSelecionado);
            }

            LimparCampos();
            AtualizarLista();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (tipoSelecionado == null)
            {
                MessageBox.Show("Selecione um tipo de artigo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show($"Eliminar o tipo \"{tipoSelecionado.Nome}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                ArtigoController controller = new ArtigoController();
                controller.EliminarTipo(tipoSelecionado.Id);
                LimparCampos();
                AtualizarLista();
            }
        }
    }
}
