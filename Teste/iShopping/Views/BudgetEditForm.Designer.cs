namespace iShopping.Views
{
    partial class BudgetEditForm
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
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmountHint = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 280);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Orçamento";

            // Título
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(100, 15);
            this.lblTitle.Text = "Definir Orçamento";

            // Mês
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(30, 50);
            this.lblMonth.Text = "Mês:";

            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Location = new System.Drawing.Point(30, 70);
            this.cmbMonth.Size = new System.Drawing.Size(140, 21);
            this.cmbMonth.TabIndex = 0;

            // Ano
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(190, 50);
            this.lblYear.Text = "Ano:";

            this.numYear.Location = new System.Drawing.Point(190, 70);
            this.numYear.Size = new System.Drawing.Size(80, 20);
            this.numYear.TabIndex = 1;

            // Valor
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(30, 100);
            this.lblAmount.Text = "Valor do Orçamento (€):";

            this.txtAmount.Location = new System.Drawing.Point(30, 120);
            this.txtAmount.Size = new System.Drawing.Size(240, 20);
            this.txtAmount.TabIndex = 2;

            // Dica
            this.lblAmountHint.AutoSize = true;
            this.lblAmountHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.lblAmountHint.ForeColor = System.Drawing.Color.Gray;
            this.lblAmountHint.Location = new System.Drawing.Point(30, 145);
            this.lblAmountHint.Text = "Exemplo: 500.00";

            // Botão Guardar
            this.btnSave.Text = "Guardar";
            this.btnSave.Location = new System.Drawing.Point(30, 190);
            this.btnSave.Size = new System.Drawing.Size(130, 35);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            // Botão Cancelar
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new System.Drawing.Point(190, 190);
            this.btnCancel.Size = new System.Drawing.Size(130, 35);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAmountHint);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblTitle);

            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmountHint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
