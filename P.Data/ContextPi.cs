using P.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Data
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]

    public class ContextPi: DbContext
    {
        public ContextPi():base("name=BibDB")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Warranty> Warranties { get; set; }


    }
}
