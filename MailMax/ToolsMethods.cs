using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace MailMax
{
    public class LinksModel
    {
        public string Link { get; set; }
        public bool Mapped { get; set; }
    }
    public class SplitModel
    {
        public string Domain { get; set; }
        public List<string> Emails { get; set; }
    }
    public class ToolsMethods
    {
        public static bool SendEmail(string recipient, SMTPServer server, Message mail, out string Error)
        {
            if (!ToolsMethods.EmailIsValid(server.fromEmail) || !ToolsMethods.EmailIsValid(recipient))
            {
                Error = "Invaid Email Format.";
                return false;
            }
                
            MailMessage mm = new MailMessage(server.fromEmail, recipient);
            mm.From = new MailAddress(server.fromEmail, server.fromName);
            mm.Sender = new MailAddress(server.fromEmail, server.fromName);
            if (File.Exists(mail.Attachment))
            {
                Attachment attch = new Attachment(mail.Attachment);
                mm.Attachments.Add(attch);
            }
            mm.Subject = mail.Subject;
            mm.Body = mail.MessageBody;
            mm.IsBodyHtml = mail.UseHTML;
            SmtpClient client = new SmtpClient();
            client.Port = server.port;
            client.EnableSsl = server.ssl;
            client.Host = server.host;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(server.login, server.password);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            Error = "";
            try
            {
                client.Send(mm);
                //Thread.Sleep(150);
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                client.Dispose();
                return false;
                

                //Thread.Sleep(1000);
            }
            client.Dispose();
            return true;
        }

        public static string GetDate(DateTime Date)
        {
            string OutputDate = "";
            var d = (DateTime.Now - Date);
            if (d.Days == 0)
            {
                if (d.Hours == 0 && d.Minutes == 0)
                {
                    OutputDate = "Just now";
                }
                else if (d.Hours == 0 && d.Minutes > 0)
                {
                    OutputDate = (d.Minutes > 1 ? d.Minutes + " minutes ago" : d.Minutes + " minute ago");
                }
                else if (d.Hours > 0)
                {
                    OutputDate = (d.Hours > 1 ? d.Hours + " hours ago " : d.Hours + " hour ago");
                }


            }
            else if (d.Days > 0)
            {
                OutputDate = (d.Days > 1 ? d.Days + " days ago" : d.Days + " day ago");
            }
            return OutputDate;
        }


        public static string GetDomainFromEmail(string email)
        {
            return (email.Trim().Contains("@") ? email.Trim().Substring(email.Trim().IndexOf("@") + 1) : email).ToLower();
        }
        public static bool CheckDomain(string domain)
        {
            try
            {

                System.Net.IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(domain);
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("requested name is valid"))
                {
                    return true;
                }
                return false;

            }
        }
        public static bool EmailIsValid(string email)
        {
            string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email.Trim(), expression))
            {
                if (Regex.Replace(email, expression, string.Empty).Length == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
