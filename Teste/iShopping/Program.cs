using System;
using System.Linq;
using System.Windows.Forms;
using iShopping.Data;
using iShopping.Models;
using iShopping.Views;
using iShopping.Utils;

namespace iShopping
{
    /// <summary>
    /// Ponto de entrada da aplicação.
    /// Contém tratamento global de erros para evitar que a aplicação feche inesperadamente.
    /// </summary>
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Configurações padrão do Windows Forms (visual, comportamento)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configurar tratamento global de erros (UI Thread)
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            
            // Configurar tratamento global de erros (Background threads)
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            try
            {
                // Garantir que a base de dados existe antes de abrir o Login
                DatabaseInitializer.Initialize();
            }
            catch (Exception ex)
            {
                // Se a BD falhar, mostrar mensagem clara e sair
                MessageBox.Show("Erro ao iniciar a base de dados:\n\n" + ex.Message + 
                    "\n\nVerifique se:\n" +
                    "1. O SQL Server está a funcionar\n" +
                    "2. A connection string no App.config está correta\n" +
                    "(Atualize 'Server=.\\SQLEXPRESS' para o nome do seu servidor)",
                    "Erro de Base de Dados", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return; // Sair da aplicação
            }

            // Abrir o formulário de Login como primeira janela
            Application.Run(new LoginForm());
        }

        /// <summary>
        /// Captura erros não tratados na interface gráfica (UI Thread).
        /// Evita que a aplicação feche sem aviso.
        /// </summary>
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ErrorHelper.ShowGeneralError(e.Exception, "operação da interface");
        }

        /// <summary>
        /// Captura erros fatais em threads secundárias.
        /// </summary>
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
                ErrorHelper.ShowGeneralError(ex, "processamento interno");
            }
        }
    }

    /// <summary>
    /// Classe responsável por inicializar a base de dados.
    /// Garante que a BD é criada e que existe pelo menos um utilizador Admin.
    /// </summary>
    public static class DatabaseInitializer
    {
        public static void Initialize()
        {
            using (var context = new iShoppingContext())
            {
                // Testar a conexão à base de dados
                try
                {
                    context.Database.Connection.Open();
                    context.Database.Connection.Close();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception("Não foi possível conectar ao SQL Server.\n" +
                        "Verifique se o serviço está ativo e se a connection string está correta.\n" +
                        "Erro: " + ex.Message);
                }

                // Criar a base de dados se não existir
                context.Database.CreateIfNotExists();

                // Verificar se já existe pelo menos um utilizador
                bool hasUsers = false;
                try
                {
                    hasUsers = context.Users.Count() > 0;
                }
                catch
                {
                    // Se falhar ao ler Users (ex: tabelas ainda não criadas), assumimos que não existem
                    hasUsers = false;
                }

                if (!hasUsers)
                {
                    // Criar utilizador Admin inicial
                    var adminUser = new User
                    {
                        Username = "admin",
                        Password = HashPassword("admin123") // Password encriptada
                    };

                    context.Users.Add(adminUser);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Encripta a password usando SHA256.
        /// </summary>
        private static string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
