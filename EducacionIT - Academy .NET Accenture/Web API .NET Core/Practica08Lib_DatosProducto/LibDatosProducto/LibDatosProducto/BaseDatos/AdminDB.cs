using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDatosProducto.BaseDatos
{
    internal static class AdminDB
    {

        internal static SqlConnection ConectarDB()
        {
            string cadena = Properties.Settings.Default.KeyDB;

            SqlConnection conexion = new SqlConnection(cadena);

            conexion.Open();

            return conexion;

        }

    }
}
