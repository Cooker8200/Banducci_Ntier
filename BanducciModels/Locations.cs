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
            [Key]
            public int id { get; set; }
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
            //[Required]
            [Display(Name = "Phone Number")]
            public string phone { get; set; }
        
    }
    
    //new model information for update database
    public class LocationsTwo
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Store Name")]
        public string Name { get; set; }
        [Display(Name = "Natl. Store Number")]  
        public int StoreNumber { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

        public string City { get; set; }
        
        public string State { get; set; }
        
        public int ZipCode { get; set; }
    }
}
