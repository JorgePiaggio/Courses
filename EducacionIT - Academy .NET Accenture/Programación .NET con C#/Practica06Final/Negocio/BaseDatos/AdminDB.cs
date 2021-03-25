using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.BaseDatos
{
    internal static class AdminDB
    {

        internal static SqlConnection conectarDB()
        {

            string cadena = @"Data Source=.\sqlexpress;Initial Catalog=DbVentas;Integrated Security=True";

            SqlConnection conexion = new SqlConnection(cadena);

            conexion.Open();

            return conexion;
        }
 


    }
}
