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
    public partial class FrmViewReport : Form
    {
        Campaign campaign = new Campaign();
        public FrmViewReport(Campaign Thecampaign)
        {
            InitializeComponent();
            campaign = Thecampaign;
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

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private async void FrmViewReport_Load(object sender, EventArgs e)
        {
            label5.Text = "Report Of : " + campaign.Name;
            await Task.Run(() =>
            {
                foreach (var model in campaign.Report.Where(u => u.Passed))
                {
                    dtgReport.Invoke(new MethodInvoker(delegate
                    {
                        dtgReport.Rows.Add();
                        dtgReport.Rows[(dtgReport.Rows.Count - 1)].Cells[0].Value = model.Email;
                        dtgReport.Rows[(dtgReport.Rows.Count - 1)].Cells[1].Value = model.Success;
                        dtgReport.Rows[(dtgReport.Rows.Count - 1)].Cells[2].Value = model.ErrorMessage;
                        if (model.Success)
                        {
                            dtgReport.Rows[(dtgReport.Rows.Count - 1)].Cells[1].Style.BackColor = Color.LimeGreen;
                            dtgReport.Rows[(dtgReport.Rows.Count - 1)].Cells[1].Style.ForeColor = Color.White;
                        }
                        else
                        {
                            dtgReport.Rows[(dtgReport.Rows.Count - 1)].Cells[1].Style.BackColor = Color.DarkOrange;
                            dtgReport.Rows[(dtgReport.Rows.Count - 1)].Cells[1].Style.ForeColor = Color.White;
                        }

                    }));

                }
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog() { Filter = "CSV file(*.csv)|*.csv" };
            if (save.ShowDialog() != DialogResult.OK)
                return;
            string Content = "Email,Success,Error Message\r\n";
            foreach (var model in campaign.Report)
            {
                Content += model.Email + "," + model.Success + "," + model.ErrorMessage + "\r\n";
            }
            File.WriteAllText(save.FileName, Content);
            MessageBox.Show("Report Saved Successfully !!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
