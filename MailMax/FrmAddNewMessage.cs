using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailMax
{
    public partial class FrmAddNewMessage : Form
    {
        bool isEdit = false;
        string id = "0";
        List<Message> Messages = new List<Message>();
        public FrmAddNewMessage(bool IsEdit, string Id, List<Message> messages)
        {
            InitializeComponent();
            Messages = messages;
            isEdit = IsEdit;
            id = Id;
        }

        private void chkUseHTML_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseHTML.Checked)
                btnPreview.Visible = true;
            else
                btnPreview.Visible = false;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (btnPreview.Text == "Preview")
            {
                btnPreview.Text = "Close";
                txtBody.Visible = false;
                webBody.Visible = true;
                webBody.DocumentText = txtBody.Text;
            }
            else
            {
                btnPreview.Text = "Preview";
                txtBody.Visible = true;
                webBody.Visible = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtName.TextLength == 0 || txtSubject.TextLength == 0 || txtBody.TextLength == 0)
            {
                MessageBox.Show("Please fill all fields!!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isEdit)
            {
                var msg = Messages.Where(u => u.Id == id).FirstOrDefault();
                if (msg == null)
                    return;
                msg.MessageBody = txtBody.Text;
                msg.UseHTML = chkUseHTML.Checked;
                msg.Subject = txtSubject.Text;
                msg.name = txtName.Text;
                msg.Attachment = PathOfAttach;
                Close();
            }
            else
            {
                Messages.Add(new Message() { Attachment = PathOfAttach, MessageBody = txtBody.Text, name = txtName.Text, Subject = txtSubject.Text, UseHTML = chkUseHTML.Checked });
                Close();
            }
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
        private void FrmAddNewMessage_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                var msg = Messages.Where(u => u.Id == id).FirstOrDefault();
                if (msg == null)
                    return;
                txtBody.Text = msg.MessageBody;
                txtSubject.Text = msg.Subject;
                txtName.Text = msg.name;
                chkUseHTML.Checked = msg.UseHTML;
                PathOfAttach = msg.Attachment;
                lblAttachmentFile.Text = Path.GetFileName(PathOfAttach);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
                Opacity += .1;
            else
                tmrShow.Enabled = false;
        }
        string PathOfAttach = "";
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                PathOfAttach = open.FileName;
                lblAttachmentFile.Text = Path.GetFileName(open.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PathOfAttach = "";
            lblAttachmentFile.Text = "";
        }
    }
}
