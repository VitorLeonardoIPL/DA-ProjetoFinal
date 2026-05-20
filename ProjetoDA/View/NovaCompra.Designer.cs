namespace ProjetoDA.View
{
    partial class NovaCompra
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxNomeCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerCompra = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.buttonGravarCompra = new System.Windows.Forms.Button();
            this.buttonAdicionarItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nova Compra";
            // 
            // listBoxItems
            // 
            this.listBoxItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.listBoxItems.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 16;
            this.listBoxItems.Location = new System.Drawing.Point(104, 378);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(1121, 212);
            this.listBoxItems.TabIndex = 14;
            // 
            // textBoxNomeCompra
            // 
            this.textBoxNomeCompra.Location = new System.Drawing.Point(104, 167);
            this.textBoxNomeCompra.Multiline = true;
            this.textBoxNomeCompra.Name = "textBoxNomeCompra";
            this.textBoxNomeCompra.Size = new System.Drawing.Size(433, 32);
            this.textBoxNomeCompra.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome da Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data";
            // 
            // dateTimePickerCompra
            // 
            this.dateTimePickerCompra.Location = new System.Drawing.Point(104, 235);
            this.dateTimePickerCompra.Name = "dateTimePickerCompra";
            this.dateTimePickerCompra.Size = new System.Drawing.Size(433, 22);
            this.dateTimePickerCompra.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 616);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Total:";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Location = new System.Drawing.Point(148, 616);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(14, 16);
            this.labelValorTotal.TabIndex = 27;
            this.labelValorTotal.Text = "€";
            // 
            // buttonGravarCompra
            // 
            this.buttonGravarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonGravarCompra.ForeColor = System.Drawing.Color.White;
            this.buttonGravarCompra.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.buttonGravarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGravarCompra.Location = new System.Drawing.Point(258, 596);
            this.buttonGravarCompra.Name = "buttonGravarCompra";
            this.buttonGravarCompra.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonGravarCompra.Size = new System.Drawing.Size(237, 57);
            this.buttonGravarCompra.TabIndex = 25;
            this.buttonGravarCompra.Text = "Gravar Compra";
            this.buttonGravarCompra.UseVisualStyleBackColor = false;
            this.buttonGravarCompra.Click += new System.EventHandler(this.buttonGravarCompra_Click);
            // 
            // buttonAdicionarItem
            // 
            this.buttonAdicionarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonAdicionarItem.ForeColor = System.Drawing.Color.White;
            this.buttonAdicionarItem.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.buttonAdicionarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdicionarItem.Location = new System.Drawing.Point(988, 378);
            this.buttonAdicionarItem.Name = "buttonAdicionarItem";
            this.buttonAdicionarItem.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonAdicionarItem.Size = new System.Drawing.Size(237, 57);
            this.buttonAdicionarItem.TabIndex = 16;
            this.buttonAdicionarItem.Text = "Adicionar Item";
            this.buttonAdicionarItem.UseVisualStyleBackColor = false;
            this.buttonAdicionarItem.Click += new System.EventHandler(this.buttonAdicionarItem_Click);
            // 
            // NovaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonGravarCompra);
            this.Controls.Add(this.dateTimePickerCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomeCompra);
            this.Controls.Add(this.buttonAdicionarItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxItems);
            this.Name = "NovaCompra";
            this.Size = new System.Drawing.Size(1724, 753);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxNomeCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerCompra;
        private System.Windows.Forms.Button buttonGravarCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Button buttonAdicionarItem;
    }
}
