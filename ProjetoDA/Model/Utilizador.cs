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

        public override string ToString()
        {
            return $"{Username,-30} {Email,-40} {DataCriacao:dd/MM/yyyy}";
        }
    }
}
