using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class RoadType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field RoadTypeName is required")]
        [StringLength(40, ErrorMessage = "The field RoadTypeName must have max length of 40 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field RoadTypeName must be a string")]
        public String RoadTypeName { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<AddressSat> AddressesSAT { get; set; }
    }
}