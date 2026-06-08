namespace ProjetoDA.View
{
    partial class Estatistica
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlEstatistica = new System.Windows.Forms.TabControl();
            this.tabPageMensal = new System.Windows.Forms.TabPage();
            this.buttonRefreshMensal = new System.Windows.Forms.Button();
            this.panelMensal = new System.Windows.Forms.Panel();
            this.labelMesHeader = new System.Windows.Forms.Label();
            this.labelOrcamentoHeader = new System.Windows.Forms.Label();
            this.labelTotalHeader = new System.Windows.Forms.Label();
            this.labelDiferencaHeader = new System.Windows.Forms.Label();
            this.listBoxMensal = new System.Windows.Forms.ListBox();
            this.tabPageSugestoes = new System.Windows.Forms.TabPage();
            this.groupBoxSugestaoOrcamento = new System.Windows.Forms.GroupBox();
            this.textBoxSugestaoOrcamento = new System.Windows.Forms.TextBox();
            this.groupBoxSugestoes = new System.Windows.Forms.GroupBox();
            this.listBoxSugestoes = new System.Windows.Forms.ListBox();
            this.groupBoxAnalise = new System.Windows.Forms.GroupBox();
            this.listBoxAnalise = new System.Windows.Forms.ListBox();
            this.buttonRefreshSugestoes = new System.Windows.Forms.Button();
            this.buttonExportarCSV = new System.Windows.Forms.Button();
            this.tabControlEstatistica.SuspendLayout();
            this.tabPageMensal.SuspendLayout();
            this.panelMensal.SuspendLayout();
            this.tabPageSugestoes.SuspendLayout();
            this.groupBoxSugestaoOrcamento.SuspendLayout();
            this.groupBoxSugestoes.SuspendLayout();
            this.groupBoxAnalise.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estatísticas";
            // 
            // tabControlEstatistica
            // 
            this.tabControlEstatistica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlEstatistica.Controls.Add(this.tabPageMensal);
            this.tabControlEstatistica.Controls.Add(this.tabPageSugestoes);
            this.tabControlEstatistica.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tabControlEstatistica.Location = new System.Drawing.Point(30, 90);
            this.tabControlEstatistica.Name = "tabControlEstatistica";
            this.tabControlEstatistica.SelectedIndex = 0;
            this.tabControlEstatistica.Size = new System.Drawing.Size(1660, 630);
            this.tabControlEstatistica.TabIndex = 1;
            this.tabControlEstatistica.SelectedIndexChanged += new System.EventHandler(this.tabControlEstatistica_SelectedIndexChanged);
            // 
            // tabPageMensal
            // 
            this.tabPageMensal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.tabPageMensal.Controls.Add(this.buttonRefreshMensal);
            this.tabPageMensal.Controls.Add(this.panelMensal);
            this.tabPageMensal.Controls.Add(this.listBoxMensal);
            this.tabPageMensal.Location = new System.Drawing.Point(4, 32);
            this.tabPageMensal.Name = "tabPageMensal";
            this.tabPageMensal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMensal.Size = new System.Drawing.Size(1652, 594);
            this.tabPageMensal.TabIndex = 0;
            this.tabPageMensal.Text = "Listagem Mensal";
            // 
            // buttonRefreshMensal
            // 
            this.buttonRefreshMensal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonRefreshMensal.ForeColor = System.Drawing.Color.White;
            this.buttonRefreshMensal.Location = new System.Drawing.Point(20, 20);
            this.buttonRefreshMensal.Name = "buttonRefreshMensal";
            this.buttonRefreshMensal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonRefreshMensal.Size = new System.Drawing.Size(180, 45);
            this.buttonRefreshMensal.TabIndex = 3;
            this.buttonRefreshMensal.Text = "Atualizar";
            this.buttonRefreshMensal.UseVisualStyleBackColor = false;
            this.buttonRefreshMensal.Click += new System.EventHandler(this.buttonRefreshMensal_Click);
            // 
            // panelMensal
            // 
            this.panelMensal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelMensal.Controls.Add(this.labelMesHeader);
            this.panelMensal.Controls.Add(this.labelOrcamentoHeader);
            this.panelMensal.Controls.Add(this.labelTotalHeader);
            this.panelMensal.Controls.Add(this.labelDiferencaHeader);
            this.panelMensal.ForeColor = System.Drawing.Color.White;
            this.panelMensal.Location = new System.Drawing.Point(20, 80);
            this.panelMensal.Name = "panelMensal";
            this.panelMensal.Size = new System.Drawing.Size(1200, 46);
            this.panelMensal.TabIndex = 2;
            // 
            // labelMesHeader
            // 
            this.labelMesHeader.AutoSize = true;
            this.labelMesHeader.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelMesHeader.Location = new System.Drawing.Point(14, 8);
            this.labelMesHeader.Name = "labelMesHeader";
            this.labelMesHeader.Size = new System.Drawing.Size(56, 32);
            this.labelMesHeader.TabIndex = 0;
            this.labelMesHeader.Text = "Mês";
            // 
            // labelOrcamentoHeader
            // 
            this.labelOrcamentoHeader.AutoSize = true;
            this.labelOrcamentoHeader.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelOrcamentoHeader.Location = new System.Drawing.Point(247, 8);
            this.labelOrcamentoHeader.Name = "labelOrcamentoHeader";
            this.labelOrcamentoHeader.Size = new System.Drawing.Size(131, 32);
            this.labelOrcamentoHeader.TabIndex = 1;
            this.labelOrcamentoHeader.Text = "Orçamento";
            // 
            // labelTotalHeader
            // 
            this.labelTotalHeader.AutoSize = true;
            this.labelTotalHeader.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelTotalHeader.Location = new System.Drawing.Point(520, 8);
            this.labelTotalHeader.Name = "labelTotalHeader";
            this.labelTotalHeader.Size = new System.Drawing.Size(147, 32);
            this.labelTotalHeader.TabIndex = 2;
            this.labelTotalHeader.Text = "Total Compras";
            // 
            // labelDiferencaHeader
            // 
            this.labelDiferencaHeader.AutoSize = true;
            this.labelDiferencaHeader.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelDiferencaHeader.Location = new System.Drawing.Point(820, 8);
            this.labelDiferencaHeader.Name = "labelDiferencaHeader";
            this.labelDiferencaHeader.Size = new System.Drawing.Size(117, 32);
            this.labelDiferencaHeader.TabIndex = 3;
            this.labelDiferencaHeader.Text = "Diferença";
            // 
            // listBoxMensal
            // 
            this.listBoxMensal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.listBoxMensal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxMensal.ForeColor = System.Drawing.Color.White;
            this.listBoxMensal.FormattingEnabled = true;
            this.listBoxMensal.ItemHeight = 20;
            this.listBoxMensal.Location = new System.Drawing.Point(20, 130);
            this.listBoxMensal.Name = "listBoxMensal";
            this.listBoxMensal.Size = new System.Drawing.Size(1200, 424);
            this.listBoxMensal.TabIndex = 1;
            // 
            // tabPageSugestoes
            // 
            this.tabPageSugestoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.tabPageSugestoes.Controls.Add(this.buttonExportarCSV);
            this.tabPageSugestoes.Controls.Add(this.buttonRefreshSugestoes);
            this.tabPageSugestoes.Controls.Add(this.groupBoxAnalise);
            this.tabPageSugestoes.Controls.Add(this.groupBoxSugestoes);
            this.tabPageSugestoes.Controls.Add(this.groupBoxSugestaoOrcamento);
            this.tabPageSugestoes.Location = new System.Drawing.Point(4, 32);
            this.tabPageSugestoes.Name = "tabPageSugestoes";
            this.tabPageSugestoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSugestoes.Size = new System.Drawing.Size(1652, 594);
            this.tabPageSugestoes.TabIndex = 1;
            this.tabPageSugestoes.Text = "Sugestões / Exportar";
            // 
            // groupBoxSugestaoOrcamento
            // 
            this.groupBoxSugestaoOrcamento.Controls.Add(this.textBoxSugestaoOrcamento);
            this.groupBoxSugestaoOrcamento.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.groupBoxSugestaoOrcamento.Location = new System.Drawing.Point(20, 20);
            this.groupBoxSugestaoOrcamento.Name = "groupBoxSugestaoOrcamento";
            this.groupBoxSugestaoOrcamento.Size = new System.Drawing.Size(600, 80);
            this.groupBoxSugestaoOrcamento.TabIndex = 0;
            this.groupBoxSugestaoOrcamento.TabStop = false;
            this.groupBoxSugestaoOrcamento.Text = "Sugestão de Orçamento";
            // 
            // textBoxSugestaoOrcamento
            // 
            this.textBoxSugestaoOrcamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.textBoxSugestaoOrcamento.Font = new System.Drawing.Font("Courier New", 9F);
            this.textBoxSugestaoOrcamento.ForeColor = System.Drawing.Color.White;
            this.textBoxSugestaoOrcamento.Location = new System.Drawing.Point(15, 32);
            this.textBoxSugestaoOrcamento.Name = "textBoxSugestaoOrcamento";
            this.textBoxSugestaoOrcamento.ReadOnly = true;
            this.textBoxSugestaoOrcamento.Size = new System.Drawing.Size(570, 28);
            this.textBoxSugestaoOrcamento.TabIndex = 0;
            // 
            // groupBoxSugestoes
            // 
            this.groupBoxSugestoes.Controls.Add(this.listBoxSugestoes);
            this.groupBoxSugestoes.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.groupBoxSugestoes.Location = new System.Drawing.Point(20, 115);
            this.groupBoxSugestoes.Name = "groupBoxSugestoes";
            this.groupBoxSugestoes.Size = new System.Drawing.Size(600, 270);
            this.groupBoxSugestoes.TabIndex = 1;
            this.groupBoxSugestoes.TabStop = false;
            this.groupBoxSugestoes.Text = "Sugestão de Lista de Compras (semana atual)";
            // 
            // listBoxSugestoes
            // 
            this.listBoxSugestoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.listBoxSugestoes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxSugestoes.ForeColor = System.Drawing.Color.White;
            this.listBoxSugestoes.FormattingEnabled = true;
            this.listBoxSugestoes.ItemHeight = 18;
            this.listBoxSugestoes.Location = new System.Drawing.Point(15, 30);
            this.listBoxSugestoes.Name = "listBoxSugestoes";
            this.listBoxSugestoes.Size = new System.Drawing.Size(570, 220);
            this.listBoxSugestoes.TabIndex = 0;
            // 
            // groupBoxAnalise
            // 
            this.groupBoxAnalise.Controls.Add(this.listBoxAnalise);
            this.groupBoxAnalise.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.groupBoxAnalise.Location = new System.Drawing.Point(640, 20);
            this.groupBoxAnalise.Name = "groupBoxAnalise";
            this.groupBoxAnalise.Size = new System.Drawing.Size(600, 365);
            this.groupBoxAnalise.TabIndex = 2;
            this.groupBoxAnalise.TabStop = false;
            this.groupBoxAnalise.Text = "Análise de Compras Fechadas";
            // 
            // listBoxAnalise
            // 
            this.listBoxAnalise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.listBoxAnalise.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxAnalise.ForeColor = System.Drawing.Color.White;
            this.listBoxAnalise.FormattingEnabled = true;
            this.listBoxAnalise.ItemHeight = 18;
            this.listBoxAnalise.Location = new System.Drawing.Point(15, 30);
            this.listBoxAnalise.Name = "listBoxAnalise";
            this.listBoxAnalise.Size = new System.Drawing.Size(570, 310);
            this.listBoxAnalise.TabIndex = 1;
            // 
            // buttonRefreshSugestoes
            // 
            this.buttonRefreshSugestoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonRefreshSugestoes.ForeColor = System.Drawing.Color.White;
            this.buttonRefreshSugestoes.Location = new System.Drawing.Point(640, 400);
            this.buttonRefreshSugestoes.Name = "buttonRefreshSugestoes";
            this.buttonRefreshSugestoes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonRefreshSugestoes.Size = new System.Drawing.Size(180, 45);
            this.buttonRefreshSugestoes.TabIndex = 4;
            this.buttonRefreshSugestoes.Text = "Atualizar";
            this.buttonRefreshSugestoes.UseVisualStyleBackColor = false;
            this.buttonRefreshSugestoes.Click += new System.EventHandler(this.buttonRefreshSugestoes_Click);
            // 
            // buttonExportarCSV
            // 
            this.buttonExportarCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonExportarCSV.ForeColor = System.Drawing.Color.White;
            this.buttonExportarCSV.Location = new System.Drawing.Point(640, 460);
            this.buttonExportarCSV.Name = "buttonExportarCSV";
            this.buttonExportarCSV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonExportarCSV.Size = new System.Drawing.Size(180, 45);
            this.buttonExportarCSV.TabIndex = 5;
            this.buttonExportarCSV.Text = "Exportar CSV";
            this.buttonExportarCSV.UseVisualStyleBackColor = false;
            this.buttonExportarCSV.Click += new System.EventHandler(this.buttonExportarCSV_Click);
            // 
            // Estatistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.tabControlEstatistica);
            this.Controls.Add(this.label1);
            this.Name = "Estatistica";
            this.Size = new System.Drawing.Size(1724, 753);
            this.tabControlEstatistica.ResumeLayout(false);
            this.tabPageMensal.ResumeLayout(false);
            this.panelMensal.ResumeLayout(false);
            this.panelMensal.PerformLayout();
            this.tabPageSugestoes.ResumeLayout(false);
            this.groupBoxSugestaoOrcamento.ResumeLayout(false);
            this.groupBoxSugestaoOrcamento.PerformLayout();
            this.groupBoxSugestoes.ResumeLayout(false);
            this.groupBoxAnalise.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlEstatistica;
        private System.Windows.Forms.TabPage tabPageMensal;
        private System.Windows.Forms.TabPage tabPageSugestoes;
        private System.Windows.Forms.ListBox listBoxMensal;
        private System.Windows.Forms.Panel panelMensal;
        private System.Windows.Forms.Label labelMesHeader;
        private System.Windows.Forms.Label labelOrcamentoHeader;
        private System.Windows.Forms.Label labelTotalHeader;
        private System.Windows.Forms.Label labelDiferencaHeader;
        private System.Windows.Forms.Button buttonRefreshMensal;
        private System.Windows.Forms.GroupBox groupBoxSugestaoOrcamento;
        private System.Windows.Forms.TextBox textBoxSugestaoOrcamento;
        private System.Windows.Forms.GroupBox groupBoxSugestoes;
        private System.Windows.Forms.ListBox listBoxSugestoes;
        private System.Windows.Forms.GroupBox groupBoxAnalise;
        private System.Windows.Forms.ListBox listBoxAnalise;
        private System.Windows.Forms.Button buttonRefreshSugestoes;
        private System.Windows.Forms.Button buttonExportarCSV;
    }
}
