﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Domain.Entities
{
    public class WreckReport
    {
        [Key]
        public int IdWReport { get; set; }

        public double WreckValue { get; set; }

        public double Indemnity { get; set; }

        
        public int? IdVehicle { get; set; }

        [ForeignKey("IdVehicle ")]
        public virtual Vehicle Vehicle { get; set; }
    }
}
