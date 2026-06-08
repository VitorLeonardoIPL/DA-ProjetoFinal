using ProjetoDA.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new AppDbInitializer());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

              var loginForm = new View.Login_Page();
               if (loginForm.ShowDialog() == DialogResult.OK)
               {
                   Application.Run(new MainForm());
               }

        }
    }
}
