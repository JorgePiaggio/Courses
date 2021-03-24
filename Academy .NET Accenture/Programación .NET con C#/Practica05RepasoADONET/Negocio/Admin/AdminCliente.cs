using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Negocio
{
    public static class AdminCliente
    {
        public static List <Cliente> Listar()
        {
            List<Cliente> clientes = new List<Cliente>();

            // query 

            string consulta = "SELECT [Id] ,[Nombre] ,[Apellido],[FechaNacimiento] FROM [dbo].[Cliente]";

            // comando

            SqlCommand comando = new SqlCommand(consulta, AdminDB.conectarDB());

            // lector

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                clientes.Add(new Cliente((int)reader[0], reader[1].ToString(), reader[2].ToString(), (DateTime)reader[3]));
            }

            reader.Close();
            AdminDB.conectarDB().Close();

            return clientes;

        }

        public static int AgregarCliente(Cliente cliente)
        {
            string consulta = "INSERT INTO [dbo].[Cliente] ([Id] ,[Nombre] ,[Apellido] ,[FechaNacimiento]) VALUES (@id, @name, @surname, @birthDate)";

            SqlCommand comando = new SqlCommand(consulta, AdminDB.conectarDB());

            comando.Parameters.Add("@id", SqlDbType.Int, 8).Value = cliente.Id;
            comando.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = cliente.Nombre;
            comando.Parameters.Add("@surname", SqlDbType.VarChar, 50).Value = cliente.Apellido;
            comando.Parameters.Add("@birthDate", SqlDbType.DateTime, 4).Value = cliente.FechaDeNacimiento;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.conectarDB().Close();

            return filasAfectadas;
        }





    }
}
