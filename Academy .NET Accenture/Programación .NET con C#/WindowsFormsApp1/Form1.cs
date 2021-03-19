using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibSeguridad;
using BO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario()
            {
                Nombre = txtNombre.Text,
                Password = txtPassword.Text
            };

            // crear una instancia de la clase adminSeguridad
            AdminSeguridad objeto = new AdminSeguridad();

            bool resultado = objeto.autenticar(usuario);

            if (resultado)
            {
                MessageBox.Show("Bienvenido al sistema");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña inválidos");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
