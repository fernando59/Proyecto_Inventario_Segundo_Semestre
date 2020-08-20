using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;
using Capa_datos;
namespace Capa_Negocio
{
    public class Logica_Venta
    {
        Datos_Venta datos_Venta = new Datos_Venta();

        //Lista Producto
        public List<Producto> Listar_Productos()
        {
            return datos_Venta.Listar_Productos();
        }
        //Insertar Venta
        public int Insertar_Venta(Venta venta)
        {
            return datos_Venta.Insertar_Venta(venta);
        }
        //Insertar detalle Venta
        public int Insertar_DetalleVenta(Detalle_Venta detalle_Venta)
        {
            return datos_Venta.Insertar_DetalleVenta(detalle_Venta);
        }
        //Restar Venta
        public int Restar_Stock(Detalle_Venta detalle_Venta)
        {
            return datos_Venta.Restar_Stock(detalle_Venta);
        }
        //Obtener id venta
        public String Obtener_idVenta(Venta venta)
        {
            return datos_Venta.Obtener_Id(venta);
        }
        
        //Mostrar Total Venta
        public int Mostrar_Total_Venta()
        {
            return datos_Venta.Mostrar_Total_Venta();
        }
        //Mostrar Venta
        public List<Mostrar_Venta> Mostrar_Venta(Venta venta)
        {
            return datos_Venta.Mostrar_Venta(venta);
        }

    }
}
