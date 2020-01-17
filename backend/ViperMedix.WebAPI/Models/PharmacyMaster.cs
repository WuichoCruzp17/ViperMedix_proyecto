using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class PharmacyMaster
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field FirstName is required")]
        [StringLength(50, ErrorMessage = "The field FirstName must have max length of 50 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field FirstName must be a string")]
        public String FirstName { get; set; }

        [StringLength(50, ErrorMessage = "The field MiddleName must have max length of 50 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field MiddleName must be a string")]
        public String MiddleName { get; set; }

        [Required(ErrorMessage = "The field LastName is required")]
        [StringLength(50, ErrorMessage = "The field LastName must have max length of 50 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field LastName must be a string")]
        public String LastName { get; set; }

        [StringLength(13, ErrorMessage = "The field WhatsApp must have max length of 13 characters")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "The field WhatsApp must be a PhoneNumber valid")]
        public String WhatsApp { get; set; }

        [Required(ErrorMessage = "The field EmailAddress is required")]
        [StringLength(50, ErrorMessage = "The field EmailAddress must have max length of 50 characters")]
        [DataType(DataType.EmailAddress, ErrorMessage = "The field EmailAddress must be a Email valid")]
        public String EmailAddress { get; set; }

        [StringLength(10, ErrorMessage = "The field Birthday must have max length of 10 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Birthday must be a Birthday balid")]
        public String Birthday { get; set; }

        [Required(ErrorMessage = "The field R.F.C. is required")]
        [StringLength(13, ErrorMessage = "The field R.F.C. must have max length of 13 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field R.F.C. must be a string")]
        public String RFC { get; set; }

        [Required(ErrorMessage = "The field FiscalName is required")]
        [StringLength(256, ErrorMessage = "The field FiscalName must have max length of 256 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field FiscalName must be a string")]
        public String FiscalName { get; set; }

        [Required(ErrorMessage = "The field PharmacyMasterName is required")]
        [StringLength(256, ErrorMessage = "The field PharmacyMasterName must have max length of 256 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field PharmacyMasterName must be a string")]
        public String PharmacyMasterName { get; set; }

        [StringLength(20, ErrorMessage = "The field BusinessPhoneNumber must have max length of 20 characters")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "The field BusinessPhoneNumber must be a PhoneNumber valid")]
        public String BusinessPhoneNumber { get; set; }

        [StringLength(50, ErrorMessage = "The field BusinessEmailAddress must have max length of 50 characters")]
        [DataType(DataType.EmailAddress, ErrorMessage = "The field BusinessEmailAddress must be a Email valid")]
        public String BusinessEmailAddress { get; set; }

        [Required(ErrorMessage = "The field PharmacyMasterKey is required")]
        [StringLength(30, ErrorMessage = "The field PharmacyMasterKey must have max length of 30 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field PharmacyMasterKey must be a string")]
        public String PharmacyMasterKey { get; set; }

        [Required(ErrorMessage = "The field AddressSATId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field AddressSATId must be a number.")]
        public int AddressSATId { get; set; }

        [Required(ErrorMessage = "The field UserId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field UserId must be a number.")]
        public int UserId { get; set; }

        public byte[] Logo { get; set; }

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

        public virtual AddressSat AddressSAT { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<PharmacyBranch> PharmacyBranches { get; set; }
    }
}