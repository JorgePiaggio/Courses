using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica05RepasoADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            dataGridView1.DataSource = AdminCliente.Listar();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente(1, "John", "Doe", new DateTime(2000, 2, 3));
         
            int filas = AdminCliente.AgregarCliente(nuevo);
            
            MostrarClientes();

            }
        }
}
