using ProjetoDA.Model;
using System;
using System.Linq;

namespace ProjetoDA.Controller
{
    public static class UtilizadorController
    {
        /// <summary>
        /// Tenta fazer login. Retorna o utilizador ou null se credenciais inválidas.
        /// </summary>
        public static Utilizador Login(ProjetoDAContext db, string username, string password)
        {
            var user = db.Utilizadores.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                user.DataUltimoLogin = DateTime.Now;
                db.SaveChanges();
            }

            return user;
        }

        /// <summary>
        /// Regista um novo utilizador. Retorna true se conseguiu, false se username já existe.
        /// </summary>
        public static bool Registar(ProjetoDAContext db, string username, string password, string email)
        {
            if (db.Utilizadores.Any(u => u.Username == username))
                return false;

            db.Utilizadores.Add(new Utilizador
            {
                Username = username,
                Password = password,
                Email = email,
                DataCriacao = DateTime.Now
            });

            db.SaveChanges();
            return true;
        }

        public static IQueryable<Utilizador> Listar(ProjetoDAContext db)
        {
            return db.Utilizadores.OrderBy(u => u.Username);
        }

        public static Utilizador Obter(ProjetoDAContext db, int id)
        {
            return db.Utilizadores.Find(id);
        }

        public static void Atualizar(ProjetoDAContext db, Utilizador user)
        {
            var existente = db.Utilizadores.Find(user.Id);
            if (existente == null) return;

            existente.Username = user.Username;
            existente.Password = user.Password;
            existente.Email = user.Email;
            db.SaveChanges();
        }

        public static void Eliminar(ProjetoDAContext db, int id)
        {
            var user = db.Utilizadores.Find(id);
            if (user != null)
            {
                db.Utilizadores.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
