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
    public partial class FrmAddSource : Form
    {
        List<Source> sources = new List<Source>();
        public FrmAddSource(List<Source> Sources)
        {
            InitializeComponent();
            sources = Sources;
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
        private void FrmAddSource_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog() { Filter = "Text file (*.txt;*.csv) | *.txt;*.csv" };
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtfile.Text = open.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtfile.Text) && txtname.TextLength > 0 && txtfile.TextLength > 0)
            {
                var emails = File.ReadAllLines(txtfile.Text);
                Source source = new Source() { name = txtname.Text, Emails = new List<string>() };
                source.Emails = emails.ToList();
                sources.Add(source);
                Close();
            }
            else
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
                Opacity += .1;
            else
                tmrShow.Enabled = false;
        }
    }
}
