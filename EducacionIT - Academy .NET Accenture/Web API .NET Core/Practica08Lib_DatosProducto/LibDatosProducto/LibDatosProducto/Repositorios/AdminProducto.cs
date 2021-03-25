using LibDatosProducto.BaseDatos;
using LibDatosProducto.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDatosProducto.Repositorios
{
    public static class AdminProducto
    {
        private static SqlCommand comando;
        private static SqlDataReader reader;

        public static int Modificar(Producto producto)
        {
            string consulta = "UPDATE [dbo].[Producto] SET Nombre = @Nombre ,Color = @Color ,Precio = @Precio WHERE Id= @Id";

            comando = new SqlCommand(consulta, AdminDB.ConectarDB());

            comando.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar, 50).Value = producto.Nombre;
            comando.Parameters.Add("@Color", System.Data.SqlDbType.VarChar, 50).Value = producto.Color;
            comando.Parameters.Add("@Precio", System.Data.SqlDbType.Money).Value = producto.Precio;
            comando.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = producto.Id;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();

            return filasAfectadas;
        }

        public static int Eliminar(int pId)
        {
            string consulta = "DELETE FROM dbo.Producto WHERE Id=@Id";

            comando = new SqlCommand(consulta, AdminDB.ConectarDB());

            comando.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = pId;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();

            return filasAfectadas;
        }
        public static List<Producto> ListarPorColor(string color)
        {


            List<Producto> productos = new List<Producto>();
            return productos;
        }

        public static int Agregar(Producto nuevo)
        {
            string consulta = "INSERT INTO dbo.Producto (Nombre,Color,Precio) VALUES (@Nombre, @Color, @Precio)";

            comando = new SqlCommand(consulta, AdminDB.ConectarDB());

            comando.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar, 50).Value = nuevo.Nombre;
            comando.Parameters.Add("@Color", System.Data.SqlDbType.VarChar, 50).Value = nuevo.Color;
            comando.Parameters.Add("@Precio", System.Data.SqlDbType.Money).Value = nuevo.Precio;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();

            return filasAfectadas;
        }


    }
}
