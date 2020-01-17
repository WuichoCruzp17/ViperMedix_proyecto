using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class SalesOrderDetails
    {
         [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field SalesOrderId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field SalesOrderId must be a number.")]
        public int SalesOrderId { get; set; }

        [Required(ErrorMessage = "The field ProductId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field ProductId must be a number.")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "The field Quantity is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field Quantity must be a number.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "The field PurchaseAmount is required")]
        [Column(TypeName = "decimal(18,2)")]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99, ErrorMessage = "The field PurchaseAmount must be a decimal number.")]
        public Decimal PurchaseAmount { get; set; }

        [Required(ErrorMessage = "The field IVA is required")]
        [Column(TypeName = "decimal(18,2)")]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99, ErrorMessage = "The field IVA must be a decimal number.")]
        public Decimal IVA { get; set; }

        [Required(ErrorMessage = "The field Discount is required")]
        [Column(TypeName = "decimal(18,2)")]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99, ErrorMessage = "The field Discount must be a decimal number.")]
        public Decimal Discount { get; set; }

        public virtual SalesOrder SalesOrder { get; set; }
        public virtual Product Product { get; set; }
    }
}