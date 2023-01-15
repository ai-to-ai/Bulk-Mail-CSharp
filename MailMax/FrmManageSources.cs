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
    public partial class FrmManageSources : Form
    {
        public FrmManageSources()
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
        List<Source> Sources = new List<Source>();
        private void FrmManageSources_Load(object sender, EventArgs e)
        {
            Sources = Source.LoadSources();
            lstSources.Items.Clear();
            foreach (var item in Sources)
            {
                ListViewItem it = new ListViewItem() { Text = item.name };
                it.SubItems.Add(item.Emails.Count.ToString());
                lstSources.Items.Add(it);
            }
        }

        private void FrmManageSources_Resize(object sender, EventArgs e)
        {
            lstSources.Columns[0].Width = (lstSources.Width / 2) - 10;
            lstSources.Columns[1].Width = (lstSources.Width / 2) - 10;
        }

        private void deleteThisMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstSources.SelectedItems.Count > 0 && MessageBox.Show("Are you sure to delete this ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Sources.RemoveAt(lstSources.SelectedItems[0].Index);
                Source.SaveSources(Sources);
                FrmManageSources_Load(null, null);
            }
            else
            {
                if (lstSources.SelectedItems.Count == 0)
                    MessageBox.Show("Please select a source!!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void addNewMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBack frback = new FrmBack();
            frback.Show(this);
            FrmAddSource frm = new FrmAddSource(Sources);
            frm.ShowDialog();
            frback.Close();
            Source.SaveSources(Sources);
            FrmManageSources_Load(null, null);
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
