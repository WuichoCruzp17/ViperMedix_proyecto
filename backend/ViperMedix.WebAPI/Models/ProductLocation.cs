using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class ProductLocation
    {
         [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field ProductId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field ProductId must be a number.")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "The field PharmacyBranchId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field PharmacyBranchId must be a number.")]
        public int PharmacyBranchId { get; set; }

        [StringLength(100, ErrorMessage = "The field Location must have max length of 100 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Location must be a string")]
        public String Location { get; set; }

        public virtual Product Product { get; set; }
        public virtual PharmacyBranch PharmacyBranch { get; set; }
    }
}