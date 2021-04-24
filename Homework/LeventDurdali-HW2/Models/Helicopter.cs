using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Helicopter Model with Required Validation
//Each Validation has a diffrent error Message to display
namespace LeventDurdali_HW2.Models
{
    public class Helicopter
    {
        [Required]
        public long HelicopterId { get; set; }

        [Required(ErrorMessage = "Please give a Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please give a Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please give a Category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Please give a Price")]
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
    }
}