using System;

namespace ProjetoDA.Model
{
    public class Utilizador
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataUltimoLogin { get; set; }
        public string Email { get; set; }
    }
}
