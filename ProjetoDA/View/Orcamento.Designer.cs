namespace ProjetoDA.View
{
    partial class OrcamentoControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxOrcamentos = new System.Windows.Forms.ListBox();
            this.buttonNovoOrcamento = new System.Windows.Forms.Button();
            this.dateTimePickerDataFim = new System.Windows.Forms.DateTimePicker();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomeOrcamento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gestão de Orçamentos";
            // 
            // listBoxOrcamentos
            // 
            this.listBoxOrcamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.listBoxOrcamentos.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBoxOrcamentos.FormattingEnabled = true;
            this.listBoxOrcamentos.ItemHeight = 16;
            this.listBoxOrcamentos.Location = new System.Drawing.Point(47, 366);
            this.listBoxOrcamentos.Name = "listBoxOrcamentos";
            this.listBoxOrcamentos.Size = new System.Drawing.Size(1121, 308);
            this.listBoxOrcamentos.TabIndex = 11;
            // 
            // buttonNovoOrcamento
            // 
            this.buttonNovoOrcamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonNovoOrcamento.ForeColor = System.Drawing.Color.White;
            this.buttonNovoOrcamento.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.buttonNovoOrcamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNovoOrcamento.Location = new System.Drawing.Point(683, 35);
            this.buttonNovoOrcamento.Name = "buttonNovoOrcamento";
            this.buttonNovoOrcamento.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonNovoOrcamento.Size = new System.Drawing.Size(237, 57);
            this.buttonNovoOrcamento.TabIndex = 13;
            this.buttonNovoOrcamento.Text = "Novo Orçamento";
            this.buttonNovoOrcamento.UseVisualStyleBackColor = false;
            this.buttonNovoOrcamento.Click += new System.EventHandler(this.buttonNovoOrcamento_Click);
            // 
            // dateTimePickerDataFim
            // 
            this.dateTimePickerDataFim.Location = new System.Drawing.Point(47, 320);
            this.dateTimePickerDataFim.Name = "dateTimePickerDataFim";
            this.dateTimePickerDataFim.Size = new System.Drawing.Size(433, 22);
            this.dateTimePickerDataFim.TabIndex = 43;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(47, 195);
            this.textBoxValor.Multiline = true;
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(433, 32);
            this.textBoxValor.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Valor";
            // 
            // dateTimePickerDataInicio
            // 
            this.dateTimePickerDataInicio.Location = new System.Drawing.Point(47, 265);
            this.dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            this.dateTimePickerDataInicio.Size = new System.Drawing.Size(433, 22);
            this.dateTimePickerDataInicio.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Data Fim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Data Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nome do Orçamento";
            // 
            // textBoxNomeOrcamento
            // 
            this.textBoxNomeOrcamento.Location = new System.Drawing.Point(47, 133);
            this.textBoxNomeOrcamento.Multiline = true;
            this.textBoxNomeOrcamento.Name = "textBoxNomeOrcamento";
            this.textBoxNomeOrcamento.Size = new System.Drawing.Size(433, 32);
            this.textBoxNomeOrcamento.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(950, 35);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(237, 57);
            this.button1.TabIndex = 44;
            this.button1.Text = "Eliminar Orçamento";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // OrcamentoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerDataFim);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDataInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomeOrcamento);
            this.Controls.Add(this.buttonNovoOrcamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxOrcamentos);
            this.Name = "OrcamentoControl";
            this.Size = new System.Drawing.Size(1724, 753);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNovoOrcamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxOrcamentos;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFim;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomeOrcamento;
        private System.Windows.Forms.Button button1;
    }
}
