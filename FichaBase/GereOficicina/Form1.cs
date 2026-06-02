using GereOficicina.Controller;
using GereOficicina.Model;
using GereOficicina.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GereOficicina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarClientes();
            return;

            using (OficinaContext context = new OficinaContext()) 
            {

                Cliente cliente = new Cliente();
                cliente.Nome = "Ola";
                cliente.Nif = "DB";

                // Adicionar ao context (memoria)
                context.Clientes.Add(cliente);

                Carro  novoCarro = new Carro();
                novoCarro.Matricula = "qwerty";
                novoCarro.Dono = cliente;

                // Adicionar ao context (memoria)
                context.Carros.Add(novoCarro);

                //commit para a DB
                context.SaveChanges();

            }
        }

        private void  AtualizarClientes()
        {
            listboxClientes.DataSource = null;
        
            using (OficinaContext context = new OficinaContext())
            {
                listboxClientes.DataSource = context.Clientes.ToList();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OficinaController controller = new OficinaController();
            try
            {      
                controller.AdicionarCLiente(textBoxNome.Text, textBoxNif.Text);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o cliente");
            }

          AtualizarClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = listboxClientes.SelectedItem as Cliente;
            if (clienteSelecionado == null)
            {
                MessageBox.Show("Selecionar cliente");
            }
            OficinaController controller = new OficinaController();
            controller.RemoverCliente(clienteSelecionado.Id);

            AtualizarClientes();
        }

        private void listboxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listboxClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cliente clienteSelecionado = listboxClientes.SelectedItem as Cliente;
            if (clienteSelecionado == null)
            {
                return;
            }

            Detalhes formDatalhes = new Detalhes(clienteSelecionado);
            this.Hide();
            formDatalhes.ShowDialog();
            this.Show();
        }
    }
}
