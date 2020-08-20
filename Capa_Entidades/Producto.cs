using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Producto
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal precio { get; set; }
        public int Stock { get; set; }
        public int Id_categoria { get; set; }
        public string Nombre_Categoria { get; set; }
        public string Buscar { get; set; }
    }
}
