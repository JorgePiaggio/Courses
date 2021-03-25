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
    public static class AdminCliente
    {
        public static List<Cliente> traerTodos()
        {
            List<Cliente> clientes = new List<Cliente>();

            string consulta = "SELECT Id ,Nombre,Apellido,DNI,Domicilio,Telefono,Email FROM dbo.Cliente";

            SqlCommand comando = new SqlCommand(consulta, AdminDB.conectarDB());

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                clientes.Add(new Cliente((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() ));
            }

            reader.Close();
            AdminDB.conectarDB().Close();

            return clientes;
        }



        public static int Agregar(Cliente nuevo)
        {
            string consulta = "INSERT INTO dbo.Cliente (Nombre, Apellido, DNI, Domicilio, Telefono, Email) VALUES ( @nombre, @apellido, @dni, @domicilio, @telefono, @email)";

            SqlCommand comando = new SqlCommand(consulta, AdminDB.conectarDB());

            comando.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nuevo.Nombre;
            comando.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = nuevo.Apellido;
            comando.Parameters.Add("@dni", SqlDbType.VarChar, 11).Value = nuevo.Dni;
            comando.Parameters.Add("@domicilio", SqlDbType.VarChar, 50).Value = nuevo.Domicilio;
            comando.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = nuevo.Telefono;
            comando.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = nuevo.Email;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.conectarDB().Close();

            return filasAfectadas;
        }



        }
    }
