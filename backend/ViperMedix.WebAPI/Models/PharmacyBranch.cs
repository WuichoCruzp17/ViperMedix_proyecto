using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class PharmacyBranch
    {
                [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field PharmacyMasterId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field PharmacyMasterId must be a number.")]
        public int PharmacyMasterId { get; set; }

        [Required(ErrorMessage = "The field PharmacyBranchName is required")]
        [StringLength(256, ErrorMessage = "The field PharmacyBranchName must have max length of 256 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field PharmacyBranchName must be a string")]
        public String PharmacyBranchName { get; set; }

        [Required(ErrorMessage = "The field UniquePhysicalID is required")]
        [StringLength(100, ErrorMessage = "The field UniquePhysicalID must have max length of 100 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field UniquePhysicalID must be a string")]
        public String UniquePhysicalID { get; set; }

        [Required(ErrorMessage = "The field AddressId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field AddressId must be a number.")]
        public int AddressId { get; set; }

        [Required(ErrorMessage = "The field ResponsibleName is required")]
        [StringLength(100, ErrorMessage = "The field ResponsibleName must have max length of 100 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field ResponsibleName must be a string")]
        public String ResponsibleName { get; set; }

        [StringLength(20, ErrorMessage = "The field PhoneNumber must have max length of 10 characters")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "The field PhoneNumber must be a PhoneNumber valid")]
        public String PhoneNumber { get; set; }

        [Required(ErrorMessage = "The field IsActive is required")]
        public bool IsActive { get; set; }

        public byte[] Photo;

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

        public virtual PharmacyMaster PharmacyMaster { get; set; }
        public virtual Address Address { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<ProductListPriceHistory> ProductListPriceHistories { get; set; }
        public virtual ICollection<ProductLocation> ProductLocations { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<ProductExpiry> ProductExpiries { get; set; }
    }
}