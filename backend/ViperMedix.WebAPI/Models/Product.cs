using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [StringLength(21, ErrorMessage = "The field BarCode must have max length of 21 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field BarCode must be a string")]
        public String BarCode { get; set; }

        [StringLength(21, ErrorMessage = "The field AlternateCode must have max length of 21 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field AlternateCode must be a string")]
        public String AlternativeCode { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "The field ActiveSubstanceId must be a number.")]
        public int ActiveSubstanceId { get; set; }

        [StringLength(512, ErrorMessage = "The field Description must have max length of 512 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Description must be a string")]
        public String Description { get; set; }

        [StringLength(100, ErrorMessage = "The field Laboratory must have max length of 100 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Laboratory must be a string")]
        public String Laboratory { get; set; }

        [Required(ErrorMessage = "The field ProductSubCategoryId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field ProductSubCategoryId must be a number.")]
        public int ProductSubCategoryId { get; set; }

        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, 9999999999999999.99, ErrorMessage = "The field StandardCost must be a decimal number.")]
        public Decimal StandardCost { get; set; }

        [Required(ErrorMessage = "The field IsDiscontinued is required")]
        public Boolean IsDiscontinued { get; set; }

        [Required(ErrorMessage = "The field IsRecipe is required")]
        public Boolean IsRecipe { get; set; }

        [Required(ErrorMessage = "The field IsActive is required")]
        public Boolean IsActive { get; set; }

        [Required(ErrorMessage = "The field InvMin is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field InvMin must be a number.")]
        public int InvMin { get; set; }

        [Required(ErrorMessage = "The field InvMax is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field InvMax must be a number.")]
        public int InvMax { get; set; }

        [Required(ErrorMessage = "The field LastSupplierRefill is required")]
        [StringLength(256, ErrorMessage = "The field LastSupplierRefill must have max length of 256 characters")]
        public string LastSupplierRefill { get; set; }

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

        public virtual ActiveSubstance ActiveSubstance { get; set; }
        public virtual ProductSubCategory ProductSubCategory { get; set; }

        public virtual ICollection<ProductCostHistory> ProductCostHistories { get; set; }
        public virtual ICollection<ProductListPriceHistory> ProductListPriceHistories { get; set; }
        public virtual ICollection<SalesOrderDetails> SalesOrderDetails { get; set; }
        public virtual ICollection<ProductLocation> ProductLocations { get; set; }
        public virtual ICollection<ProductExpiry> ProductExpiries { get; set; }
    }
}