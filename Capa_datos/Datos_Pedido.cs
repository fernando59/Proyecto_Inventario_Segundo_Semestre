using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidades;
namespace Capa_datos
{
    public class Datos_Pedido
    {
        Conexion conexion = new Conexion();
        SqlCommand comando;
        SqlDataReader reader;

        //Insertar Producto
        public int Insertar_Pedido(Pedido pedido)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Insertar_Pedido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Fecha",pedido.Fecha);
            comando.Parameters.AddWithValue("@tipo_pago",pedido.Tipo_Pago);
            comando.Parameters.AddWithValue("@Id_proveedor2",pedido.Id_proveedor);
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }
        //Insertar DetallePedido
        public int Insertar_DetallePedido(Detalle_Pedido detalle_Pedido)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Insertar_DetallePedido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cantidad", detalle_Pedido.cantidad);
            comando.Parameters.AddWithValue("@Id_Productos3", detalle_Pedido.Id_Productos);
            comando.Parameters.AddWithValue("@Id_Detalle_Pedido", detalle_Pedido.Id_pedido);
            comando.Parameters.AddWithValue("@Precio", detalle_Pedido.precio);
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }
        //Obtener id
        public String Obtener_Id(Pedido pedido)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=Fernando\\SQLEXPRESS;Initial Catalog=Proyecto_Venta;Integrated Security=True");
                SqlDataAdapter adaptador;
                DataSet dataSet = new DataSet();
                conexion.Open();
                adaptador = new SqlDataAdapter("execute Obtener_IdPedido ", conexion);
                adaptador.Fill(dataSet, "Pedido");
                String Id_obtenido = dataSet.Tables[0].Rows[0]["Id_Pedido"].ToString();

                conexion.Close();
                return Id_obtenido;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Muestra el pedido
        /// </summary>
        /// <returns>Retorna lista de todos los pedidos</returns>
        public List<Mostrar_Pedido> Mostrar_Pedido()
        {

            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Mostrar_Pedido";
            comando.CommandType = CommandType.StoredProcedure;
            reader = comando.ExecuteReader();
            List<Mostrar_Pedido> lista = new List<Mostrar_Pedido>();
            while (reader.Read())
            {
                Mostrar_Pedido mostrar_Pedido = new Mostrar_Pedido();
                mostrar_Pedido.Id = reader.GetInt32(0);
                mostrar_Pedido.Nombre = reader.GetString(1);
                mostrar_Pedido.Apellido = reader.GetString(2);
                mostrar_Pedido.producto = reader.GetString(3);
                mostrar_Pedido.cantidad = reader.GetInt32(4);
                mostrar_Pedido.precio = reader.GetDecimal(5);
                mostrar_Pedido.total = reader.GetDecimal(6);
                mostrar_Pedido.Estado = reader.GetString(7);

                lista.Add(mostrar_Pedido);
            }
            reader.Close();
            conexion.Cerrar();
            return lista;
        }
        //Sumar stock
        public int Sumar_Stock(Detalle_Pedido detalle_Pedido)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Sumar_Stock";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Producto", detalle_Pedido.Id_Productos);
            comando.Parameters.AddWithValue("@Cantidad", detalle_Pedido.Stock);

            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }

    }
}
