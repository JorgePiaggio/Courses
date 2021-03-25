using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibDatosProducto.Models;
using LibDatosProducto.Repositorios;

namespace WebAppProducto
{
    public partial class ListarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            Producto nuevo = new Producto("Teclado", "Negro", (decimal)849.99);

            int resultado = AdminProducto.Agregar(nuevo); 
            
            Producto nuevo2 = new Producto("Mouse", "Azul", (decimal)399.49);

            int resultado2 = AdminProducto.Agregar(nuevo2);

            Producto nuevo3 = new Producto("Monitor", "Negro", (decimal)23599.15);

            int resultado3 = AdminProducto.Agregar(nuevo3);

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Producto modificado = new Producto(1,"Teclado Inalámbrico", "Negro", (decimal)849.99);

            int resultado = AdminProducto.Modificar(modificado);

            Producto modificado2 = new Producto(2, "Mouse", "Rojo", (decimal)399.49);

            int resultado2 = AdminProducto.Modificar(modificado2);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int resultado = AdminProducto.Eliminar(3);
        }

        protected void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            Categoria nueva = new Categoria("Hardware", "Componentes para armar una PC");
            Categoria nueva2 = new Categoria("Software", "Solo programas de Diseño");
            Categoria nueva3 = new Categoria("Software", "Solo programas de Ofimática");

            int resultado = AdminCategoria.Agregar(nueva);
            int resultado2 = AdminCategoria.Agregar(nueva2);
            int resultado3 = AdminCategoria.Agregar(nueva3);
        }

        protected void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            Categoria modificada = new Categoria(2, "Software", "Programas de Diseño y Ofimática");

            int filasAfectadas = AdminCategoria.Modificar(modificada);
        }

        protected void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            int resultado = AdminCategoria.Eliminar(3);
        }
    }
}