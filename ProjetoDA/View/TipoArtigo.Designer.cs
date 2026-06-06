namespace ProjetoDA.View
{
    partial class TipoArtigoControl
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listboxTiposArtigo = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(637, 39);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonAdd.Size = new System.Drawing.Size(237, 57);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Novo Tipo de Artigo";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAddTipoArtigo);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditar.Location = new System.Drawing.Point(770, 39);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonEditar.Size = new System.Drawing.Size(237, 57);
            this.buttonEditar.TabIndex = 10;
            this.buttonEditar.Text = "Editar Tipo de Artigo";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditarTipo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gestão de Tipos de Artigo";
            // 
            // listboxTiposArtigo
            // 
            this.listboxTiposArtigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.listboxTiposArtigo.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.listboxTiposArtigo.ForeColor = System.Drawing.Color.White;
            this.listboxTiposArtigo.FormattingEnabled = true;
            this.listboxTiposArtigo.ItemHeight = 20;
            this.listboxTiposArtigo.Location = new System.Drawing.Point(60, 379);
            this.listboxTiposArtigo.Name = "listboxTiposArtigo";
            this.listboxTiposArtigo.Size = new System.Drawing.Size(1121, 284);
            this.listboxTiposArtigo.TabIndex = 4;
            this.listboxTiposArtigo.SelectedIndexChanged += new System.EventHandler(this.listboxTiposArtigo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(60, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 46);
            this.panel1.TabIndex = 8;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelNome.Location = new System.Drawing.Point(16, 8);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(80, 32);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.buttonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemove.Location = new System.Drawing.Point(904, 39);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonRemove.Size = new System.Drawing.Size(237, 57);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "       Remover Tipo de Artigo";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(60, 179);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(255, 22);
            this.textBoxNome.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome do Artigo";
            // 
            // TipoArtigoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listboxTiposArtigo);
            this.Name = "TipoArtigoControl";
            this.Size = new System.Drawing.Size(1724, 753);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listboxTiposArtigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label3;
    }
}
