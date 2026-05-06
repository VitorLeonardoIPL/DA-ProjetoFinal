namespace iShopping.Views
{
    partial class StatisticsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMonthly = new System.Windows.Forms.TabPage();
            this.dgvMonthly = new System.Windows.Forms.DataGridView();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.lblMonthlyTitle = new System.Windows.Forms.Label();
            this.tabAnalysis = new System.Windows.Forms.TabPage();
            this.lblWeekInfo = new System.Windows.Forms.Label();
            this.dgvSuggestions = new System.Windows.Forms.DataGridView();
            this.groupBoxPercentages = new System.Windows.Forms.GroupBox();
            this.lblPlannedCount = new System.Windows.Forms.Label();
            this.lblUnplannedCount = new System.Windows.Forms.Label();
            this.lblPlannedPct = new System.Windows.Forms.Label();
            this.lblUnplannedPct = new System.Windows.Forms.Label();
            this.groupBoxBudgetSuggestion = new System.Windows.Forms.GroupBox();
            this.lblBudgetSuggestion = new System.Windows.Forms.Label();
            this.lblBudgetSuggestionNote = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();

            // Colunas para Mensal
            this.colMonthYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBudget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // Colunas para Sugestões
            this.colArticleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.tabControl1.SuspendLayout();
            this.tabMonthly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthly)).BeginInit();
            this.tabAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuggestions)).BeginInit();
            this.groupBoxPercentages.SuspendLayout();
            this.groupBoxBudgetSuggestion.SuspendLayout();
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "iShopping - Estatísticas";

            // TabControl com dois separadores
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Size = new System.Drawing.Size(680, 430);

            // ================================================================
            // SEPARADOR 1: Estatísticas Mensais
            // ================================================================
            this.tabMonthly.Text = "Estatísticas Mensais";

            this.lblMonthlyTitle.AutoSize = true;
            this.lblMonthlyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyTitle.Location = new System.Drawing.Point(10, 10);
            this.lblMonthlyTitle.Text = "Orçamento vs Gastos por Mês";

            this.dgvMonthly.AllowUserToAddRows = false;
            this.dgvMonthly.AllowUserToDeleteRows = false;
            this.dgvMonthly.ReadOnly = true;
            this.dgvMonthly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.colMonthYear.HeaderText = "Mês / Ano";
            this.colMonthYear.Name = "colMonthYear";
            this.colMonthYear.Width = 120;

            this.colBudget.HeaderText = "Orçamento (€)";
            this.colBudget.Name = "colBudget";
            this.colBudget.Width = 120;

            this.colSpent.HeaderText = "Total Gasto (€)";
            this.colSpent.Name = "colSpent";
            this.colSpent.Width = 120;

            this.colDifference.HeaderText = "Diferença (€)";
            this.colDifference.Name = "colDifference";
            this.colDifference.Width = 120;

            this.dgvMonthly.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMonthYear, this.colBudget, this.colSpent, this.colDifference
            });
            this.dgvMonthly.Location = new System.Drawing.Point(10, 40);
            this.dgvMonthly.Size = new System.Drawing.Size(650, 200);

            this.btnExportCsv.Text = "Exportar para CSV";
            this.btnExportCsv.Location = new System.Drawing.Point(10, 260);
            this.btnExportCsv.Size = new System.Drawing.Size(150, 35);
            this.btnExportCsv.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnExportCsv.ForeColor = System.Drawing.Color.White;
            this.btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCsv.Click += new System.EventHandler(this.BtnExportCsv_Click);

            this.tabMonthly.Controls.Add(this.lblMonthlyTitle);
            this.tabMonthly.Controls.Add(this.dgvMonthly);
            this.tabMonthly.Controls.Add(this.btnExportCsv);

            // ================================================================
            // SEPARADOR 2: Análise de Compras e Sugestões
            // ================================================================
            this.tabAnalysis.Text = "Análise e Sugestões";

            // GroupBox Percentagens
            this.groupBoxPercentages.Text = "Análise de Artigos (Compras Fechadas)";
            this.groupBoxPercentages.Location = new System.Drawing.Point(10, 10);
            this.groupBoxPercentages.Size = new System.Drawing.Size(650, 100);

            this.lblPlannedCount.AutoSize = true;
            this.lblPlannedCount.Location = new System.Drawing.Point(15, 25);
            this.lblPlannedCount.Text = "Previstos: 0 artigos";

            this.lblUnplannedCount.AutoSize = true;
            this.lblUnplannedCount.Location = new System.Drawing.Point(15, 45);
            this.lblUnplannedCount.Text = "Não Previstos: 0 artigos";

            this.lblPlannedPct.AutoSize = true;
            this.lblPlannedPct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPlannedPct.ForeColor = System.Drawing.Color.Green;
            this.lblPlannedPct.Location = new System.Drawing.Point(250, 25);
            this.lblPlannedPct.Text = "Percentagem Previstos: 0%";

            this.lblUnplannedPct.AutoSize = true;
            this.lblUnplannedPct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblUnplannedPct.ForeColor = System.Drawing.Color.Red;
            this.lblUnplannedPct.Location = new System.Drawing.Point(250, 45);
            this.lblUnplannedPct.Text = "Percentagem Não Previstos: 0%";

            this.groupBoxPercentages.Controls.Add(this.lblPlannedCount);
            this.groupBoxPercentages.Controls.Add(this.lblUnplannedCount);
            this.groupBoxPercentages.Controls.Add(this.lblPlannedPct);
            this.groupBoxPercentages.Controls.Add(this.lblUnplannedPct);

            // GroupBox Sugestão de Orçamento
            this.groupBoxBudgetSuggestion.Text = "Sugestão de Orçamento";
            this.groupBoxBudgetSuggestion.Location = new System.Drawing.Point(10, 120);
            this.groupBoxBudgetSuggestion.Size = new System.Drawing.Size(650, 70);

            this.lblBudgetSuggestion.AutoSize = true;
            this.lblBudgetSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblBudgetSuggestion.Location = new System.Drawing.Point(15, 20);
            this.lblBudgetSuggestion.Text = "Sugestão: 0.00 €";

            this.lblBudgetSuggestionNote.AutoSize = true;
            this.lblBudgetSuggestionNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.lblBudgetSuggestionNote.ForeColor = System.Drawing.Color.Gray;
            this.lblBudgetSuggestionNote.Location = new System.Drawing.Point(15, 45);
            this.lblBudgetSuggestionNote.Text = "";

            this.groupBoxBudgetSuggestion.Controls.Add(this.lblBudgetSuggestion);
            this.groupBoxBudgetSuggestion.Controls.Add(this.lblBudgetSuggestionNote);

            // Label Sugestão de Compras
            this.lblWeekInfo.AutoSize = true;
            this.lblWeekInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblWeekInfo.Location = new System.Drawing.Point(10, 200);
            this.lblWeekInfo.Text = "Sugestão de Lista de Compras:";

            // DataGridView de Sugestões
            this.dgvSuggestions.AllowUserToAddRows = false;
            this.dgvSuggestions.AllowUserToDeleteRows = false;
            this.dgvSuggestions.ReadOnly = true;
            this.dgvSuggestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.colArticleName.HeaderText = "Artigo Sugerido";
            this.colArticleName.Name = "colArticleName";
            this.colArticleName.Width = 400;

            this.colFrequency.HeaderText = "Frequência";
            this.colFrequency.Name = "colFrequency";
            this.colFrequency.Width = 150;

            this.dgvSuggestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colArticleName, this.colFrequency
            });
            this.dgvSuggestions.Location = new System.Drawing.Point(10, 230);
            this.dgvSuggestions.Size = new System.Drawing.Size(650, 150);

            this.tabAnalysis.Controls.Add(this.groupBoxPercentages);
            this.tabAnalysis.Controls.Add(this.groupBoxBudgetSuggestion);
            this.tabAnalysis.Controls.Add(this.lblWeekInfo);
            this.tabAnalysis.Controls.Add(this.dgvSuggestions);

            // Adicionar separadores ao TabControl
            this.tabControl1.Controls.Add(this.tabMonthly);
            this.tabControl1.Controls.Add(this.tabAnalysis);

            // Botão Fechar
            this.btnClose.Text = "Fechar";
            this.btnClose.Location = new System.Drawing.Point(570, 450);
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);

            this.tabControl1.ResumeLayout(false);
            this.tabMonthly.ResumeLayout(false);
            this.tabMonthly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthly)).EndInit();
            this.tabAnalysis.ResumeLayout(false);
            this.tabAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuggestions)).EndInit();
            this.groupBoxPercentages.ResumeLayout(false);
            this.groupBoxPercentages.PerformLayout();
            this.groupBoxBudgetSuggestion.ResumeLayout(false);
            this.groupBoxBudgetSuggestion.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMonthly;
        private System.Windows.Forms.DataGridView dgvMonthly;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Label lblMonthlyTitle;
        private System.Windows.Forms.TabPage tabAnalysis;
        private System.Windows.Forms.GroupBox groupBoxPercentages;
        private System.Windows.Forms.Label lblPlannedCount;
        private System.Windows.Forms.Label lblUnplannedCount;
        private System.Windows.Forms.Label lblPlannedPct;
        private System.Windows.Forms.Label lblUnplannedPct;
        private System.Windows.Forms.GroupBox groupBoxBudgetSuggestion;
        private System.Windows.Forms.Label lblBudgetSuggestion;
        private System.Windows.Forms.Label lblBudgetSuggestionNote;
        private System.Windows.Forms.Label lblWeekInfo;
        private System.Windows.Forms.DataGridView dgvSuggestions;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMonthYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBudget;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDifference;

        private System.Windows.Forms.DataGridViewTextBoxColumn colArticleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrequency;
    }
}
