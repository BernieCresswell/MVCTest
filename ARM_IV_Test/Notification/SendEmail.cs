using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ARM_IV_Test.Domain.Interfaces;
using System.Configuration;
using System.Net.Mail;
using System.Text;
namespace ARM_IV_Test.Notification
{
    public class SendEmail: INotification
    {
        public void SendNotification(ICustomerPricingQuery messageobject)
        {
            //code to send email
            try
            {
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                message.From = new MailAddress(ConfigurationManager.AppSettings["FromEmailAddress"].ToString());

                message.To.Add(new MailAddress(ConfigurationManager.AppSettings["ToEmailAddress"].ToString()));

                message.Subject = "Customer Pricing Enquiry";
                message.Body = BuildBody(messageobject);

                SmtpClient client = new SmtpClient();
                client.Send(message);


            }
            catch (Exception ex)
            {
                throw (new Exception("Mail send failed, although Pricing Query logged in database." + ex.InnerException));
            }



        }

        private string BuildBody(ICustomerPricingQuery messageobject)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("New Customer Pricing Enquiry From:");
            builder.AppendLine(messageobject.FirstName);
            builder.AppendLine(messageobject.LastName);
            builder.AppendLine(messageobject.Address1);
            builder.AppendLine(messageobject.City);
            builder.AppendLine(messageobject.Postcode);
            builder.AppendLine(messageobject.Country);

            builder.AppendLine("");

            builder.AppendLine("For Product Id(s):");

            foreach (var prodId in messageobject.Products)
            {
                builder.AppendLine(prodId.ToString());
            }


            return builder.ToString();
        }
    }
}