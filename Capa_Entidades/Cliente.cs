using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Cliente:Persona
    {
        public override int Id { get; set; }
        public override string Nombre { get; set; }
        public override string Apellido { get; set; }
        public  string Direccion { get; set; }
        

    }
}
