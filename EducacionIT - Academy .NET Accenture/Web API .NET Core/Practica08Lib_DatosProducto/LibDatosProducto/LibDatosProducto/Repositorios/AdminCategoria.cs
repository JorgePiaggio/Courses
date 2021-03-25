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
    public static class AdminCategoria
    {
        private static SqlCommand comando;
        private static SqlDataReader reader;

        public static int Modificar(Categoria categoria)
        {
            string consulta = "UPDATE dbo.Categoria SET Nombre = @Nombre ,Descripcion = @Descripcion WHERE Id= @Id";

            comando = new SqlCommand(consulta, AdminDB.ConectarDB());

            comando.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar, 50).Value = categoria.Nombre;
            comando.Parameters.Add("@Descripcion", System.Data.SqlDbType.VarChar, 150).Value = categoria.Descripcion;
            comando.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = categoria.Id;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();

            return filasAfectadas;
        }

        public static int Eliminar(int pId)
        {
            string consulta = "DELETE FROM dbo.Categoria WHERE Id=@Id";

            comando = new SqlCommand(consulta, AdminDB.ConectarDB());

            comando.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = pId;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();

            return filasAfectadas;
        }
        public static List<Categoria> ListarPorColor(string color)
        {
            List<Categoria> categorias = new List<Categoria>();
            return categorias;
        }

        public static int Agregar(Categoria nuevo)
        {
            string consulta = "INSERT INTO dbo.Categoria (Nombre,Descripcion) VALUES (@Nombre, @Descripcion)";

            comando = new SqlCommand(consulta, AdminDB.ConectarDB());

            comando.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar, 50).Value = nuevo.Nombre;
            comando.Parameters.Add("@Descripcion", System.Data.SqlDbType.VarChar, 50).Value = nuevo.Descripcion;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.ConectarDB().Close();

            return filasAfectadas;
        }
    }
}
