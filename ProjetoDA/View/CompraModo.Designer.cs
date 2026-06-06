namespace ProjetoDA.View
{
    partial class CompraModo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.listBoxItens = new System.Windows.Forms.ListBox();
            this.comboBoxTipoArtigo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxArtigo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericPrecoUnitario = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxObservacoes = new System.Windows.Forms.TextBox();
            this.buttonAdicionarNaoPrevisto = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelOrcamento = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoUnitario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modo Compra";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelNome.Location = new System.Drawing.Point(180, 24);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(70, 23);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Compra";
            // 
            // listBoxItens
            // 
            this.listBoxItens.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            this.listBoxItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxItens.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxItens.ForeColor = System.Drawing.Color.White;
            this.listBoxItens.FormattingEnabled = true;
            this.listBoxItens.ItemHeight = 17;
            this.listBoxItens.Location = new System.Drawing.Point(20, 60);
            this.listBoxItens.Name = "listBoxItens";
            this.listBoxItens.Size = new System.Drawing.Size(760, 200);
            this.listBoxItens.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxObservacoes);
            this.groupBox1.Controls.Add(this.buttonAdicionarNaoPrevisto);
            this.groupBox1.Controls.Add(this.numericPrecoUnitario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericQuantidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxArtigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxTipoArtigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Item Nao Previsto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo Artigo";
            // 
            // comboBoxTipoArtigo
            // 
            this.comboBoxTipoArtigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoArtigo.Location = new System.Drawing.Point(15, 48);
            this.comboBoxTipoArtigo.Name = "comboBoxTipoArtigo";
            this.comboBoxTipoArtigo.Size = new System.Drawing.Size(150, 24);
            this.comboBoxTipoArtigo.TabIndex = 1;
            this.comboBoxTipoArtigo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoArtigo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Artigo";
            // 
            // comboBoxArtigo
            // 
            this.comboBoxArtigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArtigo.Enabled = false;
            this.comboBoxArtigo.Location = new System.Drawing.Point(180, 48);
            this.comboBoxArtigo.Name = "comboBoxArtigo";
            this.comboBoxArtigo.Size = new System.Drawing.Size(150, 24);
            this.comboBoxArtigo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Qtd";
            // 
            // numericQuantidade
            // 
            this.numericQuantidade.Location = new System.Drawing.Point(345, 48);
            this.numericQuantidade.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.numericQuantidade.Name = "numericQuantidade";
            this.numericQuantidade.Size = new System.Drawing.Size(80, 22);
            this.numericQuantidade.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Preco Unit.";
            // 
            // numericPrecoUnitario
            // 
            this.numericPrecoUnitario.DecimalPlaces = 2;
            this.numericPrecoUnitario.Location = new System.Drawing.Point(440, 48);
            this.numericPrecoUnitario.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.numericPrecoUnitario.Name = "numericPrecoUnitario";
            this.numericPrecoUnitario.Size = new System.Drawing.Size(80, 22);
            this.numericPrecoUnitario.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Observacoes";
            // 
            // textBoxObservacoes
            // 
            this.textBoxObservacoes.Location = new System.Drawing.Point(535, 48);
            this.textBoxObservacoes.Name = "textBoxObservacoes";
            this.textBoxObservacoes.Size = new System.Drawing.Size(140, 22);
            this.textBoxObservacoes.TabIndex = 9;
            // 
            // buttonAdicionarNaoPrevisto
            // 
            this.buttonAdicionarNaoPrevisto.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            this.buttonAdicionarNaoPrevisto.ForeColor = System.Drawing.Color.White;
            this.buttonAdicionarNaoPrevisto.Location = new System.Drawing.Point(15, 85);
            this.buttonAdicionarNaoPrevisto.Name = "buttonAdicionarNaoPrevisto";
            this.buttonAdicionarNaoPrevisto.Size = new System.Drawing.Size(150, 30);
            this.buttonAdicionarNaoPrevisto.TabIndex = 10;
            this.buttonAdicionarNaoPrevisto.Text = "Adicionar";
            this.buttonAdicionarNaoPrevisto.UseVisualStyleBackColor = false;
            this.buttonAdicionarNaoPrevisto.Click += new System.EventHandler(this.buttonAdicionarNaoPrevisto_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTotal.Location = new System.Drawing.Point(20, 420);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(74, 23);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Total: 0 €";
            // 
            // labelOrcamento
            // 
            this.labelOrcamento.AutoSize = true;
            this.labelOrcamento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelOrcamento.Location = new System.Drawing.Point(20, 453);
            this.labelOrcamento.Name = "labelOrcamento";
            this.labelOrcamento.Size = new System.Drawing.Size(114, 23);
            this.labelOrcamento.TabIndex = 7;
            this.labelOrcamento.Text = "Orcamento: N/D";
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            this.buttonFechar.ForeColor = System.Drawing.Color.White;
            this.buttonFechar.Location = new System.Drawing.Point(530, 420);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(120, 40);
            this.buttonFechar.TabIndex = 8;
            this.buttonFechar.Text = "Fechar Compra";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            this.buttonVoltar.ForeColor = System.Drawing.Color.White;
            this.buttonVoltar.Location = new System.Drawing.Point(660, 420);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(120, 40);
            this.buttonVoltar.TabIndex = 9;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // CompraModo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 494);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.labelOrcamento);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxItens);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CompraModo";
            this.Text = "Modo Compra";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoUnitario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNome;
        internal System.Windows.Forms.ListBox listBoxItens;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTipoArtigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxArtigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericPrecoUnitario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxObservacoes;
        private System.Windows.Forms.Button buttonAdicionarNaoPrevisto;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelOrcamento;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonVoltar;
    }
}
