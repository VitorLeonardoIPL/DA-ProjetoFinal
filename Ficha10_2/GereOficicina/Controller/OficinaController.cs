using GereOficicina.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace GereOficicina.Controller
{
    public class OficinaController
    {
        public void AdicionarCLiente(string nome, string nif)
        {
            if (nif.Count() != 9)
            {
                throw new InvalidOperationException("Nif invalido!");
            }

            using (OficinaContext context = new OficinaContext())
            {
                Cliente cliente = new Cliente();
                cliente.Nome = nome;
                cliente.Nif = nif;

                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }


        public void RemoverCliente(int id)
        {
            using (OficinaContext context = new OficinaContext())
            {
                Cliente cliente = context.Clientes.Where(c => c.Id == id).First();

                context.Clientes.Remove(cliente);
                context.SaveChanges() ;
            }
        }

    }
}