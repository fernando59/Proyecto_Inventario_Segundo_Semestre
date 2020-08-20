using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Venta
    {
        public int Id_Venta { get; set; }
        public string Fecha { get; set; }
        public string Tipo_Pago { get; set; }
        public int Id_cliente { get; set; }



    }
}
