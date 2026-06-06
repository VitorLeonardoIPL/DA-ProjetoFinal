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
    public partial class OrcamentoControl : UserControl
    {
        public OrcamentoControl()
        {
            InitializeComponent();
            AtualizarOrcamento();
        }

        // Vai buscar todos os orçamentos à base de dados e preenche a listBox
       

        private void buttonNovoOrcamento_Click(object sender, EventArgs e)
        {

            OrcamentoController orcamentoController = new OrcamentoController();
            try
            {
                orcamentoController.Inserir(textBoxNomeOrcamento.Text, decimal.Parse(textBoxValor.Text), dateTimePickerDataInicio.Value, dateTimePickerDataFim.Value);
                AtualizarOrcamento();
                LimparCampos();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o orçamento");
            }

        }


        private void AtualizarOrcamento()
        {
            listBoxOrcamentos.DataSource = null;

            using (ProjetoDAContext context = new ProjetoDAContext())
            {
                listBoxOrcamentos.DataSource = context.Orcamentos.ToList();
            }

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            Orcamento orcamentoSelecionado = listBoxOrcamentos.SelectedItem as Orcamento;
            try
            {
                OrcamentoController orcamentoController = new OrcamentoController();
                orcamentoController.Eliminar(orcamentoSelecionado.Id);

                AtualizarOrcamento();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao Eliminar o orçamento");
            }

            if (orcamentoSelecionado == null)
            {
                MessageBox.Show("Selecionar orçamento");
                return;
            }
           

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

            Orcamento orcamentoSelecionado = listBoxOrcamentos.SelectedItem as Orcamento;
            try
            {
                if (orcamentoSelecionado == null)
                {
                    MessageBox.Show("Selecionar orçamento");
                    return;
                }
                OrcamentoController orcamentoController = new OrcamentoController();
                orcamentoController.Editar(orcamentoSelecionado.Id, textBoxNomeOrcamento.Text, dateTimePickerDataInicio.Value, dateTimePickerDataFim.Value, decimal.Parse(textBoxValor.Text));

                LimparCampos();
                AtualizarOrcamento();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar o orçamento");
            }
            if (orcamentoSelecionado == null)
            {
                MessageBox.Show("Selecionar orçamento");
                return;
            }



        }

        private void LimparCampos()
        {
            textBoxNomeOrcamento.Clear(); 
            textBoxValor.Clear();
            dateTimePickerDataInicio.Value = DateTime.Now;
            dateTimePickerDataFim.Value = DateTime.Now;
        }



    }
}
