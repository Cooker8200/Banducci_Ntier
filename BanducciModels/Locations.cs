using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanducciModels
{
    public class Locations
    {
        [Required]
        [Display(Name = "Store Number")]
        public int storeid { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string address { get; set; }
        [Required]
        [Display(Name = "City")]
        public string city { get; set; }
        [Required]
        [Display(Name = "State")]
        public string state { get; set; }
        [Required]
        [Display(Name = "Zip Code")]
        public int zipcode { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string phone { get; set; }
    }
}
