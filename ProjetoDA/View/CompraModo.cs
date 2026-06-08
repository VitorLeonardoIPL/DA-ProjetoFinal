using ProjetoDA.Controller;
using ProjetoDA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class CompraModo : Form
    {
        private int compraId;
        private List<ItemCompra> itens;
        private CompraController compraController = new CompraController();

        public CompraModo(int id)
        {
            InitializeComponent();
            compraId = id;
            listBoxItens.Format += ListBoxItens_Format;
            CarregarTiposArtigo();
            CarregarCompra();
        }

        private void ListBoxItens_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is ItemCompra item)
            {
                if (item.ItemNaoPrevisto != null)
                {
                    e.Value = $"Item Não Previsto: {item.Artigo?.Nome ?? "?"}  |  Qtd: {item.QuantidadeAdquirida}  |  Preco: {item.PrecoUnitario:F2}€";
                }
                else
                {
                    decimal qtd = item.QuantidadeAdquirida > 0 ? item.QuantidadeAdquirida : (item.ItemPrevisto?.QuantidadePrevista ?? 0);
                    decimal preco = item.PrecoUnitario > 0 ? item.PrecoUnitario : (decimal)(item.Artigo?.Preco ?? 0);
                    string adquirido = item.QuantidadeAdquirida > 0 ? " (Adquirido)" : "";
                    e.Value = $"{item.Artigo?.Nome ?? "?"}{adquirido}  |  Qtd: {qtd}  |  Preco: {preco:F2}€";
                }
            }
        }

        private void CarregarTiposArtigo()
        {
            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                comboBoxTipoArtigo.DataSource = db.TiposArtigo.OrderBy(t => t.Nome).ToList();
                comboBoxTipoArtigo.DisplayMember = "Nome";
                comboBoxTipoArtigo.ValueMember = "Id";
                comboBoxTipoArtigo.SelectedIndex = -1;
            }
        }

        private void CarregarArtigos(int tipoArtigoId)
        {
            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                var artigos = db.Artigos.Where(a => a.TipoArtigoId == tipoArtigoId).OrderBy(a => a.Nome).ToList();
                comboBoxArtigo.DataSource = artigos;
                comboBoxArtigo.DisplayMember = "Nome";
                comboBoxArtigo.ValueMember = "Id";
                comboBoxArtigo.Enabled = artigos.Count > 0;
            }
        }

        private void comboBoxTipoArtigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoArtigo.SelectedItem is TipoArtigo tipo)
                CarregarArtigos(tipo.Id);
        }

        private void listBoxItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxItens.SelectedItem is ItemCompra item && item.ItemPrevisto != null)
            {
                if (item.QuantidadeAdquirida > 0)
                    numericQtdAquisicao.Value = item.QuantidadeAdquirida;
                else
                    numericQtdAquisicao.Value = Math.Max(1, item.ItemPrevisto.QuantidadePrevista);

                if (item.PrecoUnitario > 0)
                    numericPrecoAquisicao.Value = item.PrecoUnitario;
                else
                    numericPrecoAquisicao.Value = (decimal)(item.Artigo?.Preco ?? 0);
            }
        }

        private void CarregarCompra()
        {
            Compra compra = compraController.Obter(compraId);
            if (compra == null)
            {
                MessageBox.Show("Compra nao encontrada");
                Close();
                return;
            }

            labelNome.Text = compra.Nome;
            Text = "Modo Compra - " + compra.Nome;

            itens = compra.ItensCompra.ToList();
            AtualizarListBox();
            AtualizarTotal();
            AtualizarOrcamento();
        }

        private void AtualizarListBox()
        {
            listBoxItens.DataSource = null;
            listBoxItens.DataSource = itens;
        }

        private decimal ObterPreco(ItemCompra item)
        {
            if (item.ItemNaoPrevisto != null)
                return item.PrecoUnitario;
            if (item.PrecoUnitario > 0)
                return item.PrecoUnitario;
            return (decimal)(item.Artigo?.Preco ?? 0);
        }

        private decimal ObterQuantidade(ItemCompra item)
        {
            if (item.ItemNaoPrevisto != null)
                return item.QuantidadeAdquirida;
            if (item.QuantidadeAdquirida > 0)
                return item.QuantidadeAdquirida;
            return item.ItemPrevisto?.QuantidadePrevista ?? 0;
        }

        private void AtualizarTotal()
        {
            decimal total = itens.Sum(i => ObterPreco(i) * ObterQuantidade(i));
            labelTotal.Text = $"Total: {total:F2} €";
        }

        private void AtualizarOrcamento()
        {
            using (ProjetoDAContext db = new ProjetoDAContext())
            {
                DateTime hoje = DateTime.Now;
                var orcamento = db.Orcamentos
                    .Where(o => o.DataInicio <= hoje && o.DataFim >= hoje)
                    .FirstOrDefault();

                if (orcamento == null)
                {
                    labelOrcamento.Text = "Orcamento: N/D";
                    return;
                }

                decimal gastoMes = db.Compras
                    .Where(c => c.Fechada && c.DataFechada.HasValue
                        && c.DataFechada >= orcamento.DataInicio
                        && c.DataFechada <= orcamento.DataFim)
                    .SelectMany(c => c.ItensCompra)
                    .Sum(ic => (decimal?)(ic.QuantidadeAdquirida * ic.PrecoUnitario)) ?? 0;

                decimal atual = itens.Sum(i => ObterPreco(i) * ObterQuantidade(i));
                decimal disponivel = orcamento.Valor - gastoMes - atual;

                labelOrcamento.Text = $"Orcamento disponivel: {disponivel:F2} €";

                if (disponivel < 0)
                {
                    labelOrcamento.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show(
                        $"Atenção! O orçamento foi ultrapassado em {Math.Abs(disponivel):F2} €",
                        "Orçamento Excedido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    labelOrcamento.ForeColor = System.Drawing.SystemColors.ControlText;
                }
            }
        }

        private void buttonRegistarAquisicao_Click(object sender, EventArgs e)
        {
            ItemCompra selected = listBoxItens.SelectedItem as ItemCompra;
            if (selected == null || selected.ItemPrevisto == null)
            {
                MessageBox.Show("Selecionar um item previsto da lista");
                return;
            }
            if (numericQtdAquisicao.Value <= 0)
            {
                MessageBox.Show("Quantidade deve ser maior que zero");
                return;
            }
            if (numericPrecoAquisicao.Value <= 0)
            {
                MessageBox.Show("Preço deve ser maior que zero");
                return;
            }

            try
            {
                selected.QuantidadeAdquirida = numericQtdAquisicao.Value;
                selected.PrecoUnitario = numericPrecoAquisicao.Value;

                if (selected.Id > 0)
                    compraController.AtualizarItemCompra(selected.Id, selected.QuantidadeAdquirida, selected.PrecoUnitario);

                AtualizarListBox();
                AtualizarTotal();
                AtualizarOrcamento();

                numericQtdAquisicao.Value = 1;
                numericPrecoAquisicao.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registar aquisição");
            }
        }

        private void buttonAdicionarNaoPrevisto_Click(object sender, EventArgs e)
        {
            if (comboBoxArtigo.SelectedItem == null)
            {
                MessageBox.Show("Selecionar um artigo");
                return;
            }
            if (numericQuantidade.Value <= 0)
            {
                MessageBox.Show("Quantidade deve ser maior que zero");
                return;
            }

            Artigo artigo = comboBoxArtigo.SelectedItem as Artigo;

            try
            {
                ItemCompra novoItem = new ItemCompra
                {
                    CompraId = compraId,
                    ArtigoId = artigo.Id,
                    Artigo = artigo,
                    QuantidadeAdquirida = (int)numericQuantidade.Value,
                    PrecoUnitario = numericPrecoUnitario.Value,
                    ItemNaoPrevisto = new ItemNaoPrevisto
                    {
                        Observacoes = textBoxObservacoes.Text.Trim()
                    }
                };

                if (string.IsNullOrEmpty(novoItem.ItemNaoPrevisto.Observacoes))
                    novoItem.ItemNaoPrevisto.Observacoes = "Adicionado durante modo compra";

                itens.Add(novoItem);
                AtualizarListBox();

                numericQuantidade.Value = 0;
                numericPrecoUnitario.Value = 0;
                textBoxObservacoes.Clear();
                comboBoxArtigo.SelectedIndex = -1;

                AtualizarTotal();
                AtualizarOrcamento();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar item");
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in itens)
                {
                    decimal qtd = ObterQuantidade(item);
                    decimal preco = ObterPreco(item);

                    if (item.Id > 0)
                    {
                        compraController.AtualizarItemCompra(item.Id, qtd, preco);
                    }
                    else if (item.ItemNaoPrevisto != null)
                    {
                        compraController.AdicionarItemNaoPrevisto(
                            compraId, item.ArtigoId,
                            qtd, preco,
                            item.ItemNaoPrevisto.Observacoes);
                    }
                }

                using (ProjetoDAContext db = new ProjetoDAContext())
                {
                    DateTime hoje = DateTime.Now;
                    var orcamento = db.Orcamentos
                        .Where(o => o.DataInicio <= hoje && o.DataFim >= hoje)
                        .FirstOrDefault();

                    if (orcamento != null)
                    {
                        decimal gastoMes = db.Compras
                            .Where(c => c.Fechada && c.DataFechada.HasValue
                                && c.DataFechada >= orcamento.DataInicio
                                && c.DataFechada <= orcamento.DataFim)
                            .SelectMany(c => c.ItensCompra)
                            .Sum(ic => (decimal?)(ic.QuantidadeAdquirida * ic.PrecoUnitario)) ?? 0;

                        decimal totalCompra = compraController.TotalCompra(compraId);
                        decimal disponivel = orcamento.Valor - gastoMes;

                        if (totalCompra > disponivel)
                        {
                            var result = MessageBox.Show(
                                $"O total da compra ({totalCompra:F2} €) excede o orcamento disponivel ({disponivel:F2} €).\nDeseja fechar mesmo assim?",
                                "Orcamento excedido",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);
                            if (result == DialogResult.No)
                                return;
                        }
                    }
                }

                compraController.Fechar(compraId);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar compra");
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
