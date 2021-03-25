using BO.Models;
using Negocio.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Admin
{
    public static class AdminVendedor
    {
        public static List<Vendedor> traerTodos()
        {
            List<Vendedor> vendedores = new List<Vendedor>();

            string consulta = "SELECT Id,Nombre,Apellido,DNI,Domicilio,Telefono,Email,Comision FROM dbo.Vendedor";

            SqlCommand comando = new SqlCommand(consulta, AdminDB.conectarDB());

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                vendedores.Add(new Vendedor((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), Convert.ToDecimal(reader[7]) ));
            }

            reader.Close();
            AdminDB.conectarDB().Close();

            return vendedores;
        }



        public static int Agregar(Vendedor nuevo)
        {
            string consulta = "INSERT INTO dbo.Vendedor (Nombre,Apellido,DNI,Domicilio,Telefono,Email,Comision) VALUES ( @nombre, @apellido, @dni, @domicilio, @telefono, @email, @comision)";

            SqlCommand comando = new SqlCommand(consulta, AdminDB.conectarDB());

            comando.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nuevo.Nombre;
            comando.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = nuevo.Apellido;
            comando.Parameters.Add("@dni", SqlDbType.VarChar, 11).Value = nuevo.Dni;
            comando.Parameters.Add("@domicilio", SqlDbType.VarChar, 50).Value = nuevo.Domicilio;
            comando.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = nuevo.Telefono;
            comando.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = nuevo.Email;
            comando.Parameters.Add("@comision", SqlDbType.Decimal, 18).Value = nuevo.Comision;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.conectarDB().Close();

            return filasAfectadas;
        }




    }
}
