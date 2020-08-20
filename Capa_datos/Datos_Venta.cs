using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidades;
namespace Capa_datos
{
    public class Datos_Venta
    {
        Conexion conexion = new Conexion();
        SqlCommand comando;
        SqlDataReader reader;
        //Listar p
        public List<Producto> Listar_Productos()
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Listar_Producto";
            comando.CommandType = CommandType.StoredProcedure;
            reader = comando.ExecuteReader();
            List<Producto> lista = new List<Producto>();
            while (reader.Read())
            {
                Producto producto = new Producto();
                producto.Id = reader.GetInt32(0);
                producto.Nombre = reader.GetString(1);
                //categoria.Descripcion = reader.GetString(2);
                lista.Add(producto);
            }
            reader.Close();
            conexion.Cerrar();
            return lista;
        }
        //Insertar Venta
        public int Insertar_Venta(Venta venta)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Insertar_Venta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Fecha", venta.Fecha);
            comando.Parameters.AddWithValue("@tipo_pago", venta.Tipo_Pago);
            comando.Parameters.AddWithValue("@Id_Cliente", venta.Id_cliente);
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }
        //Insertar DetalleVenta
        public int Insertar_DetalleVenta(Detalle_Venta detalle_Venta)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Insertar_DetalleVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cantidad", detalle_Venta.cantidad);
            comando.Parameters.AddWithValue("@Id_Productos3", detalle_Venta.Id_Productos);
            comando.Parameters.AddWithValue("@Id_Detalle_Venta", detalle_Venta.Id_Venta);
            comando.Parameters.AddWithValue("@Precio", detalle_Venta.precio);
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }
        //Obtener id
        public String Obtener_Id(Venta venta)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=Fernando\\SQLEXPRESS;Initial Catalog=Proyecto_Venta;Integrated Security=True");
                SqlDataAdapter adaptador;
                DataSet dataSet = new DataSet();
                conexion.Open();
                adaptador = new SqlDataAdapter("execute Obtener_IdVenta ", conexion);
                adaptador.Fill(dataSet, "Venta");
                String Id_obtenido = dataSet.Tables[0].Rows[0]["Id_Venta"].ToString();

                conexion.Close();
                return Id_obtenido;
            }
            catch
            {
                return null;
            }
        }
        public List<Mostrar_Venta> Mostrar_Venta(Venta venta)
        {

            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Mostrar_por_fechas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fecha",venta.Fecha);
            reader = comando.ExecuteReader();
            List<Mostrar_Venta> lista = new List<Mostrar_Venta>();
            while (reader.Read())
            {
                Mostrar_Venta mostrar_Venta = new Mostrar_Venta();
                mostrar_Venta.Id = reader.GetInt32(0);
                mostrar_Venta.Nombre = reader.GetString(1);
                mostrar_Venta.precio = reader.GetDecimal(2);
                mostrar_Venta.cantidad = reader.GetInt32(3);
                mostrar_Venta.cliente = reader.GetString(4);
                mostrar_Venta.Apellido = reader.GetString(5);
                mostrar_Venta.total = reader.GetDecimal(6);
                mostrar_Venta.Estado = reader.GetString(7);
                
                lista.Add(mostrar_Venta);
            }
            reader.Close();
            conexion.Cerrar();
            return lista;
        }
        //Mostrar Total
        public int Mostrar_Total_Venta()
        {

            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Mostrar_Total_Venta";
            comando.CommandType = CommandType.StoredProcedure;
            int mostrar = Convert.ToInt32(comando.ExecuteScalar());
            return mostrar;
        }
        //Restar stock
        public int Restar_Stock(Detalle_Venta detalle_Venta)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Restar_Stock";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Producto", detalle_Venta.Id_Productos);
            comando.Parameters.AddWithValue("@Cantidad", detalle_Venta.Stock);

            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }
        /// <summary>
        /// Suma el stock 
        /// </summary>
        /// <param name="detalle_Venta"></param>
        /// <returns>retorna la cantidad del stock</returns>
        public int Sumar_Stock(Detalle_Venta detalle_Venta)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Sumar_Stock";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Producto", detalle_Venta.Id_Productos);
            comando.Parameters.AddWithValue("@Cantidad", detalle_Venta.Stock);

            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }
    }
}