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
            this.buttonAddTipo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listboxTiposArtigo = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonEditarTipo = new System.Windows.Forms.Button();
            this.buttonRemoveTipo = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddTipo
            // 
            this.buttonAddTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonAddTipo.ForeColor = System.Drawing.Color.White;
            this.buttonAddTipo.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.buttonAddTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddTipo.Location = new System.Drawing.Point(527, 39);
            this.buttonAddTipo.Name = "buttonAddTipo";
            this.buttonAddTipo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonAddTipo.Size = new System.Drawing.Size(237, 57);
            this.buttonAddTipo.TabIndex = 7;
            this.buttonAddTipo.Text = "Novo Tipo de Artigo";
            this.buttonAddTipo.UseVisualStyleBackColor = false;
            this.buttonAddTipo.Click += new System.EventHandler(this.buttonAddTipoArtigo);
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
            // buttonEditarTipo
            // 
            this.buttonEditarTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonEditarTipo.ForeColor = System.Drawing.Color.White;
            this.buttonEditarTipo.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.buttonEditarTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarTipo.Location = new System.Drawing.Point(770, 39);
            this.buttonEditarTipo.Name = "buttonEditarTipo";
            this.buttonEditarTipo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonEditarTipo.Size = new System.Drawing.Size(237, 57);
            this.buttonEditarTipo.TabIndex = 10;
            this.buttonEditarTipo.Text = "Editar Tipo de Artigo";
            this.buttonEditarTipo.UseVisualStyleBackColor = false;
            this.buttonEditarTipo.Click += new System.EventHandler(this.buttonEditarTipo_Click);
            // 
            // buttonRemoveTipo
            // 
            this.buttonRemoveTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonRemoveTipo.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveTipo.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.buttonRemoveTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoveTipo.Location = new System.Drawing.Point(1012, 39);
            this.buttonRemoveTipo.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.buttonRemoveTipo.Name = "buttonRemoveTipo";
            this.buttonRemoveTipo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonRemoveTipo.Size = new System.Drawing.Size(237, 57);
            this.buttonRemoveTipo.TabIndex = 9;
            this.buttonRemoveTipo.Text = "       Remover Tipo de Artigo";
            this.buttonRemoveTipo.UseVisualStyleBackColor = false;
            this.buttonRemoveTipo.Click += new System.EventHandler(this.buttonRemove_Click);
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
            this.Controls.Add(this.buttonRemoveTipo);
            this.Controls.Add(this.buttonEditarTipo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAddTipo);
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

        private System.Windows.Forms.Button buttonAddTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listboxTiposArtigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button buttonRemoveTipo;
        private System.Windows.Forms.Button buttonEditarTipo;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label3;
    }
}
