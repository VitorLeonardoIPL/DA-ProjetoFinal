namespace ProjetoDA
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_TipoArtigo = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_Artigos = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_Orcamento = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_Estatistica = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button_Logout = new System.Windows.Forms.Button();
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.contentPanel = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.Panel1);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel9);
            this.sidebar.Controls.Add(this.panel10);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 1000);
            this.sidebar.MinimumSize = new System.Drawing.Size(78, 1000);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 1000);
            this.sidebar.TabIndex = 0;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.menuButton);
            this.Panel1.Controls.Add(this.button7);
            this.Panel1.Location = new System.Drawing.Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(197, 90);
            this.Panel1.TabIndex = 0;
            // 
            // menuButton
            // 
            this.menuButton.Image = global::ProjetoDA.Properties.Resources.icons8_menu_261;
            this.menuButton.Location = new System.Drawing.Point(19, 37);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(33, 30);
            this.menuButton.TabIndex = 4;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-8, -3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(225, 107);
            this.button7.TabIndex = 3;
            this.button7.Text = "             Menu";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_dashboard);
            this.panel3.Location = new System.Drawing.Point(3, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 52);
            this.panel3.TabIndex = 2;
            // 
            // button_dashboard
            // 
            this.button_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dashboard.ForeColor = System.Drawing.Color.White;
            this.button_dashboard.Image = global::ProjetoDA.Properties.Resources.icons8_dashboard_26;
            this.button_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dashboard.Location = new System.Drawing.Point(-3, -10);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_dashboard.Size = new System.Drawing.Size(200, 71);
            this.button_dashboard.TabIndex = 2;
            this.button_dashboard.Text = "           Planear";
            this.button_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dashboard.UseVisualStyleBackColor = true;
            this.button_dashboard.Click += new System.EventHandler(this.button_PlaneamentoClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_TipoArtigo);
            this.panel4.Location = new System.Drawing.Point(3, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 52);
            this.panel4.TabIndex = 3;
            // 
            // button_TipoArtigo
            // 
            this.button_TipoArtigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TipoArtigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TipoArtigo.ForeColor = System.Drawing.Color.White;
            this.button_TipoArtigo.Image = global::ProjetoDA.Properties.Resources.tipo_Artigo;
            this.button_TipoArtigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_TipoArtigo.Location = new System.Drawing.Point(-3, -10);
            this.button_TipoArtigo.Name = "button_TipoArtigo";
            this.button_TipoArtigo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_TipoArtigo.Size = new System.Drawing.Size(220, 71);
            this.button_TipoArtigo.TabIndex = 2;
            this.button_TipoArtigo.Text = "           Tipo Artigo";
            this.button_TipoArtigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_TipoArtigo.UseVisualStyleBackColor = true;
            this.button_TipoArtigo.Click += new System.EventHandler(this.button_TipoArtigo_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button_Artigos);
            this.panel5.Location = new System.Drawing.Point(3, 215);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(188, 52);
            this.panel5.TabIndex = 4;
            // 
            // button_Artigos
            // 
            this.button_Artigos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Artigos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Artigos.ForeColor = System.Drawing.Color.White;
            this.button_Artigos.Image = global::ProjetoDA.Properties.Resources.artigo;
            this.button_Artigos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Artigos.Location = new System.Drawing.Point(-3, -10);
            this.button_Artigos.Name = "button_Artigos";
            this.button_Artigos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Artigos.Size = new System.Drawing.Size(220, 71);
            this.button_Artigos.TabIndex = 2;
            this.button_Artigos.Text = "           Artigos";
            this.button_Artigos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Artigos.UseVisualStyleBackColor = true;
            this.button_Artigos.Click += new System.EventHandler(this.button_Artigos_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button_Orcamento);
            this.panel6.Location = new System.Drawing.Point(3, 273);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(188, 52);
            this.panel6.TabIndex = 5;
            // 
            // button_Orcamento
            // 
            this.button_Orcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Orcamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Orcamento.ForeColor = System.Drawing.Color.White;
            this.button_Orcamento.Image = global::ProjetoDA.Properties.Resources.orcamento;
            this.button_Orcamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Orcamento.Location = new System.Drawing.Point(-3, -10);
            this.button_Orcamento.Name = "button_Orcamento";
            this.button_Orcamento.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Orcamento.Size = new System.Drawing.Size(220, 71);
            this.button_Orcamento.TabIndex = 2;
            this.button_Orcamento.Text = "           Orçamento";
            this.button_Orcamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Orcamento.UseVisualStyleBackColor = true;
            this.button_Orcamento.Click += new System.EventHandler(this.button_Orcamento_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button_Estatistica);
            this.panel7.Location = new System.Drawing.Point(3, 331);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(188, 52);
            this.panel7.TabIndex = 6;
            // 
            // button_Estatistica
            // 
            this.button_Estatistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Estatistica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Estatistica.ForeColor = System.Drawing.Color.White;
            this.button_Estatistica.Image = global::ProjetoDA.Properties.Resources.estatistica;
            this.button_Estatistica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Estatistica.Location = new System.Drawing.Point(-3, -10);
            this.button_Estatistica.Name = "button_Estatistica";
            this.button_Estatistica.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Estatistica.Size = new System.Drawing.Size(220, 71);
            this.button_Estatistica.TabIndex = 2;
            this.button_Estatistica.Text = "           Estatísticas";
            this.button_Estatistica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Estatistica.UseVisualStyleBackColor = true;
            this.button_Estatistica.Click += new System.EventHandler(this.button_Estatistica_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 52);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ProjetoDA.Properties.Resources.login1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-3, -10);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(200, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "           Compra";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button8);
            this.panel8.Location = new System.Drawing.Point(3, 447);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(188, 52);
            this.panel8.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::ProjetoDA.Properties.Resources.estatistica;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-3, -10);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(220, 71);
            this.button8.TabIndex = 2;
            this.button8.Text = "           CENAS1";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(3, 505);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(197, 52);
            this.panel9.TabIndex = 9;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button_Logout);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(3, 563);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(188, 52);
            this.panel10.TabIndex = 10;
            // 
            // button_Logout
            // 
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.ForeColor = System.Drawing.Color.White;
            this.button_Logout.Image = global::ProjetoDA.Properties.Resources.login1;
            this.button_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Logout.Location = new System.Drawing.Point(-9, -9);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Logout.Size = new System.Drawing.Size(200, 71);
            this.button_Logout.TabIndex = 2;
            this.button_Logout.Text = "           LogOut";
            this.button_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Logout.UseVisualStyleBackColor = true;
            this.button_Logout.Click += new System.EventHandler(this.button9_Click);
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Interval = 10;
            this.SidebarTimer.Tick += new System.EventHandler(this.SidebarTimer_Tick);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(200, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1724, 753);
            this.contentPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 753);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidebar);
            this.Name = "MainForm";
            this.Text = "iShopping";
            this.sidebar.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_dashboard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_TipoArtigo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_Artigos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button_Orcamento;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_Estatistica;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer SidebarTimer;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Panel panel10;
    }
}

