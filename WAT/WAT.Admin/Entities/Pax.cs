using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAT.Admin.Entities
{
    public class Pax
    {
        public int PaxId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Ciudad { get; set; }
        public int Universidad { get; set; }
        public bool AceptaTerminos { get; set; }
    }
}