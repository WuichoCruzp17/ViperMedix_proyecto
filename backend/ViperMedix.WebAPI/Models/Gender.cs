using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field GenderName is required")]
        [StringLength(40, ErrorMessage = "The field GenderName must have max length of 40 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field GenderName must be a string")]
        public String GenderName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}