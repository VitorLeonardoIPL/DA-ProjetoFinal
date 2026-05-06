namespace iShopping.Views
{
    partial class ShoppingModeForm
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
            this.groupBoxPlanned = new System.Windows.Forms.GroupBox();
            this.dgvPlanned = new System.Windows.Forms.DataGridView();
            this.groupBoxUnplanned = new System.Windows.Forms.GroupBox();
            this.lblUnplannedName = new System.Windows.Forms.Label();
            this.txtUnplannedName = new System.Windows.Forms.TextBox();
            this.lblUnplannedObs = new System.Windows.Forms.Label();
            this.txtUnplannedObs = new System.Windows.Forms.TextBox();
            this.lblUnplannedQty = new System.Windows.Forms.Label();
            this.numUnplannedQty = new System.Windows.Forms.NumericUpDown();
            this.lblUnplannedPrice = new System.Windows.Forms.Label();
            this.txtUnplannedPrice = new System.Windows.Forms.TextBox();
            this.btnAddUnplanned = new System.Windows.Forms.Button();
            this.dgvUnplanned = new System.Windows.Forms.DataGridView();
            this.btnRemoveUnplanned = new System.Windows.Forms.Button();
            this.groupBoxBudget = new System.Windows.Forms.GroupBox();
            this.lblBudgetAmount = new System.Windows.Forms.Label();
            this.lblSpent = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBudgetStatus = new System.Windows.Forms.Label();
            this.btnCloseShopping = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            // Colunas para Itens Previstos
            this.colItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlannedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcquiredQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // Colunas para Itens Não Previstos
            this.colUnplannedId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnplannedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnplannedObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnplannedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnplannedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnplannedSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.groupBoxPlanned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanned)).BeginInit();
            this.groupBoxUnplanned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnplannedQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnplanned)).BeginInit();
            this.groupBoxBudget.SuspendLayout();
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "iShopping - Modo Compra";

            // Título
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "Modo Compra";

            // Nome da Compra
            this.lblShoppingName.AutoSize = true;
            this.lblShoppingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblShoppingName.Location = new System.Drawing.Point(20, 45);
            this.lblShoppingName.Text = "Compra: ";

            // GroupBox: Itens Previstos
            this.groupBoxPlanned.Text = "Itens Previstos (edite Quantidade e Preço)";
            this.groupBoxPlanned.Location = new System.Drawing.Point(20, 80);
            this.groupBoxPlanned.Size = new System.Drawing.Size(860, 250);

            this.dgvPlanned.AllowUserToAddRows = false;
            this.dgvPlanned.AllowUserToDeleteRows = false;
            this.dgvPlanned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanned.MultiSelect = false;

            this.colItemId.HeaderText = "ID";
            this.colItemId.Name = "colItemId";
            this.colItemId.Visible = false;

            this.colArticleName.HeaderText = "Artigo";
            this.colArticleName.Name = "colArticleName";
            this.colArticleName.Width = 250;
            this.colArticleName.ReadOnly = true;

            this.colPlannedQty.HeaderText = "Qtd. Planeada";
            this.colPlannedQty.Name = "colPlannedQty";
            this.colPlannedQty.Width = 100;
            this.colPlannedQty.ReadOnly = true;

            this.colAcquiredQty.HeaderText = "Qtd. Adquirida";
            this.colAcquiredQty.Name = "colAcquiredQty";
            this.colAcquiredQty.Width = 100;

            this.colUnitPrice.HeaderText = "Preço Unit. (€)";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Width = 100;

            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.Width = 100;
            this.colSubtotal.ReadOnly = true;

            this.dgvPlanned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colItemId, this.colArticleName, this.colPlannedQty,
                this.colAcquiredQty, this.colUnitPrice, this.colSubtotal
            });
            this.dgvPlanned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlanned.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPlanned_CellEndEdit);

            this.groupBoxPlanned.Controls.Add(this.dgvPlanned);

            // GroupBox: Itens Não Previstos
            this.groupBoxUnplanned.Text = "Adicionar Artigo Não Previsto";
            this.groupBoxUnplanned.Location = new System.Drawing.Point(20, 340);
            this.groupBoxUnplanned.Size = new System.Drawing.Size(860, 100);

            this.lblUnplannedName.AutoSize = true;
            this.lblUnplannedName.Location = new System.Drawing.Point(15, 25);
            this.lblUnplannedName.Text = "Nome:";

            this.txtUnplannedName.Location = new System.Drawing.Point(15, 45);
            this.txtUnplannedName.Size = new System.Drawing.Size(200, 20);

            this.lblUnplannedObs.AutoSize = true;
            this.lblUnplannedObs.Location = new System.Drawing.Point(225, 25);
            this.lblUnplannedObs.Text = "Obs:";

            this.txtUnplannedObs.Location = new System.Drawing.Point(225, 45);
            this.txtUnplannedObs.Size = new System.Drawing.Size(150, 20);

            this.lblUnplannedQty.AutoSize = true;
            this.lblUnplannedQty.Location = new System.Drawing.Point(390, 25);
            this.lblUnplannedQty.Text = "Qtd:";

            this.numUnplannedQty.Location = new System.Drawing.Point(390, 45);
            this.numUnplannedQty.Minimum = 1;
            this.numUnplannedQty.Value = 1;
            this.numUnplannedQty.Size = new System.Drawing.Size(50, 20);

            this.lblUnplannedPrice.AutoSize = true;
            this.lblUnplannedPrice.Location = new System.Drawing.Point(455, 25);
            this.lblUnplannedPrice.Text = "Preço:";

            this.txtUnplannedPrice.Location = new System.Drawing.Point(455, 45);
            this.txtUnplannedPrice.Size = new System.Drawing.Size(70, 20);

            this.btnAddUnplanned.Text = "Adicionar";
            this.btnAddUnplanned.Location = new System.Drawing.Point(540, 42);
            this.btnAddUnplanned.Size = new System.Drawing.Size(100, 25);
            this.btnAddUnplanned.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnAddUnplanned.ForeColor = System.Drawing.Color.White;
            this.btnAddUnplanned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUnplanned.Click += new System.EventHandler(this.BtnAddUnplanned_Click);

            this.groupBoxUnplanned.Controls.Add(this.lblUnplannedName);
            this.groupBoxUnplanned.Controls.Add(this.txtUnplannedName);
            this.groupBoxUnplanned.Controls.Add(this.lblUnplannedObs);
            this.groupBoxUnplanned.Controls.Add(this.txtUnplannedObs);
            this.groupBoxUnplanned.Controls.Add(this.lblUnplannedQty);
            this.groupBoxUnplanned.Controls.Add(this.numUnplannedQty);
            this.groupBoxUnplanned.Controls.Add(this.lblUnplannedPrice);
            this.groupBoxUnplanned.Controls.Add(this.txtUnplannedPrice);
            this.groupBoxUnplanned.Controls.Add(this.btnAddUnplanned);

            // GroupBox: Orçamento
            this.groupBoxBudget.Text = "Orçamento do Mês";
            this.groupBoxBudget.Location = new System.Drawing.Point(20, 450);
            this.groupBoxBudget.Size = new System.Drawing.Size(600, 100);

            this.lblBudgetAmount.AutoSize = true;
            this.lblBudgetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBudgetAmount.Location = new System.Drawing.Point(20, 20);
            this.lblBudgetAmount.Text = "Orçamento: 0.00 €";

            this.lblSpent.AutoSize = true;
            this.lblSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSpent.Location = new System.Drawing.Point(20, 45);
            this.lblSpent.Text = "Gasto: 0.00 €";

            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblBalance.Location = new System.Drawing.Point(20, 70);
            this.lblBalance.Text = "Saldo: 0.00 €";

            this.lblBudgetStatus.AutoSize = true;
            this.lblBudgetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblBudgetStatus.Location = new System.Drawing.Point(300, 40);
            this.lblBudgetStatus.Text = "Status";

            this.groupBoxBudget.Controls.Add(this.lblBudgetAmount);
            this.groupBoxBudget.Controls.Add(this.lblSpent);
            this.groupBoxBudget.Controls.Add(this.lblBalance);
            this.groupBoxBudget.Controls.Add(this.lblBudgetStatus);

            // Botões de Ação
            this.btnCloseShopping.Text = "Fechar Compra";
            this.btnCloseShopping.Location = new System.Drawing.Point(650, 460);
            this.btnCloseShopping.Size = new System.Drawing.Size(230, 50);
            this.btnCloseShopping.BackColor = System.Drawing.Color.FromArgb(111, 66, 193);
            this.btnCloseShopping.ForeColor = System.Drawing.Color.White;
            this.btnCloseShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCloseShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseShopping.Click += new System.EventHandler(this.BtnCloseShopping_Click);

            this.btnClose.Text = "Cancelar";
            this.btnClose.Location = new System.Drawing.Point(650, 520);
            this.btnClose.Size = new System.Drawing.Size(230, 35);
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

            // DataGridView de Não Previstos (posicionada no fundo)
            this.dgvUnplanned.AllowUserToAddRows = false;
            this.dgvUnplanned.AllowUserToDeleteRows = false;
            this.dgvUnplanned.ReadOnly = true;
            this.dgvUnplanned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnplanned.MultiSelect = false;

            this.colUnplannedId.HeaderText = "ID";
            this.colUnplannedId.Name = "colUnplannedId";
            this.colUnplannedId.Visible = false;

            this.colUnplannedName.HeaderText = "Artigo";
            this.colUnplannedName.Name = "colUnplannedName";
            this.colUnplannedName.Width = 200;

            this.colUnplannedObs.HeaderText = "Observações";
            this.colUnplannedObs.Name = "colUnplannedObs";
            this.colUnplannedObs.Width = 200;

            this.colUnplannedQty.HeaderText = "Qtd";
            this.colUnplannedQty.Name = "colUnplannedQty";
            this.colUnplannedQty.Width = 60;

            this.colUnplannedPrice.HeaderText = "Preço";
            this.colUnplannedPrice.Name = "colUnplannedPrice";
            this.colUnplannedPrice.Width = 80;

            this.colUnplannedSubtotal.HeaderText = "Subtotal";
            this.colUnplannedSubtotal.Name = "colUnplannedSubtotal";
            this.colUnplannedSubtotal.Width = 80;

            this.dgvUnplanned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colUnplannedId, this.colUnplannedName, this.colUnplannedObs,
                this.colUnplannedQty, this.colUnplannedPrice, this.colUnplannedSubtotal
            });
            this.dgvUnplanned.Location = new System.Drawing.Point(20, 550);
            this.dgvUnplanned.Size = new System.Drawing.Size(600, 70);

            this.btnRemoveUnplanned.Text = "Remover";
            this.btnRemoveUnplanned.Location = new System.Drawing.Point(650, 565);
            this.btnRemoveUnplanned.Size = new System.Drawing.Size(100, 35);
            this.btnRemoveUnplanned.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnRemoveUnplanned.ForeColor = System.Drawing.Color.White;
            this.btnRemoveUnplanned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUnplanned.Click += new System.EventHandler(this.BtnRemoveUnplanned_Click);

            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCloseShopping);
            this.Controls.Add(this.btnRemoveUnplanned);
            this.Controls.Add(this.dgvUnplanned);
            this.Controls.Add(this.groupBoxBudget);
            this.Controls.Add(this.groupBoxUnplanned);
            this.Controls.Add(this.groupBoxPlanned);
            this.Controls.Add(this.lblShoppingName);
            this.Controls.Add(this.lblTitle);

            this.groupBoxPlanned.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanned)).EndInit();
            this.groupBoxUnplanned.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUnplannedQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnplanned)).BeginInit();
            this.groupBoxBudget.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblShoppingName;
        private System.Windows.Forms.GroupBox groupBoxPlanned;
        private System.Windows.Forms.DataGridView dgvPlanned;
        private System.Windows.Forms.GroupBox groupBoxUnplanned;
        private System.Windows.Forms.Label lblUnplannedName;
        private System.Windows.Forms.TextBox txtUnplannedName;
        private System.Windows.Forms.Label lblUnplannedObs;
        private System.Windows.Forms.TextBox txtUnplannedObs;
        private System.Windows.Forms.Label lblUnplannedQty;
        private System.Windows.Forms.NumericUpDown numUnplannedQty;
        private System.Windows.Forms.Label lblUnplannedPrice;
        private System.Windows.Forms.TextBox txtUnplannedPrice;
        private System.Windows.Forms.Button btnAddUnplanned;
        private System.Windows.Forms.DataGridView dgvUnplanned;
        private System.Windows.Forms.Button btnRemoveUnplanned;
        private System.Windows.Forms.GroupBox groupBoxBudget;
        private System.Windows.Forms.Label lblBudgetAmount;
        private System.Windows.Forms.Label lblSpent;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBudgetStatus;
        private System.Windows.Forms.Button btnCloseShopping;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.DataGridViewTextBoxColumn colItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlannedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcquiredQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;

        private System.Windows.Forms.DataGridViewTextBoxColumn colUnplannedId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnplannedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnplannedObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnplannedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnplannedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnplannedSubtotal;
    }
}
