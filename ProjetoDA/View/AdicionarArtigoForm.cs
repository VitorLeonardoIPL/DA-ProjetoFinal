using ProjetoDA.Controller;
using ProjetoDA.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class AdicionarArtigoForm : Form
    {
        // Propriedades públicas para o form chamador (NovaCompra) ler o resultado
        public ProjetoDA.Model.Artigo ArtigoSelecionado { get; private set; }
        public int Quantidade { get; private set; }

        public AdicionarArtigoForm()
        {
            InitializeComponent();
        }

        // Ao abrir o form, carrega os artigos da base de dados no comboBox
        private void AdicionarArtigoForm_Load(object sender, EventArgs e)
        {
            using (var db = new ProjetoDAContext())
            {
                // Busca todos os artigos ordenados por nome
                var artigos = ArtigoController.ListarArtigos(db).ToList();

                comboBoxArtigo.DataSource = artigos;
                comboBoxArtigo.DisplayMember = "Nome"; // texto visível no comboBox
                comboBoxArtigo.ValueMember = "Id";     // valor interno (Id do artigo)
            }
        }

        // Botão "Adicionar" — valida os campos e fecha o form com OK
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            // Validar que foi selecionado um artigo
            if (comboBoxArtigo.SelectedItem == null)
            {
                MessageBox.Show("Seleciona um artigo.", "Campo obrigatório",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que a quantidade é um número inteiro positivo
            if (!int.TryParse(textBoxQuantidade.Text.Trim(), out int qtd) || qtd <= 0)
            {
                MessageBox.Show("Insere uma quantidade válida (número inteiro maior que zero).",
                    "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar os valores para o form chamador ler
            ArtigoSelecionado = (ProjetoDA.Model.Artigo)comboBoxArtigo.SelectedItem;
            Quantidade = qtd;

            // Fechar com DialogResult.OK — sinal de sucesso para NovaCompra
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Botão "Cancelar" — fecha sem fazer nada
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
