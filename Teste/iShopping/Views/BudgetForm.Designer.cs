namespace iShopping.Views
{
    partial class BudgetForm
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
            this.dgvBudgets = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonthYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgets)).BeginInit();
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 420);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "iShopping - Gestão de Orçamentos";

            // Título
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "Orçamentos Mensais";

            // DataGridView
            this.dgvBudgets.AllowUserToAddRows = false;
            this.dgvBudgets.AllowUserToDeleteRows = false;
            this.dgvBudgets.ReadOnly = true;
            this.dgvBudgets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBudgets.MultiSelect = false;

            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.Width = 40;

            this.colMonthYear.HeaderText = "Mês / Ano";
            this.colMonthYear.Name = "colMonthYear";
            this.colMonthYear.Width = 150;

            this.colAmount.HeaderText = "Orçamento (€)";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 130;

            this.colSpent.HeaderText = "Total Gasto (€)";
            this.colSpent.Name = "colSpent";
            this.colSpent.Width = 130;

            this.colBalance.HeaderText = "Saldo (€)";
            this.colBalance.Name = "colBalance";
            this.colBalance.Width = 130;

            this.dgvBudgets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId,
                this.colMonthYear,
                this.colAmount,
                this.colSpent,
                this.colBalance
            });
            this.dgvBudgets.Location = new System.Drawing.Point(20, 50);
            this.dgvBudgets.Size = new System.Drawing.Size(610, 280);
            this.dgvBudgets.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBudgets_CellDoubleClick);

            // Botões
            this.btnNew.Text = "Novo";
            this.btnNew.Location = new System.Drawing.Point(20, 350);
            this.btnNew.Size = new System.Drawing.Size(120, 35);
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);

            this.btnEdit.Text = "Editar";
            this.btnEdit.Location = new System.Drawing.Point(160, 350);
            this.btnEdit.Size = new System.Drawing.Size(120, 35);
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);

            this.btnDelete.Text = "Eliminar";
            this.btnDelete.Location = new System.Drawing.Point(300, 350);
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);

            this.btnClose.Text = "Fechar";
            this.btnClose.Location = new System.Drawing.Point(440, 350);
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvBudgets);
            this.Controls.Add(this.lblTitle);

            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvBudgets;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonthYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
    }
}
