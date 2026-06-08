namespace ProjetoDA.View
{
    partial class CompraEditar
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTipoArtigo = new System.Windows.Forms.ComboBox();
            this.comboBoxArtigo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericQtdPrevista = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxItens = new System.Windows.Forms.ListBox();
            this.buttonAdicionarItem = new System.Windows.Forms.Button();
            this.buttonRemoverItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericQtdPrevista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados da Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(33, 93);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(400, 28);
            this.textBoxNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descricao";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(33, 153);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(400, 55);
            this.textBoxDescricao.TabIndex = 4;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(520, 470);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(100, 40);
            this.buttonGuardar.TabIndex = 5;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(630, 470);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 40);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo Artigo";
            // 
            // comboBoxTipoArtigo
            // 
            this.comboBoxTipoArtigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoArtigo.Location = new System.Drawing.Point(470, 55);
            this.comboBoxTipoArtigo.Name = "comboBoxTipoArtigo";
            this.comboBoxTipoArtigo.Size = new System.Drawing.Size(260, 24);
            this.comboBoxTipoArtigo.TabIndex = 8;
            this.comboBoxTipoArtigo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoArtigo_SelectedIndexChanged);
            // 
            // comboBoxArtigo
            // 
            this.comboBoxArtigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArtigo.Enabled = false;
            this.comboBoxArtigo.Location = new System.Drawing.Point(470, 100);
            this.comboBoxArtigo.Name = "comboBoxArtigo";
            this.comboBoxArtigo.Size = new System.Drawing.Size(260, 24);
            this.comboBoxArtigo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Artigo";
            // 
            // numericQtdPrevista
            // 
            this.numericQtdPrevista.Location = new System.Drawing.Point(470, 148);
            this.numericQtdPrevista.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.numericQtdPrevista.Name = "numericQtdPrevista";
            this.numericQtdPrevista.Size = new System.Drawing.Size(120, 22);
            this.numericQtdPrevista.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Qtd Prevista";
            // 
            // listBoxItens
            // 
            this.listBoxItens.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            this.listBoxItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxItens.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxItens.ForeColor = System.Drawing.Color.White;
            this.listBoxItens.FormattingEnabled = true;
            this.listBoxItens.ItemHeight = 17;
            this.listBoxItens.Location = new System.Drawing.Point(33, 230);
            this.listBoxItens.Name = "listBoxItens";
            this.listBoxItens.Size = new System.Drawing.Size(697, 225);
            this.listBoxItens.TabIndex = 13;
            // 
            // buttonAdicionarItem
            // 
            this.buttonAdicionarItem.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            this.buttonAdicionarItem.ForeColor = System.Drawing.Color.White;
            this.buttonAdicionarItem.Location = new System.Drawing.Point(610, 145);
            this.buttonAdicionarItem.Name = "buttonAdicionarItem";
            this.buttonAdicionarItem.Size = new System.Drawing.Size(120, 28);
            this.buttonAdicionarItem.TabIndex = 14;
            this.buttonAdicionarItem.Text = "Adicionar";
            this.buttonAdicionarItem.UseVisualStyleBackColor = false;
            this.buttonAdicionarItem.Click += new System.EventHandler(this.buttonAdicionarItem_Click);
            // 
            // buttonRemoverItem
            // 
            this.buttonRemoverItem.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            this.buttonRemoverItem.ForeColor = System.Drawing.Color.White;
            this.buttonRemoverItem.Location = new System.Drawing.Point(610, 179);
            this.buttonRemoverItem.Name = "buttonRemoverItem";
            this.buttonRemoverItem.Size = new System.Drawing.Size(120, 28);
            this.buttonRemoverItem.TabIndex = 15;
            this.buttonRemoverItem.Text = "Remover";
            this.buttonRemoverItem.UseVisualStyleBackColor = false;
            this.buttonRemoverItem.Click += new System.EventHandler(this.buttonRemoverItem_Click);
            // 
            // CompraEditar
            // 
            this.ClientSize = new System.Drawing.Size(764, 534);
            this.Controls.Add(this.buttonRemoverItem);
            this.Controls.Add(this.buttonAdicionarItem);
            this.Controls.Add(this.listBoxItens);
            this.Controls.Add(this.numericQtdPrevista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxArtigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTipoArtigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompraEditar";
            this.Text = "Compra";
            ((System.ComponentModel.ISupportInitialize)(this.numericQtdPrevista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ComboBox comboBoxTipoArtigo;
        private System.Windows.Forms.ComboBox comboBoxArtigo;
        private System.Windows.Forms.NumericUpDown numericQtdPrevista;
        internal System.Windows.Forms.ListBox listBoxItens;
        private System.Windows.Forms.Button buttonAdicionarItem;
        private System.Windows.Forms.Button buttonRemoverItem;
    }
}
