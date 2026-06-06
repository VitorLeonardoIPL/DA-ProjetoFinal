using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDA.Model;
using System.Windows.Forms;
using ProjetoDA.Controller;

namespace ProjetoDA.View
{
    public partial class TipoArtigoControl : UserControl
    {
        public TipoArtigoControl()
        {
            InitializeComponent();
            AtualizarTiposArtigo();
        }

        private void buttonAddTipoArtigo(object sender, EventArgs e)
        {

<<<<<<< HEAD
            ArtigoController TipoartigoController = new ArtigoController();
            try
            {
                TipoartigoController.InserirTipo(textBoxNome.Text);
                AtualizarTiposArtigo();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
=======
            ArtigoController controller = new ArtigoController();
            try
            {
                controller.InserirTipo(textBoxNome.Text);
                AtualizarTiposArtigo();
                LimparCampos();
            }
>>>>>>> origin/main
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o tipo de artigo");
            }

        }
        private void AtualizarTiposArtigo()
        {
            listboxTiposArtigo.DataSource = null;

            using (ProjetoDAContext context = new ProjetoDAContext())
            {
                listboxTiposArtigo.DataSource = context.TiposArtigo.ToList();
            }
            
        }

<<<<<<< HEAD
=======
        private void listboxTiposArtigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoArtigo tipoArtigoSelecionado = listboxTiposArtigo.SelectedItem as TipoArtigo;
            if (tipoArtigoSelecionado != null)
            {
                textBoxNome.Text = tipoArtigoSelecionado.Nome;
            }
            else
            {
                textBoxNome.Text = "";
            }
        }

        private void buttonEditarTipo_Click(object sender, EventArgs e)
        {
            TipoArtigo tipoSelecionado = listboxTiposArtigo.SelectedItem as TipoArtigo;
            if (tipoSelecionado == null)
            {
                MessageBox.Show("Selecionar tipo de artigo");
                return;
            }
            ArtigoController controller = new ArtigoController();
            try
            {
                controller.EditarTipo(tipoSelecionado.Id, textBoxNome.Text);
                AtualizarTiposArtigo();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar o tipo de artigo");
            }
        }

>>>>>>> origin/main
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            TipoArtigo tipoArtigoSelecionado = listboxTiposArtigo.SelectedItem as TipoArtigo;
            if (tipoArtigoSelecionado == null)
            {
                MessageBox.Show("Selecionar tipo de artigo");
                return;
            }
            ArtigoController controller = new ArtigoController();
<<<<<<< HEAD
            controller.EliminarTipo(tipoArtigoSelecionado.Id);

            AtualizarTiposArtigo();
=======
            try
            {
                controller.EliminarTipo(tipoArtigoSelecionado.Id);
                AtualizarTiposArtigo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover o tipo de artigo");
            }
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
>>>>>>> origin/main
        }
    }
}
