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
   public  class Datos_Usuario
    {
        private SqlCommand comando;
        private SqlDataReader reader;
         private Conexion conexion = new Conexion();
        //Insertar Usuario
        
        public int Insertar_Usuario(Usuario usuario)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Insertar_Usuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario", usuario.usuario);
            comando.Parameters.AddWithValue("@Contrasena", usuario.contrasena);
            comando.Parameters.AddWithValue("@Email", usuario.email);
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }
        //Insertar Usuario

        public int Modificar_Usuario(Usuario usuario)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Modificar_Usuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", usuario.id);
            comando.Parameters.AddWithValue("@Usuario", usuario.usuario);
            comando.Parameters.AddWithValue("@Contrasena", usuario.contrasena);
            comando.Parameters.AddWithValue("@Email", usuario.email);
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }
        //Mostrar Usuarios
        public List<Usuario> Mostrar_Usuario()
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Mostrar_Usuario";
            comando.CommandType = CommandType.StoredProcedure;
            reader = comando.ExecuteReader();
            List<Usuario> lista = new List<Usuario>();
            while (reader.Read())
            {
                Usuario usuario = new Usuario();
                usuario.id = reader.GetInt32(0);
                usuario.usuario = reader.GetString(1);
                usuario.contrasena = reader.GetString(2);
                usuario.email = reader.GetString(3);
                lista.Add(usuario);
            }
            reader.Close();
            conexion.Cerrar();
            return lista;
        }
        public String Verificar_Usuario(Usuario usuario)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=Fernando\\SQLEXPRESS;Initial Catalog=Proyecto_Venta;Integrated Security=True");
                SqlDataAdapter adaptador;
                DataSet dataSet = new DataSet();
                conexion.Open();
                adaptador = new SqlDataAdapter("execute Verificar_Usuario " + usuario.usuario, conexion);
                adaptador.Fill(dataSet, "Login_Venta");
                String usuariovalido = dataSet.Tables[0].Rows[0]["Usuario"].ToString();
                conexion.Close();
                return usuariovalido;
            }
            catch (Exception)
            {
                return null;
            }
           
        }
        public String Verificar_Contraseña(Capa_Entidades.Usuario usuario)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=Fernando\\SQLEXPRESS;Initial Catalog=Proyecto_Venta;Integrated Security=True");
                SqlDataAdapter adaptador;
                DataSet dataSet = new DataSet();
                conexion.Open();
                adaptador = new SqlDataAdapter("execute Verificar_Contrasena " + usuario.contrasena, conexion);
                adaptador.Fill(dataSet, "Login_Venta");
                String usuariovalido = dataSet.Tables[0].Rows[0]["Contrasena"].ToString();

                conexion.Close();
                return usuariovalido;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //Insertar cliente
        public int Insertar_PersonaCliente(Cliente cliente)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Insertar_PersonaCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }
        //Insertar cliente 2
        public int Insertar_Cliente(Cliente cliente)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Insertar_Cliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_persona", cliente.Id);
            comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;

        }
        //Modificar Personacliente
        public int Modificar_PersonaCliente(Cliente cliente)
        {
            int resultado = 0;

            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Modificar_PersonaCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", cliente.Id);
            comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }
        //Modificar Cliente
        public int Modficar_Cliente(Cliente cliente)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Modificar_Cliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", cliente.Id);
            comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;

        }
        //Eliminar cliente 2
        public int Eliminar_Cliente(Cliente cliente)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Eliminar_Cliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", cliente.Id);
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;

        }
        //Obtener Id
        public String Obtener_Id(Capa_Entidades.Cliente cliente)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=Fernando\\SQLEXPRESS;Initial Catalog=Proyecto_Venta;Integrated Security=True");
                SqlDataAdapter adaptador;
                DataSet dataSet = new DataSet();
                conexion.Open();
                adaptador = new SqlDataAdapter("execute Obtener_Id ", conexion);
                adaptador.Fill(dataSet, "Persona");
                String Id_obtenido = dataSet.Tables[0].Rows[0]["Id_persona"].ToString();

                conexion.Close();
                return Id_obtenido;
            }
            catch 
            {
                return null;
            }
        }
        //Mostrar Clientes
        public List<Cliente> Mostrar_Clientes()
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Mostrar_Clientes";
            comando.CommandType = CommandType.StoredProcedure;
            reader = comando.ExecuteReader();
            List<Cliente> lista = new List<Cliente>();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = reader.GetInt32(0);
                cliente.Nombre = reader.GetString(1);
                cliente.Apellido = reader.GetString(2);
                cliente.Telefono = reader.GetString(3);
                cliente.Direccion = reader.GetString(4);
                lista.Add(cliente);
            }
            reader.Close();
            conexion.Cerrar();
            return lista;
        }
        //Insertar Proveedor
        public int Insertar_PersonaProvedor(Proveedor proveedor)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Insertar_PersonaProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
            comando.Parameters.AddWithValue("@Apellido", proveedor.Apellido);
            comando.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }
        //Insertar Proveedor
        public int Insertar_Proveedor(Proveedor proveedor)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Insertar_Proveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_persona", proveedor.Id);
            comando.Parameters.AddWithValue("@Correo", proveedor.Correo);
            comando.Parameters.AddWithValue("@producto", proveedor.producto);
            
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;
        }
        //Elimnar Proveedor
        public int Eliminar_Proveedor(Proveedor proveedor)
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Eliminar_Proveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", proveedor.Id);
            int resultado = comando.ExecuteNonQuery();
            conexion.Cerrar();
            return resultado;

        }

        //Modificar PersonaProveedor
        public int Modificar_PersonaProveedor(Proveedor proveedor)
    {
        int resultado = 0;

        comando = new SqlCommand();
        comando.Connection = conexion.Abrir();
        comando.CommandText = "Modificar_PersonaCliente";
        comando.CommandType = CommandType.StoredProcedure;
        comando.Parameters.AddWithValue("@Id",       proveedor.Id);
        comando.Parameters.AddWithValue("@Nombre",   proveedor.Nombre);
        comando.Parameters.AddWithValue("@Apellido", proveedor.Apellido);
        comando.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
        resultado = comando.ExecuteNonQuery();
        conexion.Cerrar();
        return resultado;
    }
    //Modificar Proveedor
    public int Modficar_Proveedor(Proveedor proveedor)
    {
        comando = new SqlCommand();
        comando.Connection = conexion.Abrir();
        comando.CommandText = "Modificar_Proveedor";
        comando.CommandType = CommandType.StoredProcedure;
        comando.Parameters.AddWithValue("@Id", proveedor.Id);
        comando.Parameters.AddWithValue("@Correo", proveedor.Correo);
        comando.Parameters.AddWithValue("@Producto", proveedor.producto);
            int resultado = comando.ExecuteNonQuery();
        conexion.Cerrar();
        return resultado;

    }
    //Obtener IdProveedor
    public String Obtener_Id_provedor(Proveedor proveedor)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=Fernando\\SQLEXPRESS;Initial Catalog=Proyecto_Venta;Integrated Security=True");
                SqlDataAdapter adaptador;
                DataSet dataSet = new DataSet();
                conexion.Open();
                adaptador = new SqlDataAdapter("execute Obtener_Id ", conexion);
                adaptador.Fill(dataSet, "Persona");
                String Id_obtenido = dataSet.Tables[0].Rows[0]["Id_persona"].ToString();

                conexion.Close();
                return Id_obtenido;
            }
            catch
            {
                return null;
            }
        }
        //Mostrar Proveedor
        public List<Proveedor> Mostrar_Proveedor()
        {
            comando = new SqlCommand();
            comando.Connection = conexion.Abrir();
            comando.CommandText = "Mostrar_Proveedor";
            comando.CommandType = CommandType.StoredProcedure;
            reader = comando.ExecuteReader();
            List<Proveedor> lista = new List<Proveedor>();
            while (reader.Read())
            {
                Proveedor proveedor = new Proveedor();
                proveedor.Id = reader.GetInt32(0);
                proveedor.Nombre = reader.GetString(1);
                proveedor.Apellido = reader.GetString(2);
                proveedor.Telefono = reader.GetString(3);
                proveedor.Correo = reader.GetString(4);
                proveedor.producto = reader.GetString(5);
                lista.Add(proveedor);
            }
            reader.Close();
            conexion.Cerrar();
            return lista;
        }
    }
}
