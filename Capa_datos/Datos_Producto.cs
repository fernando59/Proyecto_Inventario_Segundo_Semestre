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
    public class Datos_Producto
    {
        private SqlCommand comando;
        private SqlDataReader reader;
        private Conexion conexion = new Conexion();
       
        //Insertar Categoria
        public int Insertar_Categoria(Categoria_E categoria)
        {
            int resultado=0;
            if (categoria != null)
            {
                comando = new SqlCommand();
                comando.Connection = conexion.Abrir();
                comando.CommandText = "Insertar_Categoria";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre_Categoria", categoria.Nombre);
                comando.Parameters.AddWithValue("@detalle", categoria.Descripcion);
                resultado = comando.ExecuteNonQuery();
                conexion.Cerrar();
                
            }


            return resultado;
        }
        //Modificar categoria
        public int Modificar_Categoria(Categoria_E categoria)
        {
            int resultado = 0;
         
                comando = new SqlCommand();
                comando.Connection = conexion.Abrir();
                comando.CommandText = "Modificar_Categoria";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id",categoria.Id_categoria);
                comando.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                resultado = comando.ExecuteNonQuery();
                conexion.Cerrar();
            return resultado;
        }
        //Listar Categoria
        public List<Categoria_E> Listar_Categoria()
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Listar_Categoria";
            comando.CommandType = CommandType.StoredProcedure;
            reader = comando.ExecuteReader();
            List<Categoria_E> lista = new List<Categoria_E>();
            while (reader.Read())
            {
                Categoria_E categoria = new Categoria_E ();
                categoria.Id_categoria = reader.GetInt32(0);
                categoria.Nombre = reader.GetString(1);
                //categoria.Descripcion = reader.GetString(2);
                lista.Add(categoria);
            }
            reader.Close();
            conexion.Cerrar();
            return lista;
        }
        //Mostrar Producto
        public List<Producto> Mostrar_Producto()
        {

            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Mostrar_Producto";
            comando.CommandType = CommandType.StoredProcedure;
            reader = comando.ExecuteReader();
            List<Producto> lista = new List<Producto>();
            while (reader.Read())
            {
                Producto producto = new Producto();
                producto.Id = reader.GetInt32(0);
                producto.Nombre = reader.GetString(1);
                producto.Descripcion = reader.GetString(2);
                producto.precio = reader.GetDecimal(3);
                producto.Stock = reader.GetInt32(4);
                //producto.Id_categoria = reader.GetInt16(5);
                producto.Nombre_Categoria = reader.GetString(5);
                lista.Add(producto);
            }
            reader.Close();
            conexion.Cerrar();
            return lista;
        }
        //Insertar Producto
        public int Insertar_Producto(Producto producto)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Insertar_Producto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            comando.Parameters.AddWithValue("@Stock", producto.Stock);
            comando.Parameters.AddWithValue("@Precio_compra", producto.precio);
            comando.Parameters.AddWithValue("@Id_categorias", producto.Id_categoria);
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }
        //MOdificar Producto
        public int Modificar_Producto(Producto producto)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Modificar_Producto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            comando.Parameters.AddWithValue("@Stock", producto.Stock);
            comando.Parameters.AddWithValue("@Precio_compra", producto.precio);
            comando.Parameters.AddWithValue("@Id_categorias", producto.Id_categoria);
            comando.Parameters.AddWithValue("@Id", producto.Id);
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }
        //Mostrar categoria
        public List<Categoria_E> Mostrar_Categoria()
        {

            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Mostrar_Categoria";
            comando.CommandType = CommandType.StoredProcedure;
            reader = comando.ExecuteReader();
            List<Categoria_E> lista = new List<Categoria_E>();
            while (reader.Read())
            {
                Categoria_E categoria = new Categoria_E();
                categoria.Id_categoria = reader.GetInt32(0);
                categoria.Nombre = reader.GetString(1);
                categoria.Descripcion = reader.GetString(2);
                lista.Add(categoria);
            }
            reader.Close();
            conexion.Cerrar();
            return lista;
        }
        //Eliminar Categoria
        public int Eliminar_Categoria(Categoria_E categoria)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Eliminar_Categoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Categoria", categoria.Id_categoria);
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }
        //Buscar Producto
        public List<Producto> Buscar_Producto(Producto producto)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Buscar_Producto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Buscar", producto.Buscar);
            reader = comando.ExecuteReader();
            List<Producto> lista = new List<Producto>();
            while (reader.Read())
            {
                producto= new Producto();
                producto.Id = reader.GetInt32(0);
                producto.Nombre = reader.GetString(1);
                producto.Descripcion = reader.GetString(2);
                producto.precio = reader.GetDecimal(3);
                producto.Stock = reader.GetInt32(4);
                //producto.Id_categoria = reader.GetInt16(5);
                producto.Nombre_Categoria = reader.GetString(5);
                lista.Add(producto);
            }
            reader.Close();
            conexion.Cerrar();
            return lista;
        }
        //Buscar Categoria
        public List<Categoria_E> Buscar_Categoria(Categoria_E categoria)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Buscar_Categoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Buscar", categoria.Buscar);
            reader = comando.ExecuteReader();
            List<Categoria_E> lista = new List<Categoria_E>();
            while (reader.Read())
            {
                categoria = new Categoria_E();
                categoria.Id_categoria = reader.GetInt32(0);
                categoria.Nombre = reader.GetString(1);
                categoria.Descripcion = reader.GetString(2);
              
           
                lista.Add(categoria);
            }
            reader.Close();
            conexion.Cerrar();
            return lista;
        }
        //Eliminar Producto
        public int Eliminar_Producto(Producto producto)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Eliminar_Producto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Producto", producto.Id);
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }
        //Mostrar Total
        public int Mostrar_Total()
        {

            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Mostrar_Total";
            comando.CommandType = CommandType.StoredProcedure;
            int mostrar =Convert.ToInt32( comando.ExecuteScalar());
            return mostrar;
        }
        //Buscar ProductoCategoria
        //Buscar Producto
        public List<Producto> Buscar_ProductoCategoria(Producto producto)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Buscar_Producto_Categoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Buscar", producto.Buscar);
            reader = comando.ExecuteReader();
            List<Producto> lista = new List<Producto>();
            while (reader.Read())
            {
                producto = new Producto();
                producto.Id = reader.GetInt32(0);
                producto.Nombre = reader.GetString(1);
                producto.Descripcion = reader.GetString(2);
                producto.precio = reader.GetDecimal(3);
                producto.Stock = reader.GetInt32(4);
                //producto.Id_categoria = reader.GetInt16(5);
                producto.Nombre_Categoria = reader.GetString(5);
                lista.Add(producto);
            }
            reader.Close();
            conexion.Cerrar();
            return lista;
        }

    }
   
    
}
