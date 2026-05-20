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
    public partial class NovaCompra : UserControl
    {
        // Lista interna para guardar os dados reais de cada item adicionado
        // (em paralelo com as linhas de texto da listBoxItems)
        private List<ItemParaGravar> _itens = new List<ItemParaGravar>();

        // Classe auxiliar — guarda os dados necessários para gravar na base de dados
        private class ItemParaGravar
        {
            public int ArtigoId { get; set; }
            public string ArtigoNome { get; set; }
            public int Quantidade { get; set; }
            public double Preco { get; set; }
        }

        public NovaCompra()
        {
            InitializeComponent();
        }

        // Botão "Adicionar Item" — abre o form de seleção e adiciona à lista
        private void buttonAdicionarItem_Click(object sender, EventArgs e)
        {
            using (var form = new AdicionarArtigoForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var artigo = form.ArtigoSelecionado;
                    int quantidade = form.Quantidade;

                    // Guardar os dados reais na lista interna para usar ao gravar
                    _itens.Add(new ItemParaGravar
                    {
                        ArtigoId  = artigo.Id,
                        ArtigoNome = artigo.Nome,
                        Quantidade = quantidade,
                        Preco      = artigo.Preco
                    });

                    // Mostrar linha formatada na listBoxItems (só para visualização)
                    string linha = $"Artigo: {artigo.Nome} | Qtd: {quantidade} | Preço Unit.: {artigo.Preco:F2} €";
                    listBoxItems.Items.Add(linha);

                    // Recalcular e mostrar o total acumulado
                    AtualizarTotal();
                }
            }
        }

        // Calcula a soma de (Quantidade × Preço) de todos os itens e mostra no label
        private void AtualizarTotal()
        {
            double total = 0;
            foreach (var item in _itens)
                total += item.Quantidade * item.Preco;

            labelValorTotal.Text = $"{total:F2} €";
        }

        // valida, grava a compra e os itens na base de dados
        private void buttonGravarCompra_Click(object sender, EventArgs e)
        {
            string nome = textBoxNomeCompra.Text.Trim();

            // Validar nome da compra
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Preenche o Nome da Compra.", "Campo obrigatório",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que existe pelo menos um item adicionado
            if (_itens.Count == 0)
            {
                MessageBox.Show("Adiciona pelo menos um artigo antes de gravar.", "Sem itens",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new ProjetoDAContext())
                {
                    // Calcular o total: soma de (Quantidade × Preço) de todos os itens
                    double totalCompra = 0;
                    foreach (var item in _itens)
                        totalCompra += item.Quantidade * item.Preco;

                    // Criar a compra com a data escolhida no dateTimePickerCompra
                    var compra = new Compra
                    {
                        Nome               = nome,
                        Fechada            = false,
                        DataCriacao        = dateTimePickerCompra.Value,
                        total              = totalCompra,
                        UtilizadorCriadoId = SessaoAtual.UtilizadorLogado?.Id ?? 0
                    };

                    db.Compras.Add(compra);
                    db.SaveChanges(); // Necessário para obter o Id gerado antes de inserir os itens

                    // Gravar cada item como ItemPrevisto ligado a esta compra
                    foreach (var item in _itens)
                    {
                        CompraController.AdicionarItemPrevisto(
                            db,
                            compra.Id,
                            item.ArtigoId,
                            (decimal)item.Quantidade
                        );
                    }
                }

                MessageBox.Show("Compra gravada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar o formulário para uma nova compra
                LimparFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gravar a compra:\n{ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpa todos os campos e a lista de itens após gravar com sucesso
        private void LimparFormulario()
        {
            textBoxNomeCompra.Clear();
            dateTimePickerCompra.Value = DateTime.Now;
            listBoxItems.Items.Clear();
            _itens.Clear();
            labelValorTotal.Text = "0,00 €";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
