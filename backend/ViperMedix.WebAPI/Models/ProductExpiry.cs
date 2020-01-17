using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class ProductExpiry
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "The field LotNumber must have max length of 100 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field LotNumber must be a string")]
        public String LotNumber { get; set; }

        [Required(ErrorMessage = "The field DiscontinuedDate is required")]
        [DataType(DataType.Date)]
        public String DiscontinuedDate { get; set; }

        [Required(ErrorMessage = "The field ProductId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field ProductId must be a number.")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "The field PharmacyBranchId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field PharmacyBranchId must be a number.")]
        public int PharmacyBranchId { get; set; }

        public Product Product { get; set; }
        public PharmacyBranch PharmacyBranch { get; set; }
    }
}