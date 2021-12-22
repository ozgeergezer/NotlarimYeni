using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Notlarim101.Common.Helperr
{
    public class MailHelper
    {
        public static bool SendMail(string body, string to, string subject, bool isHTML = true)
        {
            return SendMail(body, new List<string> { to }, subject, isHTML);
        }

        public static bool SendMail(string body, List<string> to, string subject, bool isHTML = true)
        {
            bool result = false;
            try
            {
                var message = new MailMessage();
                message.From = new MailAddress(ConfigHelper.Get<string>("MailUser"));
                to.ForEach(x =>
                {
                    message.To.Add(new MailAddress(x));
                });
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = isHTML;
                using (var smtp = new SmtpClient(
                    ConfigHelper.Get<string>("MailHost"),
                    ConfigHelper.Get<int>("MailPort")))
                {
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(ConfigHelper.Get<string>("MailUser"),
                        ConfigHelper.Get<string>("MailPass"));
                    smtp.Send(message);
                    result = true;

                }
            }
            catch (Exception e)
            {

                throw;
            }
            return result;
        }
    }
}
