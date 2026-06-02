using ProjetoDA.Controller;
using ProjetoDA.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class ArtigoControl : UserControl
    {
        private ProjetoDAContext db = new ProjetoDAContext();
        private Artigo artigoSelecionado;

        public ArtigoControl()
        {
            InitializeComponent();
            CarregarTipos();
            CarregarArtigos();
        }

        private void CarregarTipos()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = ArtigoController.ListarTipos(db);
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "Id";
        }

        private void CarregarArtigos()
        {
            int? tipoId = null;
            if (comboBox1.SelectedIndex >= 0)
            {
                var tipo = comboBox1.SelectedItem as TipoArtigo;
                if (tipo != null)
                    tipoId = tipo.Id;
            }

            listBoxArtigo.DataSource = null;
            listBoxArtigo.DataSource = ArtigoController.ListarArtigos(db, tipoId);
            listBoxArtigo.DisplayMember = "Nome";
            listBoxArtigo.ValueMember = "Id";
        }

        private void LimparCampos()
        {
            textBoxNomeArtigo.Text = "";
            textBoxPreco.Text = "";
            comboBox1.SelectedIndex = -1;
            artigoSelecionado = null;
            listBoxArtigo.ClearSelected();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarArtigos();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            CarregarTipos();
        }

        private void listBoxArtigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            artigoSelecionado = listBoxArtigo.SelectedItem as Artigo;
            if (artigoSelecionado != null)
            {
                textBoxNomeArtigo.Text = artigoSelecionado.Nome;
                textBoxPreco.Text = artigoSelecionado.Preco.ToString("F2");

                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    var tipo = comboBox1.Items[i] as TipoArtigo;
                    if (tipo != null && tipo.Id == artigoSelecionado.TipoArtigoId)
                    {
                        comboBox1.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomeArtigo.Text))
            {
                MessageBox.Show("O nome é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(textBoxPreco.Text, out double preco) || preco < 0)
            {
                MessageBox.Show("Insira um preço válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tipoSelecionado = comboBox1.SelectedItem as TipoArtigo;
            if (tipoSelecionado == null)
            {
                MessageBox.Show("Selecione um tipo de artigo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (artigoSelecionado == null)
            {
                ArtigoController controller = new ArtigoController();
                controller.InserirArtigo(textBoxNomeArtigo.Text.Trim(), preco, tipoSelecionado.Id);
            }
            else
            {
                artigoSelecionado.Nome = textBoxNomeArtigo.Text.Trim();
                artigoSelecionado.Preco = preco;
                artigoSelecionado.TipoArtigoId = tipoSelecionado.Id;
                ArtigoController controller = new ArtigoController();
                controller.AtualizarArtigo(db, artigoSelecionado);
            }

            LimparCampos();
            CarregarArtigos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (artigoSelecionado == null)
            {
                MessageBox.Show("Selecione um artigo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show($"Eliminar o artigo \"{artigoSelecionado.Nome}\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                ArtigoController controller = new ArtigoController();
                controller.EliminarArtigo(db, artigoSelecionado.Id);
                LimparCampos();
                CarregarArtigos();
            }
        }
    }
}
