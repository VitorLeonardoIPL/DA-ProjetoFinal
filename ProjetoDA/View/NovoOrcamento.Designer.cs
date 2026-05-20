namespace ProjetoDA.View
{
    partial class NovoOrcamento
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomeOrcamento = new System.Windows.Forms.TextBox();
            this.buttonGuardarOrcamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataFim = new System.Windows.Forms.DateTimePicker();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Data Fim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Data Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome do Orçamento";
            // 
            // textBoxNomeOrcamento
            // 
            this.textBoxNomeOrcamento.Location = new System.Drawing.Point(74, 163);
            this.textBoxNomeOrcamento.Multiline = true;
            this.textBoxNomeOrcamento.Name = "textBoxNomeOrcamento";
            this.textBoxNomeOrcamento.Size = new System.Drawing.Size(433, 32);
            this.textBoxNomeOrcamento.TabIndex = 26;
            // 
            // buttonGuardarOrcamento
            // 
            this.buttonGuardarOrcamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonGuardarOrcamento.ForeColor = System.Drawing.Color.White;
            this.buttonGuardarOrcamento.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.buttonGuardarOrcamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardarOrcamento.Location = new System.Drawing.Point(948, 350);
            this.buttonGuardarOrcamento.Name = "buttonGuardarOrcamento";
            this.buttonGuardarOrcamento.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonGuardarOrcamento.Size = new System.Drawing.Size(237, 57);
            this.buttonGuardarOrcamento.TabIndex = 25;
            this.buttonGuardarOrcamento.Text = "Guardar Orçamento";
            this.buttonGuardarOrcamento.UseVisualStyleBackColor = false;
            this.buttonGuardarOrcamento.Click += new System.EventHandler(this.buttonGuardarOrcamento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 41);
            this.label1.TabIndex = 24;
            this.label1.Text = "Novo Orçamento";
            // 
            // dateTimePickerDataInicio
            // 
            this.dateTimePickerDataInicio.Location = new System.Drawing.Point(74, 295);
            this.dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            this.dateTimePickerDataInicio.Size = new System.Drawing.Size(433, 22);
            this.dateTimePickerDataInicio.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Valor";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(74, 225);
            this.textBoxValor.Multiline = true;
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(433, 32);
            this.textBoxValor.TabIndex = 34;
            // 
            // dateTimePickerDataFim
            // 
            this.dateTimePickerDataFim.Location = new System.Drawing.Point(74, 350);
            this.dateTimePickerDataFim.Name = "dateTimePickerDataFim";
            this.dateTimePickerDataFim.Size = new System.Drawing.Size(433, 22);
            this.dateTimePickerDataFim.TabIndex = 35;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonVoltar.ForeColor = System.Drawing.Color.White;
            this.buttonVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVoltar.Location = new System.Drawing.Point(705, 350);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonVoltar.Size = new System.Drawing.Size(237, 57);
            this.buttonVoltar.TabIndex = 36;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // NovoOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.dateTimePickerDataFim);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDataInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomeOrcamento);
            this.Controls.Add(this.buttonGuardarOrcamento);
            this.Controls.Add(this.label1);
            this.Name = "NovoOrcamento";
            this.Size = new System.Drawing.Size(1724, 753);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomeOrcamento;
        private System.Windows.Forms.Button buttonGuardarOrcamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFim;
        private System.Windows.Forms.Button buttonVoltar;
    }
}
