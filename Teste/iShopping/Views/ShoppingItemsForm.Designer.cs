namespace iShopping.Views
{
    partial class ShoppingItemsForm
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
            this.lblShoppingName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblArticle = new System.Windows.Forms.Label();
            this.cmbArticle = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlannedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcquiredQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Itens Previstos";

            // Título
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Text = "Itens Previstos";

            // Nome da compra
            this.lblShoppingName.AutoSize = true;
            this.lblShoppingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblShoppingName.Location = new System.Drawing.Point(20, 35);
            this.lblShoppingName.Text = "Compra: ";

            // Tipo de Artigo
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(20, 65);
            this.lblType.Text = "Tipo de Artigo:";

            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Location = new System.Drawing.Point(20, 85);
            this.cmbType.Size = new System.Drawing.Size(200, 21);
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.CmbType_SelectedIndexChanged);

            // Artigo
            this.lblArticle.AutoSize = true;
            this.lblArticle.Location = new System.Drawing.Point(240, 65);
            this.lblArticle.Text = "Artigo:";

            this.cmbArticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticle.Location = new System.Drawing.Point(240, 85);
            this.cmbArticle.Size = new System.Drawing.Size(200, 21);

            // Quantidade
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(460, 65);
            this.lblQuantity.Text = "Quantidade:";

            this.numQuantity.Location = new System.Drawing.Point(460, 85);
            this.numQuantity.Minimum = 1;
            this.numQuantity.Maximum = 999;
            this.numQuantity.Value = 1;
            this.numQuantity.Size = new System.Drawing.Size(60, 20);

            // Botão Adicionar
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.Location = new System.Drawing.Point(540, 82);
            this.btnAdd.Size = new System.Drawing.Size(120, 28);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);

            // DataGridView
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ReadOnly = true;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.MultiSelect = false;

            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.Width = 40;

            this.colArticleType.HeaderText = "Tipo";
            this.colArticleType.Name = "colArticleType";
            this.colArticleType.Width = 120;

            this.colArticleName.HeaderText = "Artigo";
            this.colArticleName.Name = "colArticleName";
            this.colArticleName.Width = 250;

            this.colPlannedQty.HeaderText = "Qtd. Prevista";
            this.colPlannedQty.Name = "colPlannedQty";
            this.colPlannedQty.Width = 100;

            this.colAcquiredQty.HeaderText = "Qtd. Adquirida";
            this.colAcquiredQty.Name = "colAcquiredQty";
            this.colAcquiredQty.Width = 110;

            this.colUnitPrice.HeaderText = "Preço Unitário";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Width = 110;

            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId,
                this.colArticleType,
                this.colArticleName,
                this.colPlannedQty,
                this.colAcquiredQty,
                this.colUnitPrice
            });
            this.dgvItems.Location = new System.Drawing.Point(20, 120);
            this.dgvItems.Size = new System.Drawing.Size(660, 300);

            // Botão Remover
            this.btnRemove.Text = "Remover Selecionado";
            this.btnRemove.Location = new System.Drawing.Point(20, 430);
            this.btnRemove.Size = new System.Drawing.Size(160, 35);
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);

            // Botão Fechar
            this.btnClose.Text = "Fechar";
            this.btnClose.Location = new System.Drawing.Point(560, 430);
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cmbArticle);
            this.Controls.Add(this.lblArticle);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblShoppingName);
            this.Controls.Add(this.lblTitle);

            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblShoppingName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.ComboBox cmbArticle;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlannedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcquiredQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
    }
}
