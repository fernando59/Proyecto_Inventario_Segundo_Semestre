using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;
using Capa_datos;
namespace Capa_Negocio
{
    public class Logica_Personas
    {
        Datos_Usuario datos_usuario = new Datos_Usuario();
  

        public String Validar_Usuario(Usuario usuario)
        {
            return datos_usuario.Verificar_Usuario(usuario);
        }
        public String Validar_Contrasena(Usuario usuario)
        {
            return datos_usuario.Verificar_Contraseña(usuario);
        }
        //Insertar Usuario
        public int Insertar_usuario(Usuario usuario)
        {
            return datos_usuario.Insertar_Usuario(usuario);
        }
        //Insertar PersonaCLiente
        public int Insertar_PersonaCliente(Cliente cliente)
        {
            return datos_usuario.Insertar_PersonaCliente(cliente);
        }
         //Modifcar Personacliente
        public int Modificar_PersonaCliente(Cliente cliente)
        {
            return datos_usuario.Modificar_PersonaCliente(cliente);
        }
        //Modifcar Cliente
        public int Modificar_Cliente(Cliente cliente)
        {
            return datos_usuario.Modficar_Cliente(cliente);
        }
        //Eliminar Cliente
        public int Eliminar_Cliente(Cliente cliente)
        {
            return datos_usuario.Eliminar_Cliente(cliente);
        }
        //Insertar CLiente
        public int Insertar_Cliente(Cliente cliente)
        {
            return datos_usuario.Insertar_Cliente(cliente);
        }
        //Modifcar Usuario
        public int Modificar_usuario(Usuario usuario)
        {
            return datos_usuario.Modificar_Usuario(usuario);
        }
        //Obtener id

        public String Obtener_id(Cliente cliente)
       {
                return datos_usuario.Obtener_Id(cliente);
       }

        //Mostrar Cliente
        public List<Cliente> Mostrar_cliente()
        {
            return datos_usuario.Mostrar_Clientes();
        }
        //Mostrar usuario
        public List<Usuario> Mostrar_Usuario()
        {
            return datos_usuario.Mostrar_Usuario();
        }

        //Insertar PersonaProveedor
        public int Insertar_PersonaProveedor(Proveedor proveedor)
        {
            return datos_usuario.Insertar_PersonaProvedor(proveedor);
        }
        //Insertar Proveedor
        public int Insertar_Proveedor(Proveedor proveedor)
        {
            return datos_usuario.Insertar_Proveedor(proveedor);
        }
        //Eliminar Proveedor
        public int Eliminar_Proveedor(Proveedor proveedor)
        {
            return datos_usuario.Eliminar_Proveedor(proveedor);
        }
        //Obtener id Proveedor

        public String Obtener_id_proveedor(Proveedor proveedor)
        {
            return datos_usuario.Obtener_Id_provedor(proveedor);
        }
        //Mostrar Proveedor
        public List<Proveedor> Mostrar_proveedor()
        {
            return datos_usuario.Mostrar_Proveedor();
        }
        //Modifcar PersonaProveedor
        public int Modificar_PersonaProveedor(Proveedor proveedor)
        {
            return datos_usuario.Modificar_PersonaProveedor(proveedor);
        }
        //Modifcar Proveedor
        public int Modificar_Proveedor(Proveedor proveedor)
        {
            return datos_usuario.Modficar_Proveedor(proveedor);
        }
    }
}
