using ProjetoDA.Controller;
using ProjetoDA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class CompraEditar : Form
    {
        private int compraId = 0;
        private List<ItemCompra> itens = new List<ItemCompra>();

        public CompraEditar()
        {
            InitializeComponent();
            listBoxItens.Format += ListBoxItens_Format;
            CarregarTiposArtigo();
        }

        private void ListBoxItens_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is ItemCompra item)
                e.Value = $"{item.Artigo?.Nome ?? "?"}  |  Qtd Prevista: {(item.ItemPrevisto?.QuantidadePrevista ?? 0)}";
        }

        public CompraEditar(int id) : this()
        {
            compraId = id;
            CarregarCompra();
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

        private void CarregarCompra()
        {
            CompraController controller = new CompraController();
            Compra compra = controller.Obter(compraId);
            if (compra == null)
            {
                MessageBox.Show("Compra nao encontrada");
                Close();
                return;
            }

            textBoxNome.Text = compra.Nome;
            textBoxDescricao.Text = compra.Descricao;
            Text = compra.Nome;

            if (compra.Fechada)
            {
                textBoxNome.ReadOnly = true;
                textBoxDescricao.ReadOnly = true;
                buttonGuardar.Enabled = false;
                buttonAdicionarItem.Enabled = false;
                buttonRemoverItem.Enabled = false;
                comboBoxTipoArtigo.Enabled = false;
                comboBoxArtigo.Enabled = false;
                numericQtdPrevista.Enabled = false;
            }

            itens = compra.ItensCompra.ToList();
            AtualizarListBox();
        }

        private void AtualizarListBox()
        {
            listBoxItens.DataSource = null;
            listBoxItens.DataSource = itens;
        }

        private void buttonAdicionarItem_Click(object sender, EventArgs e)
        {
            if (comboBoxArtigo.SelectedItem == null)
            {
                MessageBox.Show("Selecionar um artigo");
                return;
            }
            if (numericQtdPrevista.Value <= 0)
            {
                MessageBox.Show("Quantidade deve ser maior que zero");
                return;
            }

            Artigo artigo = comboBoxArtigo.SelectedItem as Artigo;
            decimal qtd = numericQtdPrevista.Value;

            CompraController controller = new CompraController();
            try
            {
                ItemCompra item = new ItemCompra
                {
                    ArtigoId = artigo.Id,
                    Artigo = artigo,
                    ItemPrevisto = new ItemPrevisto { QuantidadePrevista = qtd }
                };

                if (compraId > 0)
                {
                    int itemId = controller.AdicionarItemPrevisto(compraId, artigo.Id, qtd);
                    item.Id = itemId;
                }

                itens.Add(item);
                AtualizarListBox();

                numericQtdPrevista.Value = 0;
                comboBoxArtigo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar item");
            }
        }

        private void buttonRemoverItem_Click(object sender, EventArgs e)
        {
            ItemCompra selected = listBoxItens.SelectedItem as ItemCompra;
            if (selected == null)
            {
                MessageBox.Show("Selecionar um item da lista");
                return;
            }

            CompraController controller = new CompraController();
            try
            {
                if (selected.Id > 0)
                    controller.RemoverItem(selected.Id);

                itens.Remove(selected);
                AtualizarListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover item");
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                MessageBox.Show("Nome da compra nao pode estar vazio");
                return;
            }

            CompraController controller = new CompraController();
            try
            {
                if (compraId > 0)
                {
                    controller.Atualizar(compraId, textBoxNome.Text, textBoxDescricao.Text);

                    foreach (var item in itens)
                    {
                        if (item.Id > 0)
                            controller.AtualizarItemPrevisto(item.Id, item.ItemPrevisto?.QuantidadePrevista ?? 0);
                    }
                }
                else
                {
                    int novaId = controller.Inserir(textBoxNome.Text, textBoxDescricao.Text);
                    foreach (var item in itens)
                        controller.AdicionarItemPrevisto(novaId, item.ArtigoId, item.ItemPrevisto?.QuantidadePrevista ?? 0);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar compra");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
