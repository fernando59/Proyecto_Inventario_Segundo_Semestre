using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Capa_datos
{
   public class Conexion
    {
        static string cadena_conexion = "Data Source=Fernando\\SQLEXPRESS;Initial Catalog=Proyecto_Venta;Integrated Security=True";
        SqlConnection conexion = new SqlConnection(cadena_conexion);
        //Abrir
        public SqlConnection Abrir()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }
        //Cerrar
        public SqlConnection Cerrar()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
