using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class Permission
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field RoleId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field RoleId must be a number.")]
        public int RoleId { get; set; }

        [Required(ErrorMessage = "The field ModuleId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field ModuleId must be a number.")]
        public int ModuleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual Module Module { get; set; }
    }
}