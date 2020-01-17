using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class AddressType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field AddressTypeName is required")]
        [StringLength(40, ErrorMessage = "The field AddressTypeName must have max length of 40 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field AddressTypeName must be a string")]
        public String AddressTypeName { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<AddressSat> AddressesSAT { get; set; }
    }
}