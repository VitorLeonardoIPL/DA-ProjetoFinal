using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Model
{
    internal class AppDbInitializer : DropCreateDatabaseIfModelChanges<ProjetoDAContext>
    {
        protected override void Seed(ProjetoDAContext context)
        {

            // Adicionar primeiro utilizador padrão
            context.Utilizadores.Add(new Utilizador
            {
                Username = "admin",
                Email = "admin@ipl.pt",
                Password = "admin123",
                DataCriacao = DateTime.Now
            });
          
          
            // Chama o método base para finalizar


            base.Seed(context);
        }
    }
}
