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
            ArtigoController TipoartigoController = new ArtigoController();
            try
            {
                int tipoArtigoId = (int)comboBox1.SelectedValue;
                TipoartigoController.InserirArtigo(textBoxNomeArtigo.Text, int.Parse(textBoxPreco.Text), tipoArtigoId);
                AtualizarArtigo();
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
    }
}
