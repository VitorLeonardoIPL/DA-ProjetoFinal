namespace ProjetoDA.View
{
    partial class Orcamento
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
            this.listBoxOrcamentos.Location = new System.Drawing.Point(65, 166);
            this.listBoxOrcamentos.Name = "listBoxOrcamentos";
            this.listBoxOrcamentos.Size = new System.Drawing.Size(1121, 308);
            this.listBoxOrcamentos.TabIndex = 11;
            this.listBoxOrcamentos.SelectedIndexChanged += new System.EventHandler(this.listBoxOrcamentos_SelectedIndexChanged);
            // 
            // buttonNovoOrcamento
            // 
            this.buttonNovoOrcamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonNovoOrcamento.ForeColor = System.Drawing.Color.White;
            this.buttonNovoOrcamento.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.buttonNovoOrcamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNovoOrcamento.Location = new System.Drawing.Point(949, 35);
            this.buttonNovoOrcamento.Name = "buttonNovoOrcamento";
            this.buttonNovoOrcamento.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonNovoOrcamento.Size = new System.Drawing.Size(237, 57);
            this.buttonNovoOrcamento.TabIndex = 13;
            this.buttonNovoOrcamento.Text = "Novo Orçamento";
            this.buttonNovoOrcamento.UseVisualStyleBackColor = false;
            this.buttonNovoOrcamento.Click += new System.EventHandler(this.buttonNovoOrcamento_Click);
            // 
            // Orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonNovoOrcamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxOrcamentos);
            this.Name = "Orcamento";
            this.Size = new System.Drawing.Size(1724, 753);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNovoOrcamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxOrcamentos;
    }
}
