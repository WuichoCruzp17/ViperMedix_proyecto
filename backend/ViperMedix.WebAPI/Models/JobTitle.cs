using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class JobTitle
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field JobTitleName is required")]
        [StringLength(40, ErrorMessage = "The field JobTitleName must have max length of 40 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field JobTitleName must be a string")]
        public String JobTitleName { get; set; }

        [Required(ErrorMessage = "The field DepartmentId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field DepartmentId must be a number.")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}