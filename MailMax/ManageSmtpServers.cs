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
    public partial class ManageSmtpServers : Form
    {
        public ManageSmtpServers()
        {
            InitializeComponent();
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
        private void addNewMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBack frback = new FrmBack();
            frback.Show(this);
            FrmAddNewSMTP frm = new FrmAddNewSMTP(false, "", Servers);
            frm.ShowDialog();
            frback.Close();
            SMTPServer.SaveSMTPServers(Servers);
            ManageSmtpServers_Load(null, null);
        }
        List<SMTPServer> Servers = new List<SMTPServer>();
        private void ManageSmtpServers_Load(object sender, EventArgs e)
        {
            Servers = SMTPServer.LoadSMTPServers();
            lstServers.Items.Clear();
            foreach (var item in Servers)
            {
                ListViewItem it = new ListViewItem() { Text = item.name };
                lstServers.Items.Add(it);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void editThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstServers.SelectedItems.Count > 0)
            {
                FrmBack frback = new FrmBack();
                frback.Show(this);
                FrmAddNewSMTP frm = new FrmAddNewSMTP(true, Servers[lstServers.SelectedItems[0].Index].Id, Servers);
                frm.ShowDialog();
                frback.Close();
                SMTPServer.SaveSMTPServers(Servers);
                ManageSmtpServers_Load(null, null);
            }
            else
            {
                MessageBox.Show("Please select a server!!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteThisMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstServers.SelectedItems.Count > 0 && MessageBox.Show("Are you sure to delete this ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Servers.RemoveAt(lstServers.SelectedItems[0].Index);
                SMTPServer.SaveSMTPServers(Servers);
                ManageSmtpServers_Load(null, null);
            }
            else
            {
                if (lstServers.SelectedItems.Count == 0)
                    MessageBox.Show("Please select a server !!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
