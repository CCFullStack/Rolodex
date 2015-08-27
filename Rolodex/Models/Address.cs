using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rolodex.Models {
    public class Address {

        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [StringLength(2)]
        public string State { get; set; }

        [Required]
        [RegularExpression(@"^\d{5}$")]
        public string Zip { get; set; }
    }
}