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
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            if (length > 0)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                return new string(Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)]).ToArray());

            }
            else return "";
        }
        public static int getNumFromString(string txt)
        {
            try
            {
                String pattern = @"[0-9]+";
                Regex rg = new Regex(pattern);
                MatchCollection matchedNums = rg.Matches(txt);
                int num = int.Parse(matchedNums[0].Value);
                return num;

            } catch
            {
                return 0;
            }
        }
        public static string getNumFromRandomString(string text)
        {
            try
            {
                string pattern_random = "";
                string pattern_letter = "";
                pattern_letter = @"\[letter[0-9]+\]";
                pattern_random = @"\[random[0-9]+\]";
                Regex rg_random = new Regex(pattern_random);
                Regex rg_letter = new Regex(pattern_letter);
                MatchCollection matchedRandoms = rg_random.Matches(text);
                MatchCollection matchedLetters = rg_letter.Matches(text);
                for(int i = 0; i < matchedRandoms.Count; i++)
                {
                    string tmp_text = matchedRandoms[i].Value;
                    int n = getNumFromString(tmp_text);

                    text = text.Substring(0, matchedRandoms[i].Index) + RandomNumber(n) + text.Substring(matchedRandoms[i].Index+ tmp_text.Length);

                }

                for(int j = 0; j < matchedLetters.Count; j++)
                {
                    string tmp_text = matchedLetters[j].Value;
                    int n = getNumFromString(tmp_text);
                    text = text.Substring(0, matchedLetters[j].Index) + RandomString(n) + text.Substring(matchedLetters[j].Index + tmp_text.Length);
                }
                return text;
            }
            catch
            {
                Console.WriteLine("Exception????");
                return text;
            }
        }

        public static string RandomNumber(int length)
        {
            if (length > 0)
            {
                const string chars = "0123456789";
                return new string(Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)]).ToArray());

            }
            else return "";
        }

        public static bool SendEmail(string recipient, SMTPServer server, Message mail, out string Error)
        {
            string fromEmail = getNumFromRandomString(server.fromEmail);
            Console.WriteLine(fromEmail);
            if (!ToolsMethods.EmailIsValid(fromEmail) || !ToolsMethods.EmailIsValid(recipient))
            {
                Error = "Invaid Email Format.";
                return false;
            }
                
            MailMessage mm = new MailMessage(fromEmail, recipient);
            mm.From = new MailAddress(fromEmail, server.fromName);
            mm.Sender = new MailAddress(fromEmail, server.fromName);
            if (File.Exists(mail.Attachment))
            {
                Attachment attch = new Attachment(mail.Attachment);
                mm.Attachments.Add(attch);
            }
            string subject = "";
            string body = "";
            subject = getNumFromRandomString(mail.Subject);
            body = getNumFromRandomString(mail.MessageBody);

            mm.Subject = subject;
            //mm.Subject = mail.Subject;
           // mm.Body = mail.MessageBody;
            mm.Body = body;
            Console.WriteLine("Subject:"+subject);
            Console.WriteLine("Body:"+body);
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
