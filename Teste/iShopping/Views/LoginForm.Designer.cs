namespace iShopping.Views
{
    partial class LoginForm
    {
        /// <summary>
        /// Variável necessária para o Designer do Windows Forms.
        /// Não apagar esta linha.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão a ser usados.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modificar
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            // ============================================================
            // Criação dos componentes visuais do formulário de Login
            // ============================================================

            // Label e TextBox para Username
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            
            // Label e TextBox para Password
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            
            // Botões de Login e Registo
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            
            // Label do título
            this.lblTitle = new System.Windows.Forms.Label();

            // ============================================================
            // Configurações do Formulário (Form)
            // ============================================================
            this.SuspendLayout(); // Suspender layout para melhor performance
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 280); // Tamanho da janela
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; // Janela não redimensionável
            this.MaximizeBox = false; // Desativar botão de maximizar
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Centrar na tela
            this.Text = "iShopping - Login"; // Título da janela

            // ============================================================
            // Configurações do Label do Título
            // ============================================================
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 29);
            this.lblTitle.Text = "🛒 iShopping";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ============================================================
            // Configurações do Label de Username
            // ============================================================
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(50, 80);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.Text = "Username:";

            // ============================================================
            // Configurações do TextBox de Username
            // ============================================================
            this.txtUsername.Location = new System.Drawing.Point(50, 100);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 20);
            this.txtUsername.TabIndex = 0; // Ordem de tabulação (primeiro campo)
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);

            // ============================================================
            // Configurações do Label de Password
            // ============================================================
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(50, 130);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.Text = "Password:";

            // ============================================================
            // Configurações do TextBox de Password
            // ============================================================
            this.txtPassword.Location = new System.Drawing.Point(50, 150);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 20);
            this.txtPassword.TabIndex = 1; // Ordem de tabulação (segundo campo)
            this.txtPassword.UseSystemPasswordChar = true; // Esconde a password com asteriscos
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);

            // ============================================================
            // Configurações do Botão Login
            // ============================================================
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(0, 123, 255); // Azul
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(50, 190);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);

            // ============================================================
            // Configurações do Botão Registar
            // ============================================================
            this.btnRegister.Location = new System.Drawing.Point(210, 190);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(140, 35);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Registar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);

            // ============================================================
            // Adicionar todos os componentes ao formulário
            // ============================================================
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Declaração dos componentes visuais
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
    }
}
