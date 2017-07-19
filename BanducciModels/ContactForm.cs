using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanducciModels
{
    public class ContactForm
    {
        [Required]
        [Display(Name = "Your Name")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Your Email")]
        public string email { get; set; }
        [Required]
        [Display(Name = "Your Message")]
        public string message { get; set; }
    }
}
