using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field Name is required")]
        [StringLength(40, ErrorMessage = "The field Name must have max length of 40 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Name must be a string")]
        public String DepartmentName { get; set; }

        [Required(ErrorMessage = "The field Hierarchy is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field Hierarchy must be a number.")]
        public int Hierarchy { get; set; }

        public virtual ICollection<JobTitle> JobTitles { get; set; }
    }
}