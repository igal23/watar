using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WAT.Admin.Entities
{
    [DataContract]
    public class Pax
    {
        public int PaxId { get; set; }

        [DataMember(Name ="apellido")]
        public string Apellido { get; set; }

        [DataMember(Name ="nombre")]
        public string Nombre { get; set; }

        [DataMember(Name ="email")]
        public string Email { get; set; }

        [DataMember(Name ="telefono")]
        public string Telefono { get; set; }

        [DataMember(Name ="fechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [DataMember(Name ="ciudad")]
        public int Ciudad { get; set; }

        [DataMember(Name ="universidad")]
        public int Universidad { get; set; }

        [DataMember(Name ="aceptaTerminos")]
        public bool AceptaTerminos { get; set; }
    }
}