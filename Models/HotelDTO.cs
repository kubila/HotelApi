using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Models
{
    public class HotelDTO
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Hotel name is too long!")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 200, ErrorMessage = "Address is too long!")]
        public string Address { get; set; }

        [Required]
        [Range(1,5)]
        public double Rating { get; set; }

     
        public int CountryId { get; set; }

   
    }
}
