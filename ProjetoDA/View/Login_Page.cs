using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDA.Controller;
using ProjetoDA.Model;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                using (var db = new ProjetoDAContext())
                {
                    var user = UtilizadorController.Login(db, textBox1.Text, textBox2.Text);
                    if (user != null)
                    {
                        SessaoAtual.UtilizadorLogado = user;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Credenciais inválidas!", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
          
        }
    }
}
