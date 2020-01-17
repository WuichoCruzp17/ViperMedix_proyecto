using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class MaritalStatus
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field MaritalStatusName is required")]
        [StringLength(40, ErrorMessage = "The field MaritalStatusName must have max length of 40 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field MaritalStatusName must be a string")]
        public String MaritalStatusName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}