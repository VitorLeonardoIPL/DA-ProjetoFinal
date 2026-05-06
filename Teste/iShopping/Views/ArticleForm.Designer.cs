namespace iShopping.Views
{
    partial class ArticleForm
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
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "iShopping - Gestão de Artigos";

            // Título
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "Gestão de Artigos";

            // Label do Filtro
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(20, 50);
            this.lblFilter.Text = "Filtrar por Tipo:";

            // ComboBox de Filtro por Tipo
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.Location = new System.Drawing.Point(130, 47);
            this.cmbFilterType.Size = new System.Drawing.Size(250, 21);
            this.cmbFilterType.SelectedIndexChanged += new System.EventHandler(this.CmbFilterType_SelectedIndexChanged);

            // DataGridView
            this.dgvArticles.AllowUserToAddRows = false;
            this.dgvArticles.AllowUserToDeleteRows = false;
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticles.MultiSelect = false;

            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.Width = 50;

            this.colName.HeaderText = "Nome do Artigo";
            this.colName.Name = "colName";
            this.colName.Width = 300;

            this.colType.HeaderText = "Tipo";
            this.colType.Name = "colType";
            this.colType.Width = 180;

            this.dgvArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId,
                this.colName,
                this.colType
            });
            this.dgvArticles.Location = new System.Drawing.Point(20, 80);
            this.dgvArticles.Size = new System.Drawing.Size(560, 280);
            this.dgvArticles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvArticles_CellDoubleClick);

            // Botões
            this.btnNew.Text = "Novo";
            this.btnNew.Location = new System.Drawing.Point(20, 380);
            this.btnNew.Size = new System.Drawing.Size(110, 35);
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);

            this.btnEdit.Text = "Editar";
            this.btnEdit.Location = new System.Drawing.Point(150, 380);
            this.btnEdit.Size = new System.Drawing.Size(110, 35);
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);

            this.btnDelete.Text = "Eliminar";
            this.btnDelete.Location = new System.Drawing.Point(280, 380);
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);

            this.btnClose.Text = "Fechar";
            this.btnClose.Location = new System.Drawing.Point(410, 380);
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvArticles);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblTitle);

            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
    }
}
