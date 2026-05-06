namespace iShopping.Views
{
    partial class MainForm
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

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            // ============================================================
            // Criação dos componentes do Formulário Principal
            // ============================================================

            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnArticleTypes = new System.Windows.Forms.Button();
            this.btnArticles = new System.Windows.Forms.Button();
            this.btnBudgets = new System.Windows.Forms.Button();
            this.btnShoppingPlans = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();

            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();

            // ============================================================
            // Configurações do Formulário
            // ============================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iShopping - Menu Principal";
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // ============================================================
            // Painel do Cabeçalho (barra azul no topo)
            // ============================================================
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top; // Fixo no topo
            this.pnlMenu.Height = 80;
            this.pnlMenu.Controls.Add(this.lblAppTitle);
            this.pnlMenu.Controls.Add(this.lblWelcome);

            // Título da aplicação no cabeçalho
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(20, 10);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Text = "🛒 iShopping";

            // Mensagem de boas-vindas
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Text = "Bem-vindo!";

            // ============================================================
            // Botões do Menu (organizados em grelha 2x3)
            // ============================================================
            // Botão 1: Gestão de Utilizadores
            this.btnUsers.Text = "👥 Gestão de Utilizadores";
            this.btnUsers.Size = new System.Drawing.Size(250, 50);
            this.btnUsers.Location = new System.Drawing.Point(50, 120);
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUsers.BackColor = System.Drawing.Color.White;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Click += new System.EventHandler(this.BtnUsers_Click);

            // Botão 2: Gestão de Tipos de Artigo
            this.btnArticleTypes.Text = "📂 Tipos de Artigo";
            this.btnArticleTypes.Size = new System.Drawing.Size(250, 50);
            this.btnArticleTypes.Location = new System.Drawing.Point(320, 120);
            this.btnArticleTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnArticleTypes.BackColor = System.Drawing.Color.White;
            this.btnArticleTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticleTypes.Click += new System.EventHandler(this.BtnArticleTypes_Click);

            // Botão 3: Gestão de Artigos
            this.btnArticles.Text = "📦 Artigos";
            this.btnArticles.Size = new System.Drawing.Size(250, 50);
            this.btnArticles.Location = new System.Drawing.Point(50, 190);
            this.btnArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnArticles.BackColor = System.Drawing.Color.White;
            this.btnArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticles.Click += new System.EventHandler(this.BtnArticles_Click);

            // Botão 4: Gestão de Orçamentos
            this.btnBudgets.Text = "💰 Orçamentos";
            this.btnBudgets.Size = new System.Drawing.Size(250, 50);
            this.btnBudgets.Location = new System.Drawing.Point(320, 190);
            this.btnBudgets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBudgets.BackColor = System.Drawing.Color.White;
            this.btnBudgets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudgets.Click += new System.EventHandler(this.BtnBudgets_Click);

            // Botão 5: Planeamento de Compras
            this.btnShoppingPlans.Text = "📋 Planeamento de Compras";
            this.btnShoppingPlans.Size = new System.Drawing.Size(250, 50);
            this.btnShoppingPlans.Location = new System.Drawing.Point(50, 260);
            this.btnShoppingPlans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShoppingPlans.BackColor = System.Drawing.Color.White;
            this.btnShoppingPlans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingPlans.Click += new System.EventHandler(this.BtnShoppingPlans_Click);

            // Botão 6: Estatísticas
            this.btnStatistics.Text = "📊 Estatísticas";
            this.btnStatistics.Size = new System.Drawing.Size(250, 50);
            this.btnStatistics.Location = new System.Drawing.Point(320, 260);
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStatistics.BackColor = System.Drawing.Color.White;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Click += new System.EventHandler(this.BtnStatistics_Click);

            // ============================================================
            // Botão de Logout (no fundo, a vermelho)
            // ============================================================
            this.btnLogout.Text = "🚪 Sair";
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.Location = new System.Drawing.Point(200, 380);
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(220, 53, 69); // Vermelho
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);

            // ============================================================
            // Adicionar todos os componentes ao formulário
            // ============================================================
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnShoppingPlans);
            this.Controls.Add(this.btnBudgets);
            this.Controls.Add(this.btnArticles);
            this.Controls.Add(this.btnArticleTypes);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.pnlMenu);

            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // Declaração dos componentes
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnArticleTypes;
        private System.Windows.Forms.Button btnArticles;
        private System.Windows.Forms.Button btnBudgets;
        private System.Windows.Forms.Button btnShoppingPlans;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnLogout;
    }
}
