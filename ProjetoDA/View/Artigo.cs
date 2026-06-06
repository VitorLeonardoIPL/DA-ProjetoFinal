using ProjetoDA.Controller;
using ProjetoDA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class ArtigoControl : UserControl
    {
        public ArtigoControl()
        {
            InitializeComponent();
            AtualizarTiposArtigo();
            AtualizarArtigo();
        }

        private void AtualizarTiposArtigo()
        {
            comboBox1.DataSource = null;

            using (ProjetoDAContext context = new ProjetoDAContext())
            {
                comboBox1.DataSource = context.TiposArtigo.ToList();
                comboBox1.DisplayMember = "Nome";
                comboBox1.ValueMember = "Id";
            }

        }


        private void AtualizarArtigo()
        {
                
            listBoxArtigo.DataSource = null;

            using (ProjetoDAContext context = new ProjetoDAContext())
            {
                listBoxArtigo.DataSource = context.Artigos.ToList();
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            AtualizarTiposArtigo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArtigoController controller = new ArtigoController();
            try
            {
                int tipoArtigoId = (int)comboBox1.SelectedValue;
                controller.InserirArtigo(textBoxNomeArtigo.Text, double.Parse(textBoxPreco.Text), tipoArtigoId);
                AtualizarArtigo();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o artigo");
            }
        }

        private void buttonEditarArtigo_Click(object sender, EventArgs e)
        {
            Artigo artigoSelecionado = listBoxArtigo.SelectedItem as Artigo;
            if (artigoSelecionado == null)
            {
                MessageBox.Show("Selecionar artigo");
                return;
            }
            ArtigoController controller = new ArtigoController();
            try
            {
                int tipoArtigoId = (int)comboBox1.SelectedValue;
                controller.EditarArtigo(artigoSelecionado.Id, textBoxNomeArtigo.Text, double.Parse(textBoxPreco.Text), tipoArtigoId);
                AtualizarArtigo();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar o artigo");
            }
        }

        private void buttonRemoverArtigo_Click(object sender, EventArgs e)
        {
            Artigo artigoSelecionado = listBoxArtigo.SelectedItem as Artigo;
            if (artigoSelecionado == null)
            {
                MessageBox.Show("Selecionar artigo");
                return;
            }
            ArtigoController controller = new ArtigoController();
            try
            {
                controller.EliminarArtigo(artigoSelecionado.Id);
                AtualizarArtigo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover o artigo");
            }
        }

        private void LimparCampos()
        {
            textBoxNomeArtigo.Clear();
            textBoxPreco.Clear();
        }
    }
}
