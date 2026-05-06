using System;
using System.Windows.Forms;

namespace iShopping.Utils
{
    /// <summary>
    /// Classe auxiliar para mostrar mensagens de erro consistentes.
    /// Evita repetir código de MessageBox.Show em toda a aplicação.
    /// </summary>
    public static class ErrorHelper
    {
        /// <summary>
        /// Mostra um erro de base de dados com instruções de resolução.
        /// </summary>
        public static void ShowDatabaseError(Exception ex)
        {
            MessageBox.Show("Não foi possível ligar à base de dados.\n\n" +
                "Detalhes: " + ex.Message + "\n\n" +
                "Verifique se:\n" +
                "1. O SQL Server está a funcionar\n" +
                "2. A connection string no App.config está correta",
                "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Mostra um erro genérico com o contexto da operação que falhou.
        /// </summary>
        public static void ShowGeneralError(Exception ex, string context)
        {
            MessageBox.Show("Ocorreu um erro durante: " + context + "\n\n" +
                "Detalhes: " + ex.Message,
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
