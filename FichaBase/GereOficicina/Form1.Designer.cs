namespace GereOficicina
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listboxClientes = new System.Windows.Forms.ListBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxNif = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxClientes
            // 
            this.listboxClientes.FormattingEnabled = true;
            this.listboxClientes.ItemHeight = 16;
            this.listboxClientes.Location = new System.Drawing.Point(67, 38);
            this.listboxClientes.Name = "listboxClientes";
            this.listboxClientes.Size = new System.Drawing.Size(380, 372);
            this.listboxClientes.TabIndex = 0;
            this.listboxClientes.SelectedIndexChanged += new System.EventHandler(this.listboxClientes_SelectedIndexChanged);
            this.listboxClientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listboxClientes_MouseDoubleClick);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(575, 54);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(182, 22);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxNif
            // 
            this.textBoxNif.Location = new System.Drawing.Point(575, 112);
            this.textBoxNif.Name = "textBoxNif";
            this.textBoxNif.Size = new System.Drawing.Size(182, 22);
            this.textBoxNif.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(618, 173);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(107, 41);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Adicionar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNif);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.listboxClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxClientes;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxNif;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button1;
    }
}

