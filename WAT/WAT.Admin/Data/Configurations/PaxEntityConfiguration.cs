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
            Property(x => x.FirstName).HasMaxLength(150);
        }
    }
}