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
    public partial class frmManageMessages : Form
    {
        public frmManageMessages()
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
        List<Message> messages = new List<Message>();
        private void frmManageMessages_Load(object sender, EventArgs e)
        {
            lstMessages.Items.Clear();
            messages = Message.LoadMessages();
            foreach (var item in messages)
            {
                ListViewItem it = new ListViewItem() { Text = item.name };
                it.SubItems.Add(ToolsMethods.GetDate(item.DateAdded));
                lstMessages.Items.Add(it);
            }
        }

        private void frmManageMessages_Resize(object sender, EventArgs e)
        {
            lstMessages.Columns[0].Width = (lstMessages.Width / 2) - 10;
            lstMessages.Columns[1].Width = (lstMessages.Width / 2) - 10;
        }

        private void addNewMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBack frback = new FrmBack();
            frback.Show(this);
            FrmAddNewMessage frm = new FrmAddNewMessage(false, "", messages);
            frm.ShowDialog();
            frback.Close();
            Message.SaveMessages(messages);
            frmManageMessages_Load(null, null);
        }

        private void editThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMessages.SelectedItems.Count > 0)
            {
                FrmBack frback = new FrmBack();
                frback.Show(this);
                FrmAddNewMessage frm = new FrmAddNewMessage(true, messages[lstMessages.SelectedItems[0].Index].Id, messages);
                frm.ShowDialog();
                frback.Close();
                Message.SaveMessages(messages);
                frmManageMessages_Load(null, null);
            }
            else
            {
                MessageBox.Show("Please select a mail message !!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteThisMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMessages.SelectedItems.Count > 0 && MessageBox.Show("Are you sure to delete this ?", "Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                messages.RemoveAt(lstMessages.SelectedItems[0].Index);
                Message.SaveMessages(messages);
                frmManageMessages_Load(null, null);
            }
            else
            {
                if (lstMessages.SelectedItems.Count == 0)
                    MessageBox.Show("Please select a mail message !!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
