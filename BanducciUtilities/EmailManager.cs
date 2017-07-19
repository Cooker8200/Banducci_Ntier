using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanducciModels;
using System.Net.Mail;
using System.Web.ModelBinding;
using System.Net;

namespace BanducciUtilities
{
    public class EmailManager
    {

        public void ContactUs(ContactForm model)
        {
            var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress("cooker8200@hotmail.com"));  
            message.From = new MailAddress("cooker8200@hotmail.com");  
            message.Subject = "Contact Message";
            message.Body = string.Format(body, model.name, model.email, model.message);
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "Cooker8200@hotmail.com",  // replace with valid value
                    Password = "MATTcook82189804"  // replace with valid value
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
