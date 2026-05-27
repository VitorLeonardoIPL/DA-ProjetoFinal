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

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            TipoArtigo tipoArtigoSelecionado = listboxTiposArtigo.SelectedItem as TipoArtigo;
            if (tipoArtigoSelecionado == null)
            {
                MessageBox.Show("Selecionar tipo de artigo");
                return;
            }
            ArtigoController controller = new ArtigoController();
            controller.EliminarTipo(tipoArtigoSelecionado.Id);

            AtualizarTiposArtigo();
        }
    }
}
