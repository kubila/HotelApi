using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Models
{
    public class CreateCountryDTO
    {

        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 30, ErrorMessage = "Country name is too long!")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Country short name is too long!")]
        public string ShortName { get; set; }
    }
}
