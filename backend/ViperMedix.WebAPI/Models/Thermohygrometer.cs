using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class Thermohygrometer
    {
        [Key]
        public int Id {get;set;}

        [Required(ErrorMessage = "The field Time is required")]
        [DataType(DataType.Time)]
        public DateTime Time {get;set;}

        [Required(ErrorMessage = "The field Temperature is required")]
        [Column(TypeName = "decimal(2,2)")]
        public Decimal Temperature {get;set;}

        [Required(ErrorMessage = "The field Humidity is required")]
        [Column(TypeName = "decimal(2,2)")]
        public Decimal Humidity {get;set;}
    }
}