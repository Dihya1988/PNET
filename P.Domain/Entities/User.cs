using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
   public class User
    {
        [Key]
        public int IdUser { get; set; }

        public String Name { get; set; }

        public String Surname { get; set; }

        public ICollection<User> Users { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
