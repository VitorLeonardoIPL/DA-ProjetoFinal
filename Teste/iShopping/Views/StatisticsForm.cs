using System;
using System.Collections.Generic;
using System.Windows.Forms;
using iShopping.Controllers;
using iShopping.Models;
using iShopping.Utils;

namespace iShopping.Views
{
    /// <summary>
    /// Formulário de Estatísticas.
    /// Tem dois separadores (Tabs):
    /// 1. Estatísticas Mensais + Exportação CSV
    /// 2. Análise de Compras + Sugestões
    /// </summary>
    public partial class StatisticsForm : Form
    {
        private StatisticsController _statsController;
        private ShoppingController _shoppingController;
        private CsvExporter _csvExporter;
        private int _currentUserId;

        public StatisticsForm()
        {
            InitializeComponent();
            _statsController = new StatisticsController();
            _shoppingController = new ShoppingController();
            _csvExporter = new CsvExporter();
            _currentUserId = SessionManager.GetUserId();

            LoadMonthlyStats();
            LoadArticlePercentages();
            LoadSuggestions();
        }

        // ================================================================
        // SEPARADOR 1: Estatísticas Mensais
        // ================================================================

        /// <summary>
        /// Carrega as estatísticas mensais na DataGridView.
        /// Mostra: Mês/Ano, Orçamento, Total Gasto, Diferença.
        /// </summary>
        private void LoadMonthlyStats()
        {
            List<MonthlyStats> stats = _statsController.GetMonthlyStats(_currentUserId);
            dgvMonthly.Rows.Clear();

            foreach (MonthlyStats stat in stats)
            {
                int rowIndex = dgvMonthly.Rows.Add();
                dgvMonthly.Rows[rowIndex].Cells["colMonthYear"].Value = stat.MonthName + " / " + stat.Year;
                dgvMonthly.Rows[rowIndex].Cells["colBudget"].Value = stat.BudgetAmount.ToString("C2");
                dgvMonthly.Rows[rowIndex].Cells["colSpent"].Value = stat.TotalSpent.ToString("C2");
                dgvMonthly.Rows[rowIndex].Cells["colDifference"].Value = stat.Difference.ToString("C2");

                // Pintar diferença: verde = positivo, vermelho = negativo
                if (stat.Difference >= 0)
                {
                    dgvMonthly.Rows[rowIndex].Cells["colDifference"].Style.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    dgvMonthly.Rows[rowIndex].Cells["colDifference"].Style.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        /// <summary>
        /// Exporta as compras fechadas para CSV.
        /// </summary>
        private void BtnExportCsv_Click(object sender, EventArgs e)
        {
            // Abrir diálogo para escolher onde guardar
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Ficheiro CSV (*.csv)|*.csv";
                saveDialog.Title = "Exportar Compras para CSV";
                saveDialog.FileName = "iShopping_Compras_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Obter todas as compras fechadas
                        List<ShoppingList> closedLists = _shoppingController.GetClosedShoppingLists(_currentUserId);

                        if (closedLists.Count == 0)
                        {
                            MessageBox.Show("Não existem compras fechadas para exportar.",
                                "Sem dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // Exportar
                        string filePath = _csvExporter.ExportToCsv(closedLists, saveDialog.FileName);

                        MessageBox.Show("Compras exportadas com sucesso para:\n" + filePath,
                            "Exportação concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao exportar: " + ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ================================================================
        // SEPARADOR 2: Análise de Compras e Sugestões
        // ================================================================

        /// <summary>
        /// Carrega as percentagens de artigos previstos vs não previstos.
        /// </summary>
        private void LoadArticlePercentages()
        {
            ArticlePercentageStats stats = _statsController.GetArticlePercentages(_currentUserId);

            lblPlannedCount.Text = "Previstos: " + stats.PlannedCount + " artigos";
            lblUnplannedCount.Text = "Não Previstos: " + stats.UnplannedCount + " artigos";
            lblPlannedPct.Text = "Percentagem Previstos: " + stats.PlannedPercentage.ToString("F1") + "%";
            lblUnplannedPct.Text = "Percentagem Não Previstos: " + stats.UnplannedPercentage.ToString("F1") + "%";
        }

        /// <summary>
        /// Carrega as sugestões de orçamento e lista de compras.
        /// </summary>
        private void LoadSuggestions()
        {
            // Sugestão de orçamento
            decimal suggestedBudget = _statsController.SuggestNextBudget(_currentUserId);

            if (suggestedBudget > 0)
            {
                lblBudgetSuggestion.Text = "Sugestão de Orçamento para o Próximo Mês: " + suggestedBudget.ToString("C2");
                lblBudgetSuggestionNote.Text = "(Baseada na média dos últimos 3 meses + 10% de margem)";
            }
            else
            {
                lblBudgetSuggestion.Text = "Sem dados suficientes para sugerir um orçamento.";
                lblBudgetSuggestionNote.Text = "";
            }

            // Sugestão de lista de compras (semana atual)
            int currentWeek = GetWeekOfMonth(DateTime.Now);
            List<ArticleSuggestion> suggestions = _statsController.SuggestShoppingList(_currentUserId, currentWeek);

            dgvSuggestions.Rows.Clear();
            foreach (ArticleSuggestion suggestion in suggestions)
            {
                int rowIndex = dgvSuggestions.Rows.Add();
                dgvSuggestions.Rows[rowIndex].Cells["colArticleName"].Value = suggestion.ArticleName;
                dgvSuggestions.Rows[rowIndex].Cells["colFrequency"].Value = suggestion.Frequency + " vezes";
            }

            lblWeekInfo.Text = "Sugestão de Compras para a Semana " + currentWeek + " do mês (baseada no histórico):";
        }

        /// <summary>
        /// Calcula a semana do mês para uma data.
        /// Semana 1 = dias 1-7, Semana 2 = dias 8-14, etc.
        /// </summary>
        private int GetWeekOfMonth(DateTime date)
        {
            int day = date.Day;
            if (day <= 7) return 1;
            if (day <= 14) return 2;
            if (day <= 21) return 3;
            return 4;
        }

        /// <summary>
        /// Evento ao clicar no botão "Fechar".
        /// </summary>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
