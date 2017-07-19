using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanducciUtilities;
using BanducciModels;

namespace BanducciBusiness
{
    public class Contact
    {
        public Contact()
        {
            _sendForm = new EmailManager();
        }

        private EmailManager _sendForm;

        public void ContactForm(ContactForm model)
        {
            _sendForm.ContactUs(model);
        }
    }
}
