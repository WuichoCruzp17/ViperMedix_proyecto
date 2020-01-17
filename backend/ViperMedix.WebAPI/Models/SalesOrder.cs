using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class SalesOrder
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field UserId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field UserId must be a number.")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "The field PharmacyBranchId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field PharmacyBranchId must be a number.")]
        public int PharmacyBranchId { get; set; }

        [StringLength(256, ErrorMessage = "The field EmployeeName must have max length of 256 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field EmployeeName must be a string")]
        public String EmployeeName { get; set; }

        [StringLength(256, ErrorMessage = "The field CustomerName must have max length of 256 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field CustomerName must be a string")]
        public String CustomerName { get; set; }

        [Required(ErrorMessage = "The field OrderDate is required")]
        [DataType(DataType.DateTime, ErrorMessage = "The field OrderDate must be a DateTime")]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "The field OrderState is required")]
        public Boolean OrderState { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "The field ReturnOrderDate must be a DateTime")]
        public DateTime? ReturnOrderDate { get; set; }

        [Required(ErrorMessage = "The field ItemsQuantity is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field ItemsQuantity must be a number.")]
        public int ItemsQuantity { get; set; }

        [Required(ErrorMessage = "The field PurchaseTotal is required")]
        [Column(TypeName = "decimal(18,2)")]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99, ErrorMessage = "The field PurchaseTotal must be a decimal number.")]
        public Decimal PurchaseTotal { get; set; }

        [Required(ErrorMessage = "The field IVA is required")]
        [Column(TypeName = "decimal(18,2)")]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99, ErrorMessage = "The field IVA must be a decimal number.")]
        public Decimal IVA { get; set; }

        public virtual User User { get; set; }
        public virtual PharmacyBranch PharmacyBranch { get; set; }

        public virtual ICollection<SalesOrderDetails> SalesOrderDetails { get; set; }
    }
}