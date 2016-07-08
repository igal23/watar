using System.Data.Entity;
using WAT.Admin.Data.Configurations;
using WAT.Admin.Entities;

namespace WAT.Admin.Data
{
    public class WATContext : DbContext
    {
        public WATContext() : base("context")
        {
        }

        public DbSet<Pax> Paxes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PaxEntityConfiguration());
        }
    }
}