using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class Shift
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field ShiftName is required")]
        [StringLength(40, ErrorMessage = "The field ShiftName must have max length of 40 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field ShiftName must be a string")]
        public String ShiftName { get; set; }

        [Required(ErrorMessage = "The field StartTime is required")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "The field EndTime is required")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}