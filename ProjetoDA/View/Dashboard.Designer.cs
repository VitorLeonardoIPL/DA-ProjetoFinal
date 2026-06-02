namespace ProjetoDA.View
{
    partial class Dashboard
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_NovaCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(78, 180);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1121, 308);
            this.listBox1.TabIndex = 0;
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
            // button_NovaCompra
            // 
            this.button_NovaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button_NovaCompra.ForeColor = System.Drawing.Color.White;
            this.button_NovaCompra.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.button_NovaCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_NovaCompra.Location = new System.Drawing.Point(1009, 49);
            this.button_NovaCompra.Name = "button_NovaCompra";
            this.button_NovaCompra.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_NovaCompra.Size = new System.Drawing.Size(190, 57);
            this.button_NovaCompra.TabIndex = 3;
            this.button_NovaCompra.Text = "Nova Compra";
            this.button_NovaCompra.UseVisualStyleBackColor = false;
            this.button_NovaCompra.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.button_NovaCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1724, 753);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_NovaCompra;
    }
}
