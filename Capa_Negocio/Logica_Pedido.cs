using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_datos;
using Capa_Entidades;
namespace Capa_Negocio
{
    public class Logica_Pedido
    {
        Datos_Pedido datos_Pedido = new Datos_Pedido();
        //Insertar Pedido
        public int Insertar_Pedido(Pedido pedido)
        {
            return datos_Pedido.Insertar_Pedido(pedido);
        }
        //Insertar detalle Pedido
        public int Insertar_DetallePedido(Detalle_Pedido detalle_Pedido)
        {
            return datos_Pedido.Insertar_DetallePedido(detalle_Pedido);
        }
        //Obtener id venta
        public String Obtener_Pedido(Pedido pedido)
        {
            return datos_Pedido.Obtener_Id(pedido);
        }
        //Mostrar Pedido
        public List<Mostrar_Pedido> Mostrar_Pedido()
        {
            return datos_Pedido.Mostrar_Pedido();
        }
        //Sumar stock
        public int Sumar_Stock(Detalle_Pedido detalle_Pedido)
        {
            return datos_Pedido.Sumar_Stock(detalle_Pedido);
        }
    }
}
