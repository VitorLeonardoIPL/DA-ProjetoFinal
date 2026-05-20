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
    public partial class NovoOrcamento : UserControl
    {
        public NovoOrcamento()
        {
            InitializeComponent();
        }

        private void buttonGuardarOrcamento_Click(object sender, EventArgs e)
        {
            string nome  = textBoxNomeOrcamento.Text.Trim();
            string valor = textBoxValor.Text.Trim();

            // Validar nome
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Preenche o Nome do Orçamento.", "Campo obrigatório",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que o valor é numérico
            if (!decimal.TryParse(valor, out decimal valorDecimal) || valorDecimal < 0)
            {
                MessageBox.Show("Insere um Valor válido (número positivo).", "Valor inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Extrair mês e ano da data de início (o modelo só guarda Mes e Ano)
            int mes = dateTimePickerDataInicio.Value.Month;
            int ano = dateTimePickerDataInicio.Value.Year;

            try
            {
                using (var db = new ProjetoDAContext())
                {
                    // Inserir na BD para incluir o campo Nome
                    // (OrcamentoController.Inserir não aceita Nome)
                    db.Orcamentos.Add(new ProjetoDA.Model.Orcamento
                    {
                        Nome               = nome,
                        Valor              = valorDecimal,
                        Mes                = mes,
                        Ano                = ano,
                        DataCriacao        = DateTime.Now,
                        UtilizadorCriadoId = SessaoAtual.UtilizadorLogado?.Id ?? 0
                    });
                    db.SaveChanges();
                }

                MessageBox.Show("Orçamento guardado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar o formulário após guardar
                LimparFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao guardar o orçamento:\n{ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botão "Voltar" — navega de volta para o ecrã de Orçamento
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            var mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
                mainForm.ShowOrcamento();
        }

        // Repõe todos os campos para o estado inicial
        private void LimparFormulario()
        {
            textBoxNomeOrcamento.Clear();
            textBoxValor.Clear();
            dateTimePickerDataInicio.Value = DateTime.Now;
            dateTimePickerDataFim.Value    = DateTime.Now;
        }
    }
}
