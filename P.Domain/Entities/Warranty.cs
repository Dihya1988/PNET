using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
   public class Warranty
    {
        [Key]
        public int idWrr { get; set; }

        public ICollection<Warranty> Warranties { get; set; }
    }
}
