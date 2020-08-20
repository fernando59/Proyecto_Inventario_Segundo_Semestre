using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Detalle_Pedido
    {
        public int Id_detallePedido { get; set; }
        public int Id_Productos { get; set; }
        public int Id_pedido { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal total { get; set; }
        public int Stock { get; set; }

    }
}
