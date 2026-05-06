using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using iShopping.Data;
using iShopping.Models;

namespace iShopping.Controllers
{
    /// <summary>
    /// Controlador de Utilizadores.
    /// Responsável por toda a lógica relacionada com utilizadores:
    /// - Login e registo
    /// - CRUD completo (Criar, Ler, Atualizar, Eliminar)
    /// - Validação de username único
    /// - Encriptação de passwords
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Tenta fazer login com username e password.
        /// Retorna o utilizador se as credenciais estiverem corretas, ou null se falhar.
        /// </summary>
        public User Login(string username, string password)
        {
            // Encriptar a password antes de comparar com a base de dados
            string encryptedPassword = HashPassword(password);

            using (var context = new iShoppingContext())
            {
                // Procurar utilizador com username E password correspondentes
                return context.Users
                    .FirstOrDefault(u => u.Username == username && u.Password == encryptedPassword);
            }
        }

        /// <summary>
        /// Regista um novo utilizador na base de dados.
        /// Retorna true se o registo foi bem-sucedido, false se o username já existe.
        /// </summary>
        public bool Register(string username, string password)
        {
            // Validar se username já existe
            if (IsUsernameTaken(username))
            {
                return false; // Username já está em uso
            }

            using (var context = new iShoppingContext())
            {
                // Criar novo utilizador
                var newUser = new User
                {
                    Username = username,
                    Password = HashPassword(password) // Guardar password encriptada
                };

                context.Users.Add(newUser);
                context.SaveChanges(); // Guardar na base de dados
                return true;
            }
        }

        /// <summary>
        /// Verifica se um username já está registado na base de dados.
        /// </summary>
        public bool IsUsernameTaken(string username)
        {
            using (var context = new iShoppingContext())
            {
                // Retorna true se existir pelo menos um utilizador com esse username
                return context.Users.Any(u => u.Username == username);
            }
        }

        /// <summary>
        /// Lista todos os utilizadores registados.
        /// </summary>
        public List<User> GetAllUsers()
        {
            using (var context = new iShoppingContext())
            {
                return context.Users.ToList();
            }
        }

        /// <summary>
        /// Procura um utilizador pelo seu ID.
        /// </summary>
        public User GetUserById(int id)
        {
            using (var context = new iShoppingContext())
            {
                return context.Users.FirstOrDefault(u => u.Id == id);
            }
        }

        /// <summary>
        /// Atualiza os dados de um utilizador existente.
        /// Retorna true se a atualização foi bem-sucedida.
        /// </summary>
        public bool UpdateUser(int userId, string newUsername, string newPassword = null)
        {
            using (var context = new iShoppingContext())
            {
                // Procurar o utilizador na base de dados
                var user = context.Users.FirstOrDefault(u => u.Id == userId);
                if (user == null)
                {
                    return false; // Utilizador não encontrado
                }

                // Verificar se o novo username não está em uso por outro utilizador
                if (user.Username != newUsername && IsUsernameTaken(newUsername))
                {
                    return false; // Username já existe
                }

                // Atualizar dados
                user.Username = newUsername;
                if (!string.IsNullOrEmpty(newPassword))
                {
                    user.Password = HashPassword(newPassword);
                }

                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Elimina um utilizador da base de dados.
        /// Retorna true se a eliminação foi bem-sucedida.
        /// </summary>
        public bool DeleteUser(int userId)
        {
            using (var context = new iShoppingContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == userId);
                if (user == null)
                {
                    return false; // Utilizador não encontrado
                }

                context.Users.Remove(user);
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Método de encriptação de passwords.
        /// Usa SHA256 para transformar a password num hash (texto ilegível).
        /// Isto protege as passwords caso alguém aceda à base de dados.
        /// </summary>
        private string HashPassword(string password)
        {
            // Converter a password para bytes
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            
            // Calcular o hash SHA256
            byte[] hash = SHA256.Create().ComputeHash(bytes);
            
            // Converter o hash para texto hexadecimal
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2")); // "x2" formata cada byte como 2 caracteres hex
            }
            
            return sb.ToString();
        }
    }
}
