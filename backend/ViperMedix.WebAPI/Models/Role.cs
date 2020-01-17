using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field RoleName is required")]
        [StringLength(40, ErrorMessage = "The field RoleName must have max length of 40 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field RoleName must be a string")]
        public String RoleName { get; set; }

        [Required(ErrorMessage = "The field Description is required")]
        [StringLength(256, ErrorMessage = "The field Description must have max length of 100 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Description must be a string")]
        public String Description { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}