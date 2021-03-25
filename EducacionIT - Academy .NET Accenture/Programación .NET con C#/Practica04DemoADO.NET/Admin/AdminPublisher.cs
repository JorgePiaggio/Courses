using DemoADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoADO.NET.Models;
using DemoADO.NET.BaseDatos;

namespace DemoADO.NET.Admin
{
    public static class AdminPublisher
    {

        public static List<Publisher> Lista()
        {
            List<Publisher> lista = new List<Publisher>();

            // preparacion query sql

            string consulta = "SELECT [pub_id],[pub_name],[city],[state],[country] FROM[dbo].[publishers]";

            // comando 

            SqlCommand comando = new SqlCommand(consulta, AdminDB.conexion());

            // reader

            SqlDataReader reader = comando.ExecuteReader();

            // leer los datos

            while (reader.Read())
            {
                lista.Add(new Publisher(reader[0].ToString() ,reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()));
            }

            reader.Close();
             AdminDB.conexion().Close();

            return lista;
        }

        public static int Agregar(Publisher publisher)
        {

            // query insert
            string consulta = "INSERT INTO [dbo].[publishers]([pub_id],[pub_name],[city],[state],[country]) VALUES (@pub_id,@pub_name, @city,@state,@country)";

            // sqlcommand
            SqlCommand comando = new SqlCommand(consulta, AdminDB.conexion());

            // parametros
            comando.Parameters.Add("@pub_id", SqlDbType.Char, 4).Value=publisher.Pub_id;
            comando.Parameters.Add("@pub_name", SqlDbType.VarChar, 40).Value=publisher.Pub_name;
            comando.Parameters.Add("@city",SqlDbType.VarChar, 20).Value=publisher.City;
            comando.Parameters.Add("@state", SqlDbType.Char, 2).Value=publisher.State;
            comando.Parameters.Add("@country", SqlDbType.VarChar, 30).Value=publisher.Country;

            // ejecutar el comando para enviar los datos a db
            int fulasAfectadas = comando.ExecuteNonQuery();
            
            AdminDB.conexion().Close();

            return fulasAfectadas;
        }
    }
}
