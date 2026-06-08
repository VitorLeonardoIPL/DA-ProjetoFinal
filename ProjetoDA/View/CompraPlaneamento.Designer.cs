namespace ProjetoDA.View
{
    partial class CompraPlaneamento
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCompras = new System.Windows.Forms.ListBox();
            this.buttonNovaCompra = new System.Windows.Forms.Button();
            this.buttonEditarCompra = new System.Windows.Forms.Button();
            this.buttonModoCompra = new System.Windows.Forms.Button();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(77, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planeamento de Compras";
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltro.Items.AddRange(new object[] { "Todas", "Abertas", "Fechadas" });
            this.comboBoxFiltro.Location = new System.Drawing.Point(77, 110);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(200, 24);
            this.comboBoxFiltro.TabIndex = 1;
            this.comboBoxFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltro_SelectedIndexChanged);
            // 
            // buttonNovaCompra
            // 
            this.buttonNovaCompra.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            this.buttonNovaCompra.ForeColor = System.Drawing.Color.White;
            this.buttonNovaCompra.Location = new System.Drawing.Point(700, 51);
            this.buttonNovaCompra.Name = "buttonNovaCompra";
            this.buttonNovaCompra.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonNovaCompra.Size = new System.Drawing.Size(200, 57);
            this.buttonNovaCompra.TabIndex = 2;
            this.buttonNovaCompra.Text = "Nova Compra";
            this.buttonNovaCompra.UseVisualStyleBackColor = false;
            this.buttonNovaCompra.Click += new System.EventHandler(this.buttonNovaCompra_Click);
            // 
            // buttonEditarCompra
            // 
            this.buttonEditarCompra.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            this.buttonEditarCompra.ForeColor = System.Drawing.Color.White;
            this.buttonEditarCompra.Location = new System.Drawing.Point(920, 51);
            this.buttonEditarCompra.Name = "buttonEditarCompra";
            this.buttonEditarCompra.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonEditarCompra.Size = new System.Drawing.Size(200, 57);
            this.buttonEditarCompra.TabIndex = 3;
            this.buttonEditarCompra.Text = "Editar";
            this.buttonEditarCompra.UseVisualStyleBackColor = false;
            this.buttonEditarCompra.Click += new System.EventHandler(this.buttonEditarCompra_Click);
            // 
            // buttonModoCompra
            // 
            this.buttonModoCompra.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            this.buttonModoCompra.ForeColor = System.Drawing.Color.White;
            this.buttonModoCompra.Location = new System.Drawing.Point(1140, 51);
            this.buttonModoCompra.Name = "buttonModoCompra";
            this.buttonModoCompra.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonModoCompra.Size = new System.Drawing.Size(200, 57);
            this.buttonModoCompra.TabIndex = 4;
            this.buttonModoCompra.Text = "Modo Compra";
            this.buttonModoCompra.UseVisualStyleBackColor = false;
            this.buttonModoCompra.Click += new System.EventHandler(this.buttonModoCompra_Click);
            // 
            // listBoxCompras
            // 
            this.listBoxCompras.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
            this.listBoxCompras.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxCompras.ForeColor = System.Drawing.Color.White;
            this.listBoxCompras.FormattingEnabled = true;
            this.listBoxCompras.ItemHeight = 16;
            this.listBoxCompras.Location = new System.Drawing.Point(77, 160);
            this.listBoxCompras.Name = "listBoxCompras";
            this.listBoxCompras.Size = new System.Drawing.Size(1500, 500);
            this.listBoxCompras.DoubleClick += new System.EventHandler(this.listBoxCompras_DoubleClick);
            this.listBoxCompras.TabIndex = 5;
            // 
            // CompraPlaneamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxCompras);
            this.Controls.Add(this.buttonModoCompra);
            this.Controls.Add(this.buttonEditarCompra);
            this.Controls.Add(this.buttonNovaCompra);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.label1);
            this.Name = "CompraPlaneamento";
            this.Size = new System.Drawing.Size(1724, 753);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCompras;
        private System.Windows.Forms.Button buttonNovaCompra;
        private System.Windows.Forms.Button buttonEditarCompra;
        private System.Windows.Forms.Button buttonModoCompra;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
    }
}
