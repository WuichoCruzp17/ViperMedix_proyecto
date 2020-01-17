using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace ViperMedix.WebAPI.Models
{
    public class ActiveSubstance
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field Substance is required")]
        [StringLength(512, ErrorMessage = "The field Substance must have max length of 512 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Substance must be a string")]
        public String Substance { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}