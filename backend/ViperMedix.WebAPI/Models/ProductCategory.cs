using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field ProductCategoryName is required")]
        [StringLength(256, ErrorMessage = "The field ProductCategoryName must have max length of 256 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field ProductCategoryName must be a string")]
        public String ProductCategoryName { get; set; }

        public virtual ICollection<ProductSubCategory> ProductSubCategories {get;set;}
    }
}