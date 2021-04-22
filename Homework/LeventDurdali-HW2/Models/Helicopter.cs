using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeventDurdali_HW2.Models
{
    public class Helicopter
    {
        public long HelicopterId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
    }
}
