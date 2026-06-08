namespace ProjetoDA.View
{
    partial class UtilizadorControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxUtilizadores = new System.Windows.Forms.ListBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestão de Utilizadores";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonAdicionar.ForeColor = System.Drawing.Color.White;
            this.buttonAdicionar.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.buttonAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdicionar.Location = new System.Drawing.Point(627, 43);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonAdicionar.Size = new System.Drawing.Size(237, 57);
            this.buttonAdicionar.TabIndex = 1;
            this.buttonAdicionar.Text = "Adicionar Utilizador";
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditar.Location = new System.Drawing.Point(850, 43);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonEditar.Size = new System.Drawing.Size(237, 57);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar Utilizador";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonRemover.ForeColor = System.Drawing.Color.White;
            this.buttonRemover.Image = global::ProjetoDA.Properties.Resources.icons8_plus_26;
            this.buttonRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemover.Location = new System.Drawing.Point(1075, 43);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonRemover.Size = new System.Drawing.Size(237, 57);
            this.buttonRemover.TabIndex = 3;
            this.buttonRemover.Text = "Remover Utilizador";
            this.buttonRemover.UseVisualStyleBackColor = false;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(46, 131);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(433, 32);
            this.textBoxUsername.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(46, 199);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(433, 32);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(46, 269);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(433, 32);
            this.textBoxEmail.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.labelData);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(46, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 46);
            this.panel1.TabIndex = 10;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelUsername.Location = new System.Drawing.Point(14, 8);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(121, 32);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelEmail.Location = new System.Drawing.Point(247, 8);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(71, 32);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelData.Location = new System.Drawing.Point(563, 8);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(138, 32);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Data Criação";
            // 
            // listBoxUtilizadores
            // 
            this.listBoxUtilizadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.listBoxUtilizadores.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxUtilizadores.ForeColor = System.Drawing.Color.White;
            this.listBoxUtilizadores.FormattingEnabled = true;
            this.listBoxUtilizadores.ItemHeight = 20;
            this.listBoxUtilizadores.Location = new System.Drawing.Point(46, 362);
            this.listBoxUtilizadores.Name = "listBoxUtilizadores";
            this.listBoxUtilizadores.Size = new System.Drawing.Size(1121, 304);
            this.listBoxUtilizadores.TabIndex = 11;
            this.listBoxUtilizadores.SelectedIndexChanged += new System.EventHandler(this.listBoxUtilizadores_SelectedIndexChanged);
            // 
            // UtilizadorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxUtilizadores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.label1);
            this.Name = "UtilizadorControl";
            this.Size = new System.Drawing.Size(1724, 753);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxUtilizadores;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelData;
    }
}
