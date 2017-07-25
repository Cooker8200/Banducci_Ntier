using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanducciModels
{
    public class DeleteViewModel : Locations
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name = "Store Number")]
        public int storeid { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string address { get; set; }
    }
}
