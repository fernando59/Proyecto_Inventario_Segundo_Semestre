using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Proveedor:Persona
    {

        public override int Id { get; set; }
        public override string Nombre { get; set; }
        public override string Apellido { get; set; }
        public string Correo { get; set; }
        public string producto { get; set; }

    }
}
