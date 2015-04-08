using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Nesjartun.Models;
using Nesjartun.Utility;

namespace Nesjartun.Contact
{
    public interface IContactService
    {
        void SendContactRequest(ContactModel request);
    }

    internal class ContactService : IContactService
    {
        public void SendContactRequest(ContactModel request)
        {
            var template = ResourceHelper.GetEmbeddedResource(
                Assembly.GetExecutingAssembly(),
                "Nesjartun.Contact.ContactTemplate.html");

            var content = template
                .Replace("{name}", request.Name)
                .Replace("{phone}", request.Phone)
                .Replace("{email}", request.Email)
                .Replace("{message}", request.Message);

            var mail = new MailMessage(
                "no-reply@nesjartun.no", 
                "post@nesjartun.no", 
                "Kontaktforespørsel fra: " + request.Name, 
                content)
            {
                IsBodyHtml = true
            };

            using (var client = new SmtpClient())
            {
                client.Send(mail);
            }
        }
    }
}
