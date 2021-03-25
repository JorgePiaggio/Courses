using DemoADO.NET.BaseDatos;
using DemoADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADO.NET.Admin
{
    public static class AdminAuthor
    {
        public static List<Author> Lista()
        {
            List<Author> lista = new List<Author>();

            // preparacion query sql

            string consulta = "SELECT [au_id],[au_lname],[au_fname],[phone],[address],[city],[state],[zip],[contract] FROM [dbo].[authors]";

            // comando 

            SqlCommand comando = new SqlCommand(consulta, AdminDB.conexion());

            // reader

            SqlDataReader reader = comando.ExecuteReader();

            // leer los datos

            while (reader.Read())
            {
                lista.Add(new Author(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), Convert.ToBoolean(reader[8])));
            }

            reader.Close();
            AdminDB.conexion().Close();

            return lista;
        }

        public static int Agregar(Author author)
        {

            // query insert
          /*  string consulta = "INSERT INTO [dbo].[publishers]([pub_id],[pub_name],[city],[state],[country]) VALUES (@pub_id,@pub_name, @city,@state,@country)";*/
            string consulta = "INSERT INTO [dbo].[authors]([au_id],[au_lname],[au_fname],[phone],[address],[city],[state],[zip],[contract]) VALUES (@au_id,@au_lname,@au_fname,@phone,@address,@city,@state,@zip,@contract)";
            // sqlcommand
            SqlCommand comando = new SqlCommand(consulta, AdminDB.conexion());

            // parametros
            comando.Parameters.Add("@au_id", SqlDbType.VarChar, 11).Value = author.Au_id;
            comando.Parameters.Add("@au_lname", SqlDbType.VarChar, 40).Value = author.Au_lname;
            comando.Parameters.Add("@au_fname", SqlDbType.VarChar, 20).Value = author.Au_fname;
            comando.Parameters.Add("@phone", SqlDbType.Char, 12).Value = author.Phone;
            comando.Parameters.Add("@address", SqlDbType.VarChar, 40).Value = author.Address;
            comando.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = author.City;
            comando.Parameters.Add("@state", SqlDbType.Char, 2).Value = author.State;
            comando.Parameters.Add("@zip", SqlDbType.Char, 5).Value = author.Zip;
            comando.Parameters.Add("@contract", SqlDbType.Bit, 1).Value = author.Contract;

            // ejecutar el comando para enviar los datos a db
            int fulasAfectadas = comando.ExecuteNonQuery();

            AdminDB.conexion().Close();

            return fulasAfectadas;
        }
    }
}
