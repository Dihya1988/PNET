using P.Data.Conventions;
using P.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Data
{
   // [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]

    public class ContextPi: DbContext
    {
        public ContextPi():base("name=BibDB")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Warranty> Warranties { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<WreckReport> WReports { get; set; }
        public DbSet<Sinister> Sinisters { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<FiscalPower> FiscalPowers { get; set; }

      //  protected override void OnModelCreating(DbModelBuilder modelBuilder)
      //  {
      //      modelBuilder.Conventions.Add(new DateTime2Convention());
     //   }
    }
}
