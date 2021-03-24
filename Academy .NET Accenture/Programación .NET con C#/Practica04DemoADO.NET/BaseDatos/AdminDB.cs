using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DemoADO.NET.BaseDatos
{
    internal static class AdminDB
    {

        internal static SqlConnection conexion()
        {

            // configurar objeto conexion

            string cadena = @"Data Source=.\sqlexpress;Initial Catalog=pubs;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();    // envia objeto conexion ya abierto

            return conexion;
        }

    }
}
