using System;
using System.Collections.Generic;
using System.Windows.Forms;
using iShopping.Controllers;
using iShopping.Models;

namespace iShopping.Views
{
    /// <summary>
    /// Formulário de Gestão de Tipos de Artigo.
    /// Permite:
    /// - Listar todos os tipos de artigo
    /// - Criar novos tipos
    /// - Editar tipos existentes
    /// - Eliminar tipos (só se não tiverem artigos associados)
    /// </summary>
    public partial class ArticleTypeForm : Form
    {
        private ArticleTypeController _typeController;

        public ArticleTypeForm()
        {
            InitializeComponent();
            _typeController = new ArticleTypeController();
            LoadTypes(); // Carregar lista ao abrir
        }

        /// <summary>
        /// Carrega todos os tipos de artigo para a DataGridView.
        /// </summary>
        private void LoadTypes()
        {
            List<ArticleType> types = _typeController.GetAllTypes();
            dgvTypes.Rows.Clear();

            foreach (ArticleType type in types)
            {
                int rowIndex = dgvTypes.Rows.Add();
                dgvTypes.Rows[rowIndex].Cells["colId"].Value = type.Id;
                dgvTypes.Rows[rowIndex].Cells["colName"].Value = type.Name;
            }
        }

        /// <summary>
        /// Evento ao clicar no botão "Novo".
        /// </summary>
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ArticleTypeEditForm form = new ArticleTypeEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadTypes();
            }
        }

        /// <summary>
        /// Evento ao clicar no botão "Editar".
        /// </summary>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTypes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um tipo para editar.",
                    "Nenhuma seleção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int typeId = Convert.ToInt32(dgvTypes.CurrentRow.Cells["colId"].Value);
            ArticleType type = _typeController.GetTypeById(typeId);

            ArticleTypeEditForm form = new ArticleTypeEditForm(type);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadTypes();
            }
        }

        /// <summary>
        /// Evento ao clicar no botão "Eliminar".
        /// </summary>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTypes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um tipo para eliminar.",
                    "Nenhuma seleção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int typeId = Convert.ToInt32(dgvTypes.CurrentRow.Cells["colId"].Value);
            string typeName = dgvTypes.CurrentRow.Cells["colName"].Value.ToString();

            DialogResult result = MessageBox.Show(
                "Tem a certeza que deseja eliminar o tipo '" + typeName + "'?\n\n" +
                "Nota: Só é possível eliminar tipos sem artigos associados.",
                "Confirmar eliminação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool success = _typeController.DeleteType(typeId);

                if (success)
                {
                    MessageBox.Show("Tipo eliminado com sucesso.",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadTypes();
                }
                else
                {
                    MessageBox.Show("Não é possível eliminar este tipo porque tem artigos associados.\n" +
                        "Elimine primeiro os artigos deste tipo.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Duplo clique numa linha = editar.
        /// </summary>
        private void DgvTypes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEdit_Click(sender, e);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
