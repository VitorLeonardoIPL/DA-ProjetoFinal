namespace ProjetoDA.View
{
    partial class ArtigoControl
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
            this.listBoxArtigo = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonEditarArtigo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomeArtigo = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gestão de Artigos";
            // 
            // listBoxArtigo
            // 
            this.listBoxArtigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.listBoxArtigo.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxArtigo.ForeColor = System.Drawing.Color.White;
            this.listBoxArtigo.FormattingEnabled = true;
            this.listBoxArtigo.ItemHeight = 20;
            this.listBoxArtigo.Location = new System.Drawing.Point(46, 350);
            this.listBoxArtigo.Name = "listBoxArtigo";
            this.listBoxArtigo.Size = new System.Drawing.Size(1121, 304);
            this.listBoxArtigo.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(627, 43);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(237, 57);
            this.button2.TabIndex = 34;
            this.button2.Text = "Adicionar Artigo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonEditarArtigo
            // 
            this.buttonEditarArtigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonEditarArtigo.ForeColor = System.Drawing.Color.White;
            this.buttonEditarArtigo.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.buttonEditarArtigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarArtigo.Location = new System.Drawing.Point(850, 43);
            this.buttonEditarArtigo.Name = "buttonEditarArtigo";
            this.buttonEditarArtigo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonEditarArtigo.Size = new System.Drawing.Size(237, 57);
            this.buttonEditarArtigo.TabIndex = 35;
            this.buttonEditarArtigo.Text = "Editar Artigo";
            this.buttonEditarArtigo.UseVisualStyleBackColor = false;
            this.buttonEditarArtigo.Click += new System.EventHandler(this.buttonEditarArtigo_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1075, 43);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(237, 57);
            this.button3.TabIndex = 33;
            this.button3.Text = "Remover Artigo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonRemoverArtigo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Preço:";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(46, 269);
            this.textBoxPreco.Multiline = true;
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(433, 32);
            this.textBoxPreco.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tipo de Artigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nome do Artigo";
            // 
            // textBoxNomeArtigo
            // 
            this.textBoxNomeArtigo.Location = new System.Drawing.Point(46, 131);
            this.textBoxNomeArtigo.Multiline = true;
            this.textBoxNomeArtigo.Name = "textBoxNomeArtigo";
            this.textBoxNomeArtigo.Size = new System.Drawing.Size(433, 32);
            this.textBoxNomeArtigo.TabIndex = 35;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(46, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(433, 24);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(46, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 46);
            this.panel1.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label5.Location = new System.Drawing.Point(447, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Preço";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelNome.Location = new System.Drawing.Point(103, 6);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(80, 32);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // ArtigoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomeArtigo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonEditarArtigo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxArtigo);
            this.Name = "ArtigoControl";
            this.Size = new System.Drawing.Size(1724, 753);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxArtigo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonEditarArtigo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomeArtigo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label6;
    }
}
