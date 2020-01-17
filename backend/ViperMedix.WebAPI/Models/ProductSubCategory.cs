using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class ProductSubCategory
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field ProductCategoryId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field ProductCategoryId must be a number.")]
        public int ProductCategoryId { get; set; }

        [Required(ErrorMessage = "The field ProductSubCategoryName is required")]
        [StringLength(256, ErrorMessage = "The field ProductSubCategoryName must have max length of 256 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field ProductSubCategoryName must be a string")]
        public String ProductSubCategoryName { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}