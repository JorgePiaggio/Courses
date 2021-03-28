using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEntityFramework.Data;
using WindowsEntityFramework.Repository;

namespace WindowsEntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarAuthors();
        }

        private void MostrarAuthors()
        {
            gridAuthors.DataSource = AuthorRepository.GetList();
        }

        private void btnBuscarCiudad_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            gridAuthors.DataSource = AuthorRepository.GetList(city);
        }

        private void btnBuscarAuthorId_Click(object sender, EventArgs e)
        {
            Author author = AuthorRepository.GetAuthor(txtAuthorId.Text);
            MessageBox.Show(author.au_fname + " " + author.au_lname);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Author author = new Author()
            {
                au_fname = "Juan",
                au_lname = "Perez",
                au_id = "22-1242-323",
                phone = "415-444-2122",
                contract = true
            };

           int  result = AuthorRepository.Create(author);
            MostrarAuthors();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Author author = new Author()
            {
                au_fname = "Juan Manuel",
                au_lname = "Perez",
                au_id = "22-1242-323",
                phone = "415-333-2117",
                contract = true
            };

            int result = AuthorRepository.Update(author);
            MostrarAuthors();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Author author = new Author()
            {
                au_fname = "Juan Manuel",
                au_lname = "Perez",
                au_id = "22-1242-323",
                phone = "415-333-2117",
                contract = true
            };

            int result = AuthorRepository.Delete(author);
            MostrarAuthors();
        }
    }
}
