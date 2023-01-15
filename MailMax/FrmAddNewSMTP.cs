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
    public partial class FrmAddNewSMTP : Form
    {
        bool isEdit = false;
        string id = "0";
        List<SMTPServer> Servers = new List<SMTPServer>();
        public FrmAddNewSMTP(bool IsEdit, string Id, List<SMTPServer> servers)
        {
            InitializeComponent();
            Servers = servers;
            isEdit = IsEdit;
            id = Id;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
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
        private void FrmAddNewSMTP_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                var item = Servers.Where(u => u.Id == id).FirstOrDefault();
                if (item == null)
                    return;
                txtName.Text = item.name;
                txtpasswprd.Text = item.password;
                txtlogin.Text = item.login;
                txtHost.Text = item.host;
                txtFromName.Text = item.fromName;
                txtFromEmail.Text = item.fromEmail;
                numPort.Value = decimal.Parse(item.port.ToString());
                chkUseSSl.Checked = item.ssl;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtName.TextLength == 0 || txtHost.TextLength == 0 || txtFromEmail.TextLength == 0)
            {
                MessageBox.Show("Please fill all fields!!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isEdit)
            {
                var item = Servers.Where(u => u.Id == id).FirstOrDefault();
                if (item == null)
                    return;
                item.name = txtName.Text;
                item.host = txtHost.Text;
                item.port = int.Parse(numPort.Value.ToString());
                item.login = txtlogin.Text;
                item.password = txtpasswprd.Text;
                item.fromEmail = txtFromEmail.Text;
                item.fromName = txtFromName.Text;
                item.ssl = chkUseSSl.Checked;
                Close();
            }
            else
            {
                //if (Servers.Where(u => u.name == txtName.Text).Count() > 0)
                //{
                //    MessageBox.Show("Another SMTP server with the same name was found, please change it !!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                Servers.Add(new SMTPServer() { ssl = chkUseSSl.Checked, fromEmail = txtFromEmail.Text, fromName = txtFromName.Text, login = txtlogin.Text, host = txtHost.Text, name = txtName.Text, password = txtpasswprd.Text, port = int.Parse(numPort.Value.ToString()) });
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
    }
}
