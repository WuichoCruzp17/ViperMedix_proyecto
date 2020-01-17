using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class ProductCostHistory
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field ProductId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field ProductId must be a number.")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "The field StandardCost is required")]
        [Column(TypeName = "decimal(18,2)")]
        public Decimal StantardCost { get; set; }

        [Required(ErrorMessage = "The field StartDate is required")]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public virtual Product Product { get; set; }
    }
}