namespace ProjetoDA.View
{
    partial class Dashboard
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.listCompras = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovaCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCompras
            // 
            this.listCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.listCompras.ForeColor = System.Drawing.Color.White;
            this.listCompras.FormattingEnabled = true;
            this.listCompras.ItemHeight = 16;
            this.listCompras.Location = new System.Drawing.Point(78, 180);
            this.listCompras.Name = "listCompras";
            this.listCompras.Size = new System.Drawing.Size(1121, 308);
            this.listCompras.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Planeamento de Compras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bem-vindo ao Sistema de Gestão de Compras";
            // 
            // btnNovaCompra
            // 
            this.btnNovaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnNovaCompra.ForeColor = System.Drawing.Color.White;
            this.btnNovaCompra.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.btnNovaCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaCompra.Location = new System.Drawing.Point(1009, 49);
            this.btnNovaCompra.Name = "btnNovaCompra";
            this.btnNovaCompra.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNovaCompra.Size = new System.Drawing.Size(190, 57);
            this.btnNovaCompra.TabIndex = 3;
            this.btnNovaCompra.Text = "Nova Compra";
            this.btnNovaCompra.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnNovaCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCompras);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1724, 753);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCompras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovaCompra;
    }
}
