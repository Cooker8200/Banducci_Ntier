using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanducciModels;
using System.Net.Mail;
using System.Net;

namespace BanducciBusiness
{
    public class ContactManager
    {
        //Code not needed currently.  Email sends from manager now
        //public ContactManager()
        //{
        //    _sendForm = new EmailManager();
        //}
        private static void SendCompelte()
        {
            
        }
        //private EmailManager _sendForm;
        

        public void ContactForm (ContactForm model)
        {
            var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress("mcd_developer@outlook.com"));
            message.From = new MailAddress("mcd_developer@outlook.com");
            message.Subject = "Contact Message";
            message.Body = string.Format(body, model.name, model.email, model.message);
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "mcd_developer@outlook.com",  // replace with valid value
                    Password = "mcdDeveloper1234"  // replace with valid value
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp-mail.outlook.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(message);

            }
        }
    }
}
