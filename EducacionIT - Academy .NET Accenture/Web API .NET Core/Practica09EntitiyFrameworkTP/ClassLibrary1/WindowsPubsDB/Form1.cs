using ClassLibrary1.Data;
using ClassLibrary1.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPubsDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           MostrarAutores();
            MostrarPublishers();
        }
        private void btnInsertarAutor_Click(object sender, EventArgs e)
        {
            Author nuevo = new Author()
            {
                au_id = "222-17-9392",
                au_fname = "Manuel",
                au_lname = "Belgrano",
                phone = "552 242-6664",
                contract = true
            };
            AdminAuthor.Create(nuevo);
           MostrarAutores();
        }

        private void MostrarAutores()
        {
            gridPubs.DataSource = AdminAuthor.GetList();
        }

        private void btnModificarAutor_Click(object sender, EventArgs e)
        {
            Author nuevo = new Author()
            {
                au_id = "222-17-9392",
                au_fname = "Don Manuel",
                au_lname = "Belgrano",
                phone = "052 242-0064",
                contract = true
            };
            AdminAuthor.Update(nuevo);
           MostrarAutores();
        }

        private void btnEliminarAutor_Click(object sender, EventArgs e)
        {
            Author nuevo = new Author()
            {
                au_id = "222-17-9392",
                au_fname = "Don Manuel",
                au_lname = "Belgrano",
                phone = "052 242-0064",
                contract = true
            };
            AdminAuthor.Delete(nuevo);
            MostrarAutores();
        }

        private void btnCiudadAutor_Click(object sender, EventArgs e)
        {
            string city = txtCiudadAutor.Text;
            gridPubs.DataSource = AdminAuthor.GetList(city);
        }

        private void btnIdAutor_Click(object sender, EventArgs e)
        {
            Author au = AdminAuthor.GetAuthor(txtIdAutor.Text);
            MessageBox.Show(au.au_fname + " " + au.au_lname);
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            Publisher nuevo = new Publisher()
            {
                pub_id = "2221",
                pub_name = "Laos",
                city = "Bolivar",
                country = "Argentina",
                state = "BS"
            };
            AdminPublisher.Create(nuevo);
            MostrarPublishers();
        }

        private void MostrarPublishers()
        {
            gridPubs2.DataSource = AdminPublisher.GetList();
        }

        private void btnModificarPub_Click(object sender, EventArgs e)
        {
            Publisher nuevo = new Publisher()
            {
                pub_id = "2221",
                pub_name = "LaosCo",
                city = "Suarez",
                country = "Argentina",
                state = "BS"
            };
            AdminPublisher.Update(nuevo);
            MostrarPublishers();
        }

        private void btnEliminarPub_Click(object sender, EventArgs e)
        {
            Publisher nuevo = new Publisher()
            {
                pub_id = "2221",
                pub_name = "LaosCo",
                city = "Suarez",
                country = "Argentina",
                state = "BS"
            };
            AdminPublisher.Delete(nuevo);
            MostrarPublishers();
        }

        private void btnCiudadPub_Click(object sender, EventArgs e)
        {
            string city = txtCiudadPub.Text;
            gridPubs2.DataSource = AdminPublisher.GetList(city);
        }

        private void btnIdPub_Click(object sender, EventArgs e)
        {
            Publisher pub = AdminPublisher.GetPublisher(txtIdPub.Text);
            MessageBox.Show(pub.pub_name);
        }
    }
}
