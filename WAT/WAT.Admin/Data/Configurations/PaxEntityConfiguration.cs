using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WAT.Admin.Entities;

namespace WAT.Admin.Data.Configurations
{
    public class PaxEntityConfiguration: EntityTypeConfiguration<Pax>
    {
        public PaxEntityConfiguration()
        {
            Property(x => x.Apellido).HasMaxLength(150).IsRequired();
            Property(x => x.Nombre).HasMaxLength(150).IsRequired();
            Property(x => x.Email).HasMaxLength(150).IsRequired();
            Property(x => x.Telefono).HasMaxLength(150).IsRequired();
            Property(x => x.FechaNacimiento).IsRequired();
            Property(x => x.Universidad).IsRequired();
            Property(x => x.Ciudad).IsRequired();
        }
    }
}