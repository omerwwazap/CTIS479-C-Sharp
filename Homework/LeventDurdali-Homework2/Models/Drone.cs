using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeventDurdali_Homework2.Models
{
    public class Drone
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        //The NotMapped attribute can be applied to properties 
        //of an entity class for which 
        //we do not want to create corresponding columns in the database. 
        [NotMapped]
        public int Year { get; set; }

    }
}
