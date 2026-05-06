namespace iShopping.Views
{
    partial class ArticleEditForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 220);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Artigo";

            // Título
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(120, 15);
            this.lblTitle.Text = "Dados do Artigo";

            // Label Tipo de Artigo (IMPORTANTE: primeiro escolhe-se o tipo)
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(30, 50);
            this.lblType.Text = "Tipo de Artigo:";

            // ComboBox de Tipos de Artigo
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // Só pode selecionar, não escrever
            this.cmbType.Location = new System.Drawing.Point(30, 70);
            this.cmbType.Size = new System.Drawing.Size(320, 21);
            this.cmbType.TabIndex = 0;

            // Label Nome
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 100);
            this.lblName.Text = "Nome do Artigo:";

            // TextBox Nome
            this.txtName.Location = new System.Drawing.Point(30, 120);
            this.txtName.Size = new System.Drawing.Size(320, 20);
            this.txtName.TabIndex = 1;

            // Botão Guardar
            this.btnSave.Text = "Guardar";
            this.btnSave.Location = new System.Drawing.Point(30, 155);
            this.btnSave.Size = new System.Drawing.Size(140, 35);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            // Botão Cancelar
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new System.Drawing.Point(210, 155);
            this.btnCancel.Size = new System.Drawing.Size(140, 35);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTitle);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
