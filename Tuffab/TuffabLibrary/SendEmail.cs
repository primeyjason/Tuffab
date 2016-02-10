using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using SendGrid.SmtpApi;
using SendGrid.Resources;
using System.Net.Mail;
using System.Configuration;

namespace TuffabLibrary
{
    public static class EmailProvider
    {

        public static bool Send(string recipient, string subject, string message, string senderEmail="noreply@tuffab.com.au", string sender="Tuffab")
        {

            try
            {
                var myMessage = new SendGrid.SendGridMessage();
                myMessage.AddTo(recipient);
                myMessage.From = new MailAddress(sender,senderEmail);
                myMessage.Subject = subject;
                myMessage.Text = message;

                var transportWeb = new SendGrid.Web("");
                transportWeb.DeliverAsync(myMessage).Wait();

            }
            catch(Exception ex)
            {
                throw ex; 
                return false; 
            }
            return true; 

        }

    }
}
