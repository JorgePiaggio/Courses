using DemoADO.NET.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoADO.NET.Models;

namespace DemoADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // configurar objeto conexion

            string cadena = @"Data Source=.\sqlexpress;Initial Catalog=pubs;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena);


            // preparacion query sql

            string consulta = "SELECT [au_id],[au_lname],[au_fname],[phone],[address],[city],[state],[zip],[contract] FROM [dbo].[authors]";

            // comando 

            SqlCommand comando = new SqlCommand(consulta, conexion);

            // reader

            conexion.Open(); // abrir conexion a DB
            SqlDataReader reader = comando.ExecuteReader();

            // leer los datos

            while (reader.Read())
            {

                // opcion 1
                //   lstAutor.Items.Add(reader["au_lname"] + " " + reader["au_fname"]);

                // opcion 2
                lstAutor.Items.Add(reader[1] + " " + reader[2]);
            }

            reader.Close();
            conexion.Close();

        }

        private void btnPublicadores_Click(object sender, EventArgs e)
        {
            // configurar objeto conexion

            string cadena = @"Data Source=.\sqlexpress;Initial Catalog=pubs;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena);


            // preparacion query sql

            string consulta = "SELECT [pub_id],[pub_name],[city],[state],[country] FROM[dbo].[publishers]";

            // comando 

            SqlCommand comando = new SqlCommand(consulta, conexion);

            // reader

            conexion.Open(); // abrir conexion a DB
            SqlDataReader reader = comando.ExecuteReader();

            // leer los datos

            while (reader.Read())
            {
                lstPublicadores.Items.Add(reader[1] + " - " + reader[2] + ", " + reader[4]);
            }

            reader.Close();
            conexion.Close();
        }

        private void btnTraerTodosPublishers_Click(object sender, EventArgs e)
        {
            MostrarPublishers();
        }

        private void MostrarPublishers()
        {
            dataGridPub.DataSource = AdminPublisher.Lista();
        }

        private void btnInsertarPublisher_Click(object sender, EventArgs e)
        {
            Publisher nuevo = new Publisher()
            {
                Pub_id = "9956",
                Pub_name = "John Doe",
                City = "La Plata",
                State = "BA",
                Country = "Argentina"
            };

            int filas = AdminPublisher.Agregar(nuevo);

            MostrarPublishers();

        }

        private void btnInsertarAutor_Click_1(object sender, EventArgs e)
        {
            Author nuevo = new Author()
            {
                Au_id = "9956",
                Au_lname = "Jean Doe",
                Au_fname = "Doo",
                Phone = "2453-123",
                Address = "Alem 22",
                City = "La Plata",
                State = "BA",
                Zip = "6352",
                Contract = true
            };

            int filas = AdminAuthor.Agregar(nuevo);

            MostrarPublishers();
        }
    }
}
