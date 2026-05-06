namespace iShopping.Views
{
    partial class ShoppingPlanForm
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
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.dgvShopping = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnShoppingMode = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClosedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvShopping)).BeginInit();
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "iShopping - Planeamento de Compras";

            // Título
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "Planeamento de Compras";

            // Filtro
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(20, 50);
            this.lblFilter.Text = "Estado:";

            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Location = new System.Drawing.Point(80, 47);
            this.cmbFilter.Size = new System.Drawing.Size(150, 21);
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);

            // DataGridView
            this.dgvShopping.AllowUserToAddRows = false;
            this.dgvShopping.AllowUserToDeleteRows = false;
            this.dgvShopping.ReadOnly = true;
            this.dgvShopping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShopping.MultiSelect = false;

            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.Width = 40;

            this.colName.HeaderText = "Nome";
            this.colName.Name = "colName";
            this.colName.Width = 150;

            this.colDescription.HeaderText = "Descrição";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 200;

            this.colCreatedAt.HeaderText = "Criada Em";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.Width = 120;

            this.colStatus.HeaderText = "Estado";
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 70;

            this.colClosedAt.HeaderText = "Fechada Em";
            this.colClosedAt.Name = "colClosedAt";
            this.colClosedAt.Width = 120;

            this.dgvShopping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId,
                this.colName,
                this.colDescription,
                this.colCreatedAt,
                this.colStatus,
                this.colClosedAt
            });
            this.dgvShopping.Location = new System.Drawing.Point(20, 80);
            this.dgvShopping.Size = new System.Drawing.Size(760, 300);
            this.dgvShopping.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvShopping_CellDoubleClick);

            // Botões
            this.btnNew.Text = "Nova Compra";
            this.btnNew.Location = new System.Drawing.Point(20, 400);
            this.btnNew.Size = new System.Drawing.Size(120, 35);
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);

            this.btnEdit.Text = "Editar";
            this.btnEdit.Location = new System.Drawing.Point(155, 400);
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);

            this.btnItems.Text = "Gerir Itens";
            this.btnItems.Location = new System.Drawing.Point(270, 400);
            this.btnItems.Size = new System.Drawing.Size(100, 35);
            this.btnItems.BackColor = System.Drawing.Color.FromArgb(253, 126, 20);
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Click += new System.EventHandler(this.BtnItems_Click);

            this.btnShoppingMode.Text = "Modo Compra";
            this.btnShoppingMode.Location = new System.Drawing.Point(385, 400);
            this.btnShoppingMode.Size = new System.Drawing.Size(120, 35);
            this.btnShoppingMode.BackColor = System.Drawing.Color.FromArgb(111, 66, 193);
            this.btnShoppingMode.ForeColor = System.Drawing.Color.White;
            this.btnShoppingMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingMode.Click += new System.EventHandler(this.BtnShoppingMode_Click);

            this.btnDelete.Text = "Eliminar";
            this.btnDelete.Location = new System.Drawing.Point(520, 400);
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);

            this.btnClose.Text = "Fechar";
            this.btnClose.Location = new System.Drawing.Point(635, 400);
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShoppingMode);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvShopping);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblTitle);

            ((System.ComponentModel.ISupportInitialize)(this.dgvShopping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.DataGridView dgvShopping;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnShoppingMode;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClosedAt;
    }
}
