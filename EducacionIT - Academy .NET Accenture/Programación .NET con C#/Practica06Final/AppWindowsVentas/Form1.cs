using Negocio.Admin;
using BO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindowsVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerTodosVendedores_Click(object sender, EventArgs e)
        {
            MostrarVendedores();
        }

        private void MostrarVendedores()
        {
            dataGridView1.DataSource = AdminVendedor.traerTodos();
        }

        private void btnAgregarVendedor_Click(object sender, EventArgs e)
        {
            Vendedor nuevo = new Vendedor( 1, "John", "Doe", "27246391", "Alem 221", "223-63353542", "john42@gmail.com", Convert.ToDecimal( 5.27) );

            int filas = AdminVendedor.Agregar(nuevo);

            MostrarVendedores();

        }

        private void btnTraerClientes_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            dataGridView1.DataSource = AdminCliente.traerTodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente(1, "Jean", "Jennings", "21846575", "Brown 3221", "223-53525886", "jeanj@gmail.com");

            int filas = AdminCliente.Agregar(nuevo);

            MostrarClientes();
        }

        private void btnTraerEmpresas_Click(object sender, EventArgs e)
        {
            MostrarEmpresas();
        }

        private void MostrarEmpresas()
        {
            dataGridView1.DataSource = AdminEmpresa.traerTodos();
        }

        private void btnAgregarEmpresa_Click(object sender, EventArgs e)
        {
            Empresa nueva = new Empresa(1, "Microsoft", "25-242515-8", "9th Street", "1-5555-11", "support@microsoft.com");

            int filas = AdminEmpresa.Agregar(nueva);

            MostrarEmpresas();


        }
    }
}
