using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA.View
{
    public partial class Orcamento : UserControl
    {
        public Orcamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.ShowNovoOrcamento();
            }
        }
    }
}
