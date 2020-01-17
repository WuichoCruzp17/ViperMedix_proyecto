using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field SupplierName is required")]
        [StringLength(256, ErrorMessage = "The field SupplierName must have max length of 256 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field SupplierName must be a string")]
        public String SupplierName { get; set; }

        [Required(ErrorMessage = "The field R.F.C. is required")]
        [StringLength(13, ErrorMessage = "The field R.F.C. must have max length of 13 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field R.F.C. must be a string")]
        public String RFC { get; set; }

        [Required(ErrorMessage = "The field SupplierKey is required")]
        [StringLength(30, ErrorMessage = "The field SupplierKey must have max length of 30 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field SupplierKey must be a string")]
        public String SupplierKey { get; set; }

        [Required(ErrorMessage = "The field AddressSATId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field AddressSATId must be a number.")]
        public int AddressSATId { get; set; }

        [StringLength(20, ErrorMessage = "The field PhoneNumber must have max length of 20 characters")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "The field PhoneNumber must be a PhoneNumber valid")]
        public String PhoneNumber { get; set; }

        [StringLength(13, ErrorMessage = "The field CellphoneNumber must have max length of 13 characters")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "The field CellphoneNumber must be a CellphoneNumber valid")]
        public String CellphoneNumber { get; set; }

        [StringLength(50, ErrorMessage = "The field EmailAddress must have max length of 50 characters")]
        [DataType(DataType.EmailAddress, ErrorMessage = "The field EmailAddress must be a Email valid")]
        public String EmailAddress { get; set; }

        [Required(ErrorMessage = "The field IsActive is required")]
        public bool IsActive { get; set; }

        public byte[] Logo { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set; }

        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime LastModifiedAt { get; set; }

        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string LastModifiedBy { get; set; }

        public virtual AddressSat AddressSAT { get; set; }
    }
}