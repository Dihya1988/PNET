using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class Sinister
    {
        [Key]
        public int IdSinister { get; set; }

        public int? IdVehicle { get; set; }

        [ForeignKey("IdVehicle ")]
        public virtual Vehicle Vehicle { get; set; }
    }
}
