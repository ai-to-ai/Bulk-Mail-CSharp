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
    public partial class FrmAddCampaign : Form
    {
        bool IsEdit = false;
        List<Campaign> Campaign = new List<Campaign>();
        string ID = "";
        public FrmAddCampaign(bool isEdit, string id, List<Campaign> Campaigns)
        {
            InitializeComponent();
            IsEdit = isEdit;
            ID = id;
            Campaign = Campaigns;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAddCampaign_Load(object sender, EventArgs e)
        {
            cmbMessage.DataSource = Message.LoadMessages();
            cmbMessage.DisplayMember = "name";
            cmbMessage.ValueMember = "Id";

            cmbSmtp.DataSource = SMTPServer.LoadSMTPServers();
            cmbSmtp.DisplayMember = "name";
            cmbSmtp.ValueMember = "Id";


            cmbSource.DataSource = Source.LoadSources();
            cmbSource.DisplayMember = "name";
            cmbSource.ValueMember = "Id";
            if (IsEdit)
            {

                var item = Campaign.Where(u => u.Id == ID).FirstOrDefault();
                if (item == null)
                {
                    MessageBox.Show("Invalid ID of campaing !!");
                    Close();
                }
                label5.Text = "Edit Campaign : " + item.Name;
                cmbSource.SelectedValue = item.Source.Id;
                cmbMessage.SelectedValue = item.TheMessage.Id;
                cmbSmtp.SelectedValue = item.SMTPServer.Id;
                txtName.Text = item.Name;
                SmtpRoatations = item.ServersRotation;
                chkSMTPRotation.Checked = item.SMTPRotation;
                numrotate.Value = (decimal)item.SMTPRotationIntervall;
                lblServers.Text = item.ServersRotation.Count.ToString() + " server(s)";

            }
        }
        List<SMTPServer> SmtpRoatations = new List<SMTPServer>();
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtName.TextLength == 0)
            {
                MessageBox.Show("Please enter a campaign name!!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (SmtpRoatations.Count == 0 && chkSMTPRotation.Checked)
            {
                MessageBox.Show("Since you enable the SMTP Servers Rotation option, please add at least one server to the list!!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsEdit)
            {
                var item = Campaign.Where(u => u.Id == ID).FirstOrDefault();
                if (item == null)
                {
                    MessageBox.Show("Invalid ID of campaign !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
                item.Name = txtName.Text;

                var smtp = SMTPServer.LoadSMTPServers().Where(u => u.Id == cmbSmtp.SelectedValue.ToString()).FirstOrDefault();
                if (smtp == null)
                {
                    MessageBox.Show("Invalid SMTP server !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                item.SMTPServer = smtp;

                var source = Source.LoadSources().Where(u => u.Id == cmbSource.SelectedValue.ToString()).FirstOrDefault();
                if (source == null)
                {
                    MessageBox.Show("Invalid Emails source!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                item.Source = source;

                var mail = Message.LoadMessages().Where(u => u.Id == cmbMessage.SelectedValue.ToString()).FirstOrDefault();
                if (mail == null)
                {
                    MessageBox.Show("Invalid mail message!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                item.TheMessage = mail;
                item.ServersRotation = SmtpRoatations;
                item.SMTPRotation = chkSMTPRotation.Checked;
                item.SMTPRotationIntervall = ((int)numrotate.Value);
                Close();
            }
            else
            {
                var item = new Campaign() { Report = new List<ReportModel>(), SMTPRotation = chkSMTPRotation.Checked, SMTPRotationIntervall = ((int)numrotate.Value), ServersRotation = SmtpRoatations };
                item.Name = txtName.Text;

                var smtp = SMTPServer.LoadSMTPServers().Where(u => u.Id == cmbSmtp.SelectedValue.ToString()).FirstOrDefault();
                if (smtp == null)
                {
                    MessageBox.Show("Invalid SMTP server !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                item.SMTPServer = smtp;

                var source = Source.LoadSources().Where(u => u.Id == cmbSource.SelectedValue.ToString()).FirstOrDefault();
                if (source == null)
                {
                    MessageBox.Show("Invalid Emails source!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                item.Source = source;

                var mail = Message.LoadMessages().Where(u => u.Id == cmbMessage.SelectedValue.ToString()).FirstOrDefault();
                if (mail == null)
                {
                    MessageBox.Show("Invalid mail message!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                item.TheMessage = mail;
                item.State = "Ready";
                Campaign.Add(item);
                Close();
            }
        }

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
                Opacity += .1;
            else
                tmrShow.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSMTPRotation.Checked)
                pnlRotate.Enabled = true;
            else
                pnlRotate.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBack back = new FrmBack();
            back.Show(this);
            FrmManageSMTPRotations frm = new FrmManageSMTPRotations(SmtpRoatations, cmbSmtp.SelectedValue.ToString());
            frm.ShowDialog();
            back.Close();
            lblServers.Text = SmtpRoatations.Count.ToString() + " server(s)";
        }

        private void cmbSmtp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSmtp.SelectedIndex >= 0)
                chkSMTPRotation.Enabled = true;
            else
                chkSMTPRotation.Enabled = false;

            SmtpRoatations.Remove(SmtpRoatations.Where(u => u.Id == cmbSmtp.SelectedValue.ToString()).FirstOrDefault());
            lblServers.Text = SmtpRoatations.Count.ToString() + " server(s)";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
