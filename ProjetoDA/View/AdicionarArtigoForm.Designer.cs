namespace ProjetoDA.View
{
    partial class AdicionarArtigoForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.comboBoxArtigo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artigo";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(76, 192);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(458, 22);
            this.textBoxQuantidade.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(451, 282);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(83, 37);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            //
            // buttonAdicionar
            //
            this.buttonAdicionar.Location = new System.Drawing.Point(551, 282);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(83, 37);
            this.buttonAdicionar.TabIndex = 5;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // comboBoxArtigo
            // 
            this.comboBoxArtigo.FormattingEnabled = true;
            this.comboBoxArtigo.Location = new System.Drawing.Point(76, 92);
            this.comboBoxArtigo.Name = "comboBoxArtigo";
            this.comboBoxArtigo.Size = new System.Drawing.Size(458, 24);
            this.comboBoxArtigo.TabIndex = 6;
            // 
            // AdicionarArtigoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 371);
            this.Controls.Add(this.comboBoxArtigo);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarArtigoForm";
            this.Text = "Adicionar_Artigo";
            this.Load += new System.EventHandler(this.AdicionarArtigoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.ComboBox comboBoxArtigo;
    }
}