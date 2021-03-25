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
    public static class AdminEmpresa
    {
        public static List<Empresa> traerTodos()
        {
            List<Empresa> empresas = new List<Empresa>();

            string consulta = "SELECT Id,Nombre,Cuit,Domicilio,Telefono,Email FROM dbo.Empresa";

            SqlCommand comando = new SqlCommand(consulta, AdminDB.conectarDB());

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                empresas.Add(new Empresa((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString()));
            }

            reader.Close();
            AdminDB.conectarDB().Close();

            return empresas;
        }



        public static int Agregar(Empresa nueva)
        {
            string consulta = "INSERT INTO dbo.Empresa (Nombre, Cuit, Domicilio, Telefono, Email) VALUES ( @nombre, @cuit, @domicilio, @telefono, @email)";

            SqlCommand comando = new SqlCommand(consulta, AdminDB.conectarDB());

            comando.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nueva.Nombre;
            comando.Parameters.Add("@cuit", SqlDbType.VarChar, 50).Value = nueva.Cuit;
            comando.Parameters.Add("@domicilio", SqlDbType.VarChar, 50).Value = nueva.Domicilio;
            comando.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = nueva.Telefono;
            comando.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = nueva.Email;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.conectarDB().Close();

            return filasAfectadas;
        }
    }
}
