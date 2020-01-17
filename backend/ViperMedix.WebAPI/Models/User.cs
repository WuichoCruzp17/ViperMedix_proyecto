using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field LoginID is required")]
        [StringLength(20, ErrorMessage = "The field LoginID must have max length of 20 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field LoginID must be a string")]
        public String LoginID { get; set; }

        [Required(ErrorMessage = "The field PasswordEncrypted is required")]
        [StringLength(256, ErrorMessage = "The field PasswordEncrypted must have max length of 256 characters")]
        [DataType(DataType.Password, ErrorMessage = "The field PasswordEncrypted must be a Password valid")]
        public String PasswordEncrypted { get; set; }

        [StringLength(100, ErrorMessage = "The field PasswordQuestion must have max length of 100 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field PasswordQuestion must be a string")]
        public String PasswordQuestion { get; set; }

        [StringLength(100, ErrorMessage = "The field PasswordAnswer must have max length of 100 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field PasswordAnswer must be a string")]
        public String PasswordAnswer { get; set; }

        [Required(ErrorMessage = "The field RoleId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field RoleId must be a number.")]
        public int RoleId { get; set; }

        [Required(ErrorMessage = "The field AccessFailedCount is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field AccessFailedCount must be a number.")]
        public int AccessFailedCount { get; set; }

        [Required(ErrorMessage = "The field IsWelcome is required")]
        public bool IsWelcome { get; set; }

        [Required(ErrorMessage = "The field IsActive is required")]
        public bool IsActive { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set; }

        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime LastModifiedAt { get; set; }

        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string LastModifiedBy { get; set; }

        public virtual Role Role { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<PharmacyMaster> PharmacyMasters { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}