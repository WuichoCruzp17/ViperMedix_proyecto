using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViperMedix.WebAPI.Models
{
    public class AddressSat
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field ObjectKey is required")]
        [StringLength(17, ErrorMessage = "The field ObjectKey must have max length of 20 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field ObjectKey must be a string")]
        public String ObjectKey { get; set; }

        [Required(ErrorMessage = "The field RoadTypeId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field RoadTypeId must be a number.")]
        public int RoadTypeId { get; set; }

        [Required(ErrorMessage = "The field AddressTypeId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field AddressTypeId must be a number.")]
        public int AddressTypeId { get; set; }

        [Required(ErrorMessage = "The field Street is required")]
        [StringLength(20, ErrorMessage = "The field Street must have max length of 20 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Street must be a string")]
        public string Street { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "The field InteriorNumber must be a number")]
        public string No_Int { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "The field ExteriorNumber must be a number")]
        public string No_Ext { get; set; }

        [Required(ErrorMessage = "The field Colony is required")]
        [StringLength(40, ErrorMessage = "The field Colony must have max length of 40 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Colony must be a string")]
        public string Colony { get; set; }

        [Required(ErrorMessage = "The field StateProvinceId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field StateProvinceId must be a number.")]
        public int StateProvinceId { get; set; }

        [Required(ErrorMessage = "The field CityId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field CityId must be a number.")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "The field PostalCode is required")]
        [StringLength(5, ErrorMessage = "The field PostalCode must have max length of 5 characters")]
        [DataType(DataType.PostalCode, ErrorMessage = "The field PostalCode must be a Postal Code valid")]
        public String PostalCode { get; set; }

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

        public virtual RoadType RoadType { get; set; }
        public virtual AddressType AddressType { get; set; }
        public virtual StateProvince StateProvince { get; set; }
        public virtual City City { get; set; }

        public virtual ICollection<PharmacyMaster> PharmacyMasters { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}