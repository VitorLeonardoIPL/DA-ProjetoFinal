using iShopping.Models;

namespace iShopping.Utils
{
    /// <summary>
    /// Classe que guarda informações sobre o utilizador que fez login.
    /// É acessível em toda a aplicação para saber quem está logado.
    /// 
    /// Porquê usar uma classe estática?
    /// - Porque só pode haver UM utilizador logado de cada vez
    /// - Porque precisamos aceder a esta informação em qualquer formulário
    /// - Porque é simples e fácil de entender para quem está a aprender
    /// </summary>
    public static class SessionManager
    {
        // Variável privada que guarda o utilizador logado
        private static User _currentUser;

        /// <summary>
        /// Propriedade para aceder ao utilizador logado.
        /// Exemplo de uso: User currentUser = SessionManager.CurrentUser;
        /// </summary>
        public static User CurrentUser
        {
            get { return _currentUser; }
            private set { _currentUser = value; }
        }

        /// <summary>
        /// Verifica se há um utilizador logado.
        /// </summary>
        public static bool IsLoggedIn
        {
            get { return _currentUser != null; }
        }

        /// <summary>
        /// Define o utilizador logado (chamado após login bem-sucedido).
        /// </summary>
        public static void Login(User user)
        {
            _currentUser = user;
        }

        /// <summary>
        /// Remove o utilizador logado (chamado ao fazer logout).
        /// </summary>
        public static void Logout()
        {
            _currentUser = null;
        }

        /// <summary>
        /// Retorna o ID do utilizador logado.
        /// Útil quando precisamos do ID para criar registos na BD.
        /// </summary>
        public static int GetUserId()
        {
            if (_currentUser != null)
            {
                return _currentUser.Id;
            }
            return -1; // Retorna -1 se não houver utilizador logado
        }

        /// <summary>
        /// Retorna o username do utilizador logado.
        /// Útil para mostrar no interface ou para mensagens.
        /// </summary>
        public static string GetUsername()
        {
            if (_currentUser != null)
            {
                return _currentUser.Username;
            }
            return "";
        }
    }
}
