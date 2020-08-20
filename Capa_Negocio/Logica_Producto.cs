using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;
using Capa_datos;
namespace Capa_Negocio
{
    public class Logica_Producto
    {
        Datos_Producto datos_Producto = new Datos_Producto();
        public readonly StringBuilder stringBuilder = new StringBuilder();
        //Mostrar Productos
        public List<Producto> Mostrar_Producto()
        {
            return datos_Producto.Mostrar_Producto();
        }
        //Insertar categoria
        public int Insertar_Categorias(Categoria_E categoria)
        {
            if (Validar_Categoria(categoria))
            {
                return datos_Producto.Insertar_Categoria(categoria);
            }
            else
            {
                return datos_Producto.Insertar_Categoria(null);
            }
        }
        //Insertar producto
        public int Insertar_Producto(Producto producto)
        {
            return datos_Producto.Insertar_Producto(producto);
        }
        //Lista categoria
        public List<Categoria_E> Listar_Categoria()
        {
            return datos_Producto.Listar_Categoria();
        }
     
        //Mostrar Categoria
        public List<Categoria_E> Mostrar_Categoria ()
        {
            return datos_Producto.Mostrar_Categoria();
        }
        //Buscar producto
        public List<Producto> Buscar_Producto(Producto producto)
        {
            return datos_Producto.Buscar_Producto(producto);
        }
        //Buscar productoCategoria
        public List<Producto> Buscar_ProductoCategoria(Producto producto)
        {
            return datos_Producto.Buscar_ProductoCategoria(producto);
        }
        //Buscar Categoria
        public List<Categoria_E> Buscar_Categoria(Categoria_E categoria)
        {
            return datos_Producto.Buscar_Categoria(categoria);
        }
        //Insertar producto
        public int Eliminar_Producto(Producto producto)
        {
            return datos_Producto.Eliminar_Producto(producto);
        }
        //Insertar producto
        public int Modificar_Producto(Producto producto)
        {
            return datos_Producto.Modificar_Producto(producto);
        }
        //Modifcar categoria
        public int Modificar_Categoria(Categoria_E categoria)
        {
            return datos_Producto.Modificar_Categoria(categoria);
        }
        //Eliminar categoria
        public int Eliminar_Categoria(Categoria_E categoria)
        {
            return datos_Producto.Eliminar_Categoria(categoria);
        }
        //Mostrar Total
        public int Mostrar_Total()
        {
            return datos_Producto.Mostrar_Total();
        }
        //validar categoria
        public bool Validar_Categoria(Categoria_E categoria)
        {
            stringBuilder.Clear();
            if (string.IsNullOrEmpty(categoria.Descripcion)) stringBuilder.Append("El campo descripcion es obligatorio ");
            if (string.IsNullOrEmpty(categoria.Nombre)) stringBuilder.Append("El campo Nombre es obligatorio ");
            return stringBuilder.Length == 0;

        }
    }
}
