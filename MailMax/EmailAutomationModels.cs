using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailMax
{
    [Serializable]
    public class ReportModel
    {
        public string Email { get; set; }
        public bool Success { get; set; }
        public bool ExcludAfterVerification { get; set; }
        public string ErrorMessage { get; set; }
        public bool Passed { get; set; }
    }
    [Serializable]
    public class SMTPServer
    {
        public string Id { get; set; }
        public string name { get; set; }
        public string host { get; set; }
        public int port { get; set; }
        public bool ssl { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string fromEmail { get; set; }
        public string fromName { get; set; }
        public DateTime DateAdded { get; set; }
        public SMTPServer()
        {
            Id = "SMTPServer-" + DateTime.Now.Ticks.ToString() + "-" + DateTime.Now.Millisecond.ToString() + "-" + DateTime.Now.Second.ToString();
            DateAdded = DateTime.Now;
        }
        public static void SaveSMTPServers(List<SMTPServer> items)
        {
            string Path = Application.StartupPath + "\\SMTPServers.bin";
            BinaryFormatter binary = new BinaryFormatter();
            var stream = new FileStream(Path, FileMode.OpenOrCreate);
            binary.Serialize(stream, items);
            stream.Close();
        }
        public static List<SMTPServer> LoadSMTPServers()
        {
            List<SMTPServer> items = new List<SMTPServer>();
            string Path = Application.StartupPath + "\\SMTPServers.bin";
            if (!File.Exists(Path))
                return items;
            BinaryFormatter binary = new BinaryFormatter();
            var stream = new FileStream(Path, FileMode.Open);
            items = (List<SMTPServer>)binary.Deserialize(stream);
            stream.Close();
            return items;
        }
    }
    [Serializable]
    public class Source
    {
        public string Id { get; set; }
        public string name { get; set; }
        public List<string> Emails { get; set; }
        public DateTime DateAdded { get; set; }
        public Source()
        {
            Id = "Source-" + DateTime.Now.Ticks.ToString() + "-" + DateTime.Now.Millisecond.ToString() + "-" + DateTime.Now.Second.ToString();
            DateAdded = DateTime.Now;
        }
        public static void SaveSources(List<Source> items)
        {
            string Path = Application.StartupPath + "\\Sources.bin";
            BinaryFormatter binary = new BinaryFormatter();
            var stream = new FileStream(Path, FileMode.OpenOrCreate);
            binary.Serialize(stream, items);
            stream.Close();
        }
        public static List<Source> LoadSources()
        {
            List<Source> items = new List<Source>();
            string Path = Application.StartupPath + "\\Sources.bin";
            if (!File.Exists(Path))
                return items;
            BinaryFormatter binary = new BinaryFormatter();
            var stream = new FileStream(Path, FileMode.Open);
            items = (List<Source>)binary.Deserialize(stream);
            stream.Close();
            return items;
        }
    }
    [Serializable]
    public class Message
    {
        public string Id { get; set; }
        public string name { get; set; }
        public bool UseHTML { get; set; }
        public string MessageBody { get; set; }
        public DateTime DateAdded { get; set; }
        public string Attachment { get; set; }
        public string Subject { get; set; }
        public Message()
        {
            Id = "Message-" + DateTime.Now.Ticks.ToString() + "-" + DateTime.Now.Millisecond.ToString() + "-" + DateTime.Now.Second.ToString();
            DateAdded = DateTime.Now;
        }
        public static void SaveMessages(List<Message> items)
        {
            string Path = Application.StartupPath + "\\Messages.bin";
            BinaryFormatter binary = new BinaryFormatter();
            var stream = new FileStream(Path, FileMode.OpenOrCreate);
            binary.Serialize(stream, items);
            stream.Close();
        }
        public static List<Message> LoadMessages()
        {
            List<Message> items = new List<Message>();
            string Path = Application.StartupPath + "\\Messages.bin";
            if (!File.Exists(Path))
                return items;
            BinaryFormatter binary = new BinaryFormatter();
            var stream = new FileStream(Path, FileMode.Open);
            items = (List<Message>)binary.Deserialize(stream);
            stream.Close();
            return items;
        }
    }
    [Serializable]
    public class Campaign
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public int EmailSent { get; set; }
        public string State { get; set; }
        public Source Source { get; set; }
        public bool CancelSending { get; set; }
        public Message TheMessage { get; set; }
        public SMTPServer SMTPServer { get; set; }
        public List<ReportModel> Report { get; set; }
        public bool SMTPRotation { get; set; }
        public int SMTPRotationIntervall { get; set; }
        public List<SMTPServer> ServersRotation { get; set; }
        public bool IsRunning { get; set; }
        public Campaign()
        {
            Id = "Campaign-" + DateTime.Now.Ticks.ToString() + "-" + DateTime.Now.Millisecond.ToString() + "-" + DateTime.Now.Second.ToString();
            DateAdded = DateTime.Now;
        }
        public static void SaveCampaings(List<Campaign> Campaigns)
        {
            string Path = Application.StartupPath + "\\Campaigns.bin";
            BinaryFormatter binary = new BinaryFormatter();
            var stream = new FileStream(Path, FileMode.OpenOrCreate);
            binary.Serialize(stream, Campaigns);
            stream.Close();
        }
        public static List<Campaign> LoadCampaings()
        {
            List<Campaign> Campaigns = new List<Campaign>();
            string Path = Application.StartupPath + "\\Campaigns.bin";
            if (!File.Exists(Path))
                return Campaigns;
            BinaryFormatter binary = new BinaryFormatter();
            var stream = new FileStream(Path, FileMode.Open);
            Campaigns = (List<Campaign>)binary.Deserialize(stream);
            stream.Close();
            return Campaigns;
        }
    }
    [Serializable]
    class Settings
    {
        public int SecondsBetweenMessages { get; set; }
        public int SecondsAfterXMessages { get; set; }
        public int WaitAfterXMessages { get; set; }
        public bool EnableVerification { get; set; }

        public static void SaveChanges(Settings settings)
        {
            string path = Application.StartupPath + "\\settings.bin";
            BinaryFormatter bin = new BinaryFormatter();
            var stream = new FileStream(path, FileMode.OpenOrCreate);
            bin.Serialize(stream, settings);
            stream.Close();
        }
        public static Settings LoadSettings()
        {
            Settings item = new Settings() { EnableVerification=true, SecondsBetweenMessages = 1, WaitAfterXMessages = 3, SecondsAfterXMessages = 100 };
            string Path = Application.StartupPath + "\\settings.bin";
            if (!File.Exists(Path))
                return item;
            BinaryFormatter binary = new BinaryFormatter();
            var stream = new FileStream(Path, FileMode.Open);
            item = (Settings)binary.Deserialize(stream);
            stream.Close();
            return item;
        }
    }
}
