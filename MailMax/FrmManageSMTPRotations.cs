using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailMax
{
    public partial class FrmManageSMTPRotations : Form
    {
        List<SMTPServer> servers = new List<SMTPServer>();
        string MainId = "";
        public FrmManageSMTPRotations(List<SMTPServer> ServersRoatation, string mainId)
        {
            InitializeComponent();
            servers = ServersRoatation;
            MainId = mainId;
        }
        private void lblHoverEffect_MouseHover(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.FromArgb(100, 45, 75, 109);
        }

        private void lblHoverEffect_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.Transparent;
        }

        private void lblHoverEffect_MouseMove(object sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.FromArgb(100, 45, 75, 109);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }
        List<SMTPServer> allServers = SMTPServer.LoadSMTPServers();
        private void FrmManageSMTPRotations_Load(object sender, EventArgs e)
        {
            foreach (var server in servers)
            {
                lstSeleServers.Items.Add(new ListViewItem() { Tag = server.Id, Text = server.name });
            }
            foreach (var server in allServers.Where(u => servers.Where(j => j.Id == u.Id).Count() == 0 && u.Id != MainId))
            {
                lstAllServers.Items.Add(new ListViewItem() { Tag = server.Id, Text = server.name });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstAllServers.SelectedItems.Count > 0)
            {
                servers.Add(allServers.Where(u => u.Id == lstAllServers.SelectedItems[0].Tag.ToString()).FirstOrDefault());
                lstSeleServers.Items.Add(new ListViewItem() { Tag = servers[servers.Count - 1].Id, Text = servers[servers.Count - 1].name });
                allServers.Remove(allServers.Where(u => u.Id == lstAllServers.SelectedItems[0].Tag.ToString()).FirstOrDefault());
                lstAllServers.SelectedItems[0].Remove();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstSeleServers.SelectedItems.Count > 0)
            {
                allServers.Add(servers.Where(u => u.Id == lstSeleServers.SelectedItems[0].Tag.ToString()).FirstOrDefault());
                lstAllServers.Items.Add(new ListViewItem() { Tag = servers[servers.Count - 1].Id, Text = servers[servers.Count - 1].name });
                servers.Remove(servers.Where(u => u.Id == lstSeleServers.SelectedItems[0].Tag.ToString()).FirstOrDefault());
                lstSeleServers.SelectedItems[0].Remove();
            }
        }

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
                Opacity += .1;
            else
                tmrShow.Enabled = false;
        }
    }
}
