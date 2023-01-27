using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailMax
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pnlSmtpTester.Location = new Point((Width / 2) - (pnlSmtpTester.Width / 2) + (pnlMenu.Width / 2), (Height / 2) - (pnlSmtpTester.Height / 2) + (panel2.Height / 2));
            pnlSettings.Location = new Point((Width / 2) - (pnlSettings.Width / 2) + (pnlMenu.Width / 2), (Height / 2) - (pnlSettings.Height / 2) + (panel2.Height / 2));
            pnlHome.Location = new Point((Width / 2) - (pnlHome.Width / 2) + (pnlMenu.Width / 2), (Height / 2) - (pnlHome.Height / 2) + (panel2.Height / 2));

            pnlEmailAutomation.Size = new Size(Width - pnlMenu.Width - 30, Height - panel2.Height - 40);
            lstCampaings.Size = new Size(pnlEmailAutomation.Width - 20, pnlEmailAutomation.Height - 70);
            lstCampaings.Columns[0].Width = lstCampaings.Width / 3 - 5;
            lstCampaings.Columns[1].Width = lstCampaings.Width / 3 - 5;
            lstCampaings.Columns[2].Width = lstCampaings.Width / 3 - 5;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        bool Pressed = false;
        Point LasPos;
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            Pressed = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Pressed = true;
            LasPos = e.Location;

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Pressed)
            {
                this.Location = new Point(e.X - LasPos.X + Location.X, e.Y - LasPos.Y + Location.Y);
            }
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if (lbl.Tag == null)
                lbl.BackColor = Color.FromArgb(100, 45, 75, 109);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if (lbl.Tag == null)
                lbl.BackColor = Color.Transparent;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;
            if (lbl.Tag == null)
                lbl.BackColor = Color.FromArgb(100, 45, 75, 109);
        }


        void OpenPanel(Panel pnl)
        {
            pnlHome.Visible = false;
            pnlEmailAutomation.Visible = false;
            pnlSmtpTester.Visible = false;
            pnlSettings.Visible = false;


            pnl.Visible = true;

        }
        void SelectLabel(Label lbl)
        {
            lblEmailAutomation.Tag = null;
            lblEmailAutomation.BackColor = Color.Transparent;
            lblEmailAutomation.ForeColor = Color.White;

            lblSettings.Tag = null;
            lblSettings.BackColor = Color.Transparent;
            lblSettings.ForeColor = Color.White;

            lblSmtpTester.Tag = null;
            lblSmtpTester.BackColor = Color.Transparent;
            lblSmtpTester.ForeColor = Color.White;

            lbl.Tag = "selected";
            lbl.BackColor = Color.FromArgb(100, 45, 75, 109);
            lbl.ForeColor = Color.FromArgb(100, 255, 216, 0);
        }

        List<Campaign> campaigns = new List<Campaign>();
        private void label7_Click(object sender, EventArgs e)
        {
            OpenPanel(pnlEmailAutomation);
            SelectLabel(lblEmailAutomation);
            if (campaigns.Where(u => u.IsRunning).Count() > 0)
                return;
            lstCampaings.Items.Clear();
            //campaigns = Campaign.LoadCampaings();
            foreach (var cam in campaigns)
            {
                ListViewItem item = new ListViewItem();
                item.Text = cam.Name;
                item.SubItems.Add(cam.EmailSent.ToString());
                item.SubItems.Add(cam.State);
                lstCampaings.Items.Add(item);
            }
        }




        private void button7_Click(object sender, EventArgs e)
        {
            FrmBack frback = new FrmBack();
            frback.Show(this);
            FrmAddCampaign frm = new FrmAddCampaign(false, "", campaigns);
            frm.ShowDialog();
            frback.Close();
            Campaign.SaveCampaings(campaigns);
            label7_Click(null, null);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (lstCampaings.SelectedItems.Count > 0 && MessageBox.Show("Are you sure to delete this ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                campaigns.RemoveAt(lstCampaings.SelectedItems[0].Index);
                Campaign.SaveCampaings(campaigns);
                label7_Click(null, null);
            }
            else
            {
                if (lstCampaings.SelectedItems.Count == 0)
                    MessageBox.Show("Please select a campaign!!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lstCampaings.SelectedItems.Count > 0)
            {
                FrmBack frback = new FrmBack();
                frback.Show(this);
                FrmAddCampaign frm = new FrmAddCampaign(true, campaigns[lstCampaings.SelectedItems[0].Index].Id, campaigns);
                frm.ShowDialog();
                frback.Close();
                Campaign.SaveCampaings(campaigns);
                label7_Click(null, null);
            }
            else
            {
                MessageBox.Show("Please select a campaign!!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstCampaings.SelectedItems.Count > 0)
            {
                int index = lstCampaings.SelectedItems[0].Index;
                var campaign = campaigns[index];
                campaign.CancelSending = true;
                cntCamaigns.Enabled = false;
            }
        }

        private async void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lstCampaings.SelectedItems.Count > 0)
            {

                int index = lstCampaings.SelectedItems[0].Index;
                var campaign = campaigns[index];
                campaign.IsRunning = true;
                campaign.CancelSending = false;
                int totalEmails = campaign.Source.Emails.Count;
                int count = 0;
                int countTotal = 0;
                int countRotate = 0;
                int RotateIndex = -1;
                campaign.State = "Sending";
                lstCampaings.Items[index].SubItems[2].Text = campaign.State;
                int indexOfEmail = -1;
                SMTPServer UsedServer = campaign.SMTPServer;

                var tasks = new List<Task>();
                CancellationTokenSource source = new CancellationTokenSource();
                CancellationToken token = source.Token;
                int threadCount = settings.NumberOfThreads;
                Console.WriteLine(threadCount);
                ThreadPool.SetMinThreads(threadCount, 0);
                ThreadPool.SetMaxThreads(threadCount, 0);
                TaskFactory factory = new TaskFactory(token);
                int cntEmails = campaign.Source.Emails.Count;
                /* 
                 int threadElements = cntEmails / threadCount;
                 for (int el = 0; el < threadElements; el++)
                 {
                     Thread[] threads = new Thread[threadCount];
                     for (int i = 0; i < threadCount; i++)
                     {
                         var email = campaign.Source.Emails[el * threadCount + i];

                         threads[i] = new Thread(new ThreadStart(() =>
                         {
                             campaign.Report.Add(new ReportModel() { Email = email });
                             indexOfEmail++;
                             Console.WriteLine(indexOfEmail);
                             int currentThreadIndex = indexOfEmail;
                             string MessageError = "";
                             if (settings.EnableVerification)
                             {
                                 if (!ToolsMethods.EmailIsValid(email) || !ToolsMethods.CheckDomain(ToolsMethods.GetDomainFromEmail(email)))
                                 {
                                     campaign.Report[currentThreadIndex].ExcludAfterVerification = true;
                                 }
                             }
                             if (!campaign.Report[currentThreadIndex].ExcludAfterVerification)
                             {
                                 campaign.Report[currentThreadIndex].Success = ToolsMethods.SendEmail(email, UsedServer, campaign.TheMessage, out MessageError);
                             }
                             else
                             {
                                 MessageError = "Excluded after verification of format and domain.";
                             }

                             campaign.Report[currentThreadIndex].ErrorMessage = MessageError;
                             campaign.Report[currentThreadIndex].Passed = true;
                             countTotal++;
                             campaign.EmailSent++;
                             count++;
                             if (campaign.SMTPRotation)
                             {

                                 countRotate++;
                                 if (campaign.SMTPRotationIntervall < countRotate)
                                 {

                                     countRotate = 0;
                                     RotateIndex++;


                                     if (RotateIndex > campaign.ServersRotation.Count - 1)
                                     {

                                         RotateIndex = -1;
                                         UsedServer = campaign.SMTPServer;
                                     }
                                     else
                                     {

                                         UsedServer = campaign.ServersRotation[RotateIndex];
                                     }

                                 }
                             }
                             lstCampaings.Invoke(new MethodInvoker(delegate
                             {

                                 lstCampaings.Items[index].SubItems[1].Text = campaign.EmailSent.ToString() + "/" + totalEmails.ToString();
                             }));
                             if (count > 5)
                             {

                                 if (campaigns[index].CancelSending)
                                 {
                                     campaigns[index].State = "Stopped";
                                     campaign = campaigns[index];
                                     campaign.IsRunning = false;
                                     lstCampaings.Invoke(new MethodInvoker(delegate
                                     {
                                         lstCampaings.Items[index].SubItems[2].Text = campaign.State;
                                     }));

                                     cntCamaigns.Invoke(new MethodInvoker(delegate
                                     {
                                         cntCamaigns.Enabled = true;
                                     }));

                                     for (int j = 0; j < threadCount; j++)
                                     {
                                         if (i != j)
                                             threads[j].Abort();
                                     }
                                 }
                                 count = 0;
                             }
                             if (settings.SecondsBetweenMessages > 0)
                                 Thread.Sleep(settings.SecondsBetweenMessages * 1000);

                             if (settings.WaitAfterXMessages > 0 && countTotal >= settings.WaitAfterXMessages)
                             {
                                 Thread.Sleep(settings.SecondsAfterXMessages * 1000);
                                 countTotal = 0;
                             }
                         }));


                     }

                     for (int i = 0; i < threadCount; i++)
                     {
                         threads[i].Start();
                     }

                     for (int i = 0; i < threadCount; i++)
                     {
                         threads[i].Join();
                     }
                 }

                 for (int i = 0; i < cntEmails - threadCount * threadElements; i++)
                 {
                     Thread[] threads_rest = new Thread[i];

                     var email = campaign.Source.Emails[threadCount * threadElements + i];

                     threads_rest[i] = new Thread(new ThreadStart(() =>
                     {
                         campaign.Report.Add(new ReportModel() { Email = email });
                         indexOfEmail++;
                         Console.WriteLine(indexOfEmail);
                         int currentThreadIndex = indexOfEmail;
                         string MessageError = "";
                         if (settings.EnableVerification)
                         {
                             if (!ToolsMethods.EmailIsValid(email) || !ToolsMethods.CheckDomain(ToolsMethods.GetDomainFromEmail(email)))
                             {
                                 campaign.Report[currentThreadIndex].ExcludAfterVerification = true;
                             }
                         }
                         if (!campaign.Report[currentThreadIndex].ExcludAfterVerification)
                         {
                             campaign.Report[currentThreadIndex].Success = ToolsMethods.SendEmail(email, UsedServer, campaign.TheMessage, out MessageError);
                         }
                         else
                         {
                             MessageError = "Excluded after verification of format and domain.";
                         }

                         campaign.Report[currentThreadIndex].ErrorMessage = MessageError;
                         campaign.Report[currentThreadIndex].Passed = true;
                         countTotal++;
                         campaign.EmailSent++;
                         count++;
                         if (campaign.SMTPRotation)
                         {

                             countRotate++;
                             if (campaign.SMTPRotationIntervall < countRotate)
                             {

                                 countRotate = 0;
                                 RotateIndex++;


                                 if (RotateIndex > campaign.ServersRotation.Count - 1)
                                 {

                                     RotateIndex = -1;
                                     UsedServer = campaign.SMTPServer;
                                 }
                                 else
                                 {

                                     UsedServer = campaign.ServersRotation[RotateIndex];
                                 }

                             }
                         }
                         lstCampaings.Invoke(new MethodInvoker(delegate
                         {

                             lstCampaings.Items[index].SubItems[1].Text = campaign.EmailSent.ToString() + "/" + totalEmails.ToString();
                         }));
                         if (count > 5)
                         {

                             if (campaigns[index].CancelSending)
                             {
                                 campaigns[index].State = "Stopped";
                                 campaign = campaigns[index];
                                 campaign.IsRunning = false;
                                 lstCampaings.Invoke(new MethodInvoker(delegate
                                 {
                                     lstCampaings.Items[index].SubItems[2].Text = campaign.State;
                                 }));

                                 cntCamaigns.Invoke(new MethodInvoker(delegate
                                 {
                                     cntCamaigns.Enabled = true;
                                 }));

                                 for (int j = 0; j < threadCount; j++)
                                 {
                                     if (i != j)
                                         threads_rest[j].Abort();
                                 }
                             }
                             count = 0;
                         }
                         if (settings.SecondsBetweenMessages > 0)
                             Thread.Sleep(settings.SecondsBetweenMessages * 1000);

                         if (settings.WaitAfterXMessages > 0 && countTotal >= settings.WaitAfterXMessages)
                         {
                             Thread.Sleep(settings.SecondsAfterXMessages * 1000);
                             countTotal = 0;
                         }
                     }));

                     threads_rest[i].Start(i);

                     for (int k = 0; k < cntEmails - threadCount * threadElements; k++)
                     {
                         threads_rest[k].Join();
                     }
                 }

                 if (!campaigns[index].CancelSending)
                     campaign.State = "Finished";
                 campaign = campaigns[index];
                 campaign.IsRunning = false;
                 lstCampaings.Invoke(new MethodInvoker(delegate
                 {
                     lstCampaings.Items[index].SubItems[2].Text = campaign.State;
                 }));

                 cntCamaigns.Invoke(new MethodInvoker(delegate
                 {
                     cntCamaigns.Enabled = true;
                 }));*/
                foreach (var email in campaign.Source.Emails)
                {
                    tasks.Add(factory.StartNew(() =>
                    {
                        campaign.Report.Add(new ReportModel() { Email = email });
                        indexOfEmail++;
                        int currentThreadIndex = indexOfEmail;
                        string MessageError = "";
                        if (settings.EnableVerification)
                        {
                            if (!ToolsMethods.EmailIsValid(email) || !ToolsMethods.CheckDomain(ToolsMethods.GetDomainFromEmail(email)))
                            {
                                campaign.Report[currentThreadIndex].ExcludAfterVerification = true;
                            }
                        }
                        if (!campaign.Report[currentThreadIndex].ExcludAfterVerification)
                        {
                            Console.WriteLine("Sending");
                            Console.WriteLine(currentThreadIndex);
                            campaign.Report[currentThreadIndex].Success = ToolsMethods.SendEmail(email, UsedServer, campaign.TheMessage, out MessageError);
                            Console.WriteLine("Receiving");
                            Console.WriteLine(currentThreadIndex);
                        }
                        else
                        {
                            MessageError = "Excluded after verification of format and domain.";
                        }

                        campaign.Report[currentThreadIndex].ErrorMessage = MessageError;
                        campaign.Report[currentThreadIndex].Passed = true;
                        countTotal++;
                        campaign.EmailSent++;
                        count++;
                        if (campaign.SMTPRotation)
                        {

                            countRotate++;
                            if (campaign.SMTPRotationIntervall < countRotate)
                            {

                                countRotate = 0;
                                RotateIndex++;


                                if (RotateIndex > campaign.ServersRotation.Count - 1)
                                {

                                    RotateIndex = -1;
                                    UsedServer = campaign.SMTPServer;
                                }
                                else
                                {

                                    UsedServer = campaign.ServersRotation[RotateIndex];
                                }

                            }
                        }
                        lstCampaings.Invoke(new MethodInvoker(delegate
                        {

                            lstCampaings.Items[index].SubItems[1].Text = campaign.EmailSent.ToString() + "/" + totalEmails.ToString();
                        }), token);
                        if (count > 5)
                        {

                            if (campaigns[index].CancelSending)
                            {
                                campaigns[index].State = "Stopped";
                                campaign = campaigns[index];
                                campaign.IsRunning = false;
                                lstCampaings.Invoke(new MethodInvoker(delegate
                                {
                                    lstCampaings.Items[index].SubItems[2].Text = campaign.State;
                                }));

                                cntCamaigns.Invoke(new MethodInvoker(delegate
                                {
                                    cntCamaigns.Enabled = true;
                                }));
                                source.Cancel();
                            }
                            count = 0;
                        }
/*                        if (settings.SecondsBetweenMessages > 0)
                            Thread.Sleep(settings.SecondsBetweenMessages * 1000);*/

/*                        if (settings.WaitAfterXMessages > 0 && countTotal >= settings.WaitAfterXMessages)
                        {
                            Thread.Sleep(settings.SecondsAfterXMessages * 1000);
                            countTotal = 0;
                        }*/
                    }));
                }
                try
                {
                    Task t = factory.ContinueWhenAll(tasks.ToArray(), (results) =>
                    {
                        if (!campaigns[index].CancelSending)
                            campaign.State = "Finished";
                        campaign = campaigns[index];
                        campaign.IsRunning = false;
                        lstCampaings.Invoke(new MethodInvoker(delegate
                        {
                            lstCampaings.Items[index].SubItems[2].Text = campaign.State;
                        }));

                        cntCamaigns.Invoke(new MethodInvoker(delegate
                        {
                            cntCamaigns.Enabled = true;
                        }));
                    }, token);
                }
                catch { };

                //Task t = Task.WhenAll(tasks.ToArray());

                /*                try
                                {
                                    await t;
                                }
                                catch { }*/

                /*if (!campaigns[index].CancelSending)
                    campaign.State = "Finished";
                campaign = campaigns[index];
                campaign.IsRunning = false;
                lstCampaings.Invoke(new MethodInvoker(delegate
                {
                    lstCampaings.Items[index].SubItems[2].Text = campaign.State;
                }));

                cntCamaigns.Invoke(new MethodInvoker(delegate
                {
                    cntCamaigns.Enabled = true;
                }));*/
                /*Task.Run(() =>
                {
                    foreach (var email in campaign.Source.Emails)
                    {
                        campaign.Report.Add(new ReportModel() { Email = email });
                        indexOfEmail++;
                        string MessageError = "";
                        if (settings.EnableVerification)
                        {
                            if (!ToolsMethods.EmailIsValid(email) || !ToolsMethods.CheckDomain(ToolsMethods.GetDomainFromEmail(email)))
                            {
                                campaign.Report[indexOfEmail].ExcludAfterVerification = true;
                            }
                        }
                        if (!campaign.Report[indexOfEmail].ExcludAfterVerification)
                        {
                            campaign.Report[indexOfEmail].Success = ToolsMethods.SendEmail(email, UsedServer, campaign.TheMessage, out MessageError);
                        }
                        else
                        {
                            MessageError = "Excluded after verification of format and domain.";
                        }

                        campaign.Report[indexOfEmail].ErrorMessage = MessageError;
                        campaign.Report[indexOfEmail].Passed = true;
                        countTotal++;
                        campaign.EmailSent++;
                        count++;
                        if (campaign.SMTPRotation)
                        {

                            countRotate++;
                            if (campaign.SMTPRotationIntervall < countRotate)
                            {

                                countRotate = 0;
                                RotateIndex++;


                                if (RotateIndex > campaign.ServersRotation.Count - 1)
                                {

                                    RotateIndex = -1;
                                    UsedServer = campaign.SMTPServer;
                                }
                                else
                                {

                                    UsedServer = campaign.ServersRotation[RotateIndex];
                                }

                            }
                        }
                        lstCampaings.Invoke(new MethodInvoker(delegate
                        {

                            lstCampaings.Items[index].SubItems[1].Text = campaign.EmailSent.ToString() + "/" + totalEmails.ToString();
                        }));
                        if (count > 5)
                        {

                            if (campaigns[index].CancelSending)
                            {
                                campaigns[index].State = "Stopped";
                                break;
                            }
                            count = 0;
                        }
                        if (settings.SecondsBetweenMessages > 0)
                            Thread.Sleep(settings.SecondsBetweenMessages * 1000);

                        if (settings.WaitAfterXMessages > 0 && countTotal >= settings.WaitAfterXMessages)
                        {
                            Thread.Sleep(settings.SecondsAfterXMessages * 1000);
                            countTotal = 0;
                        }
                    }

                    if (!campaigns[index].CancelSending)
                        campaign.State = "Finished";
                    campaign = campaigns[index];
                    campaign.IsRunning = false;
                    lstCampaings.Invoke(new MethodInvoker(delegate
                    {
                        lstCampaings.Items[index].SubItems[2].Text = campaign.State;
                    }));

                    cntCamaigns.Invoke(new MethodInvoker(delegate
                    {
                        cntCamaigns.Enabled = true;
                    }));
                });*/

            }
        }

        private void lstCampaings_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void restartCampaignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstCampaings.SelectedItems.Count > 0)
            {
                int index = lstCampaings.SelectedItems[0].Index;
                var campaign = campaigns[index];
                campaign.CancelSending = false;
                campaign.EmailSent = 0;
                campaign.Report = new List<ReportModel>();
                Campaign.SaveCampaings(campaigns);
                startToolStripMenuItem_Click(null, null);
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Campaign.SaveCampaings(campaigns);
        }

        private void cntCamaigns_Opening(object sender, CancelEventArgs e)
        {
            if (lstCampaings.SelectedItems.Count > 0)
            {
                int index = lstCampaings.SelectedItems[0].Index;
                var campaign = campaigns[index];
                if (campaign.State == "Sending")
                {
                    stopToolStripMenuItem.Enabled = true; startToolStripMenuItem.Enabled = false; restartCampaignToolStripMenuItem.Enabled = false;
                }
                if (campaign.State == "Ready")
                {
                    startToolStripMenuItem.Enabled = true; stopToolStripMenuItem.Enabled = false; restartCampaignToolStripMenuItem.Enabled = false;
                }
                if (campaign.State == "Stopped" || campaign.State == "Finished")
                {
                    restartCampaignToolStripMenuItem.Enabled = true; startToolStripMenuItem.Enabled = false; stopToolStripMenuItem.Enabled = false;
                    viewReportToolStripMenuItem.Enabled = true;
                }
            }
            else
            {
                startToolStripMenuItem.Enabled = false;
                stopToolStripMenuItem.Enabled = false;
                restartCampaignToolStripMenuItem.Enabled = false;
                viewReportToolStripMenuItem.Enabled = false;
            }
        }


        private void lblSmtpTester_Click(object sender, EventArgs e)
        {
            OpenPanel(pnlSmtpTester);
            SelectLabel(lblSmtpTester);
        }
        bool IsDone()
        {
            bool stat = true;
            if (txtport.Value.ToString() == "")
                txtport.Value = 25;
            if (!txtfrom.Text.Contains('@'))
            {
                txtfrom.BackColor = Color.Red;
                stat = false;
            }
            else txtfrom.BackColor = Color.FromArgb(255, 45, 75, 109);
            if (!txtto.Text.Contains('@'))
            {
                txtto.BackColor = Color.Red;
                stat = false;
            }
            else txtto.BackColor = Color.FromArgb(255, 45, 75, 109);
            if (txthost.Text.Length <= 0)
            {
                txthost.BackColor = Color.Red;
                stat = false;
            }
            else txthost.BackColor = Color.FromArgb(255, 45, 75, 109);
            if (chkAuthentication.Checked)
            {
                if (txtLogin.Text.Length <= 0)
                {
                    txtLogin.BackColor = Color.Red;
                    stat = false;
                }
                else txtLogin.BackColor = Color.FromArgb(255, 45, 75, 109);

                if (txtPassword.Text.Length <= 0)
                {
                    txtPassword.BackColor = Color.Red;
                    stat = false;
                }
                else txtPassword.BackColor = Color.FromArgb(255, 45, 75, 109);
            }
            return stat;
        }
        private async void button8_Click(object sender, EventArgs e)
        {
            if (!IsDone())
            {
                MessageBox.Show("Some fields are missing required informations !!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SmtpClient smtp = new SmtpClient();
            smtp.Host = txthost.Text;

            if (chkAuthentication.Checked)
            {
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(txtLogin.Text, txtPassword.Text);
            }
            if (!ToolsMethods.EmailIsValid(txtfrom.Text) || !ToolsMethods.EmailIsValid(txtto.Text))
            {
                MessageBox.Show("Please enter a valid email !!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            smtp.EnableSsl = chkSSL.Checked;
            smtp.Port = int.Parse(txtport.Value.ToString());
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            MailMessage message = new MailMessage();
            try
            {
                message.To.Add(txtto.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid email !!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                message.Sender = new MailAddress(txtfrom.Text);
                message.From = new MailAddress(txtfrom.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid email !!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            message.Body = @"This is a test mail sent from MailMax SMTP Tester with the following data :<br/><br/>
Host :" + txthost.Text + @"<br/>
Port :" + txtport.Value.ToString() + @"<br/>
Enable SSL :" + chkSSL.Checked.ToString() + @"<br/>
Use authentication:" + chkAuthentication.Checked.ToString() + @"<br/>
Login :" + (chkAuthentication.Checked ? txtLogin.Text : "------") + @"<br/>
Password : " + (chkAuthentication.Checked ? "******" : "--------") + @"<br/>
Email from :" + txtfrom.Text + @"<br/>
Email to :" + txtto.Text + @"<br/>
<br/>
Thank You<br/>";
            message.IsBodyHtml = true;
            message.Subject = "Test Mail from SMTP Sender";
            FrmBackLoad frm = new FrmBackLoad();
            try
            {

                frm.Show(this);
                frm.BringToFront();
                bool isError = false;
                await Task.Run(() =>
                {
                    try
                    {
                        smtp.Send(message);
                    }
                    catch (Exception ex)
                    {
                        isError = true;
                        frm.Invoke(new MethodInvoker(delegate
                        {
                            frm.Close();
                        }));

                        MessageBox.Show("The was an error while sending your mail : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                });
                frm.Close();
                if (!isError)
                    MessageBox.Show("The mail was sent successfully !!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                frm.Close();
                MessageBox.Show("The was an error while sending your mail : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAuthentication.Checked)
            {
                txtLogin.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtPassword.Enabled = true;
                txtLogin.Enabled = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("host or ip address of your smtp server (example: smtp.company.com)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the default port is 25, but some smtp servers use a custom port (example: 587)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("checked it only if the smtp server needs a secured connection (ssl, tsl) ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("most of smtp servers need an authentication (login/password). Check it if required", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("required if 'Use authentication' is checked (ex: account or account@foo.com)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label25_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" required if 'Use authentication' is checked ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("very important : the test mail will be sent to this address (ex: account@foo.com)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label22_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" the sender's email address (example: account@foo.com) ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            campaigns = Campaign.LoadCampaings();
            foreach (var itm in campaigns)
            {
                itm.IsRunning = false;
                if (itm.State == "Sending")
                    itm.State = "Stopped";
            }
            Campaign.SaveCampaings(campaigns);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrmBack frback = new FrmBack();
            frback.Show(this);
            FrmManageSources frm = new FrmManageSources();
            frm.ShowDialog();
            frback.Close();
        }

        private void lbManageMessages_Click(object sender, EventArgs e)
        {
            FrmBack frback = new FrmBack();
            frback.Show(this);
            frmManageMessages frm = new frmManageMessages();
            frm.ShowDialog();
            frback.Close();
        }

        private void lblManageSMTP_Click(object sender, EventArgs e)
        {
            FrmBack frback = new FrmBack();
            frback.Show(this);
            ManageSmtpServers frm = new ManageSmtpServers();
            frm.ShowDialog();
            frback.Close();
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            numWaitSecondsAfterXMessages.Value = (int)settings.WaitAfterXMessages;
            numSecondsWaitAfterXMessages.Value = (int)settings.SecondsAfterXMessages;
            numSecondsBetweenMessages.Value = (int)settings.SecondsBetweenMessages;
            chkEnableVerification.Checked = settings.EnableVerification;
            numThreads.Value = settings.NumberOfThreads;
            OpenPanel(pnlSettings);
            SelectLabel(lblSettings);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsDone())
            {
                MessageBox.Show("Some fields are missing required informations !!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<SMTPServer> servers = new List<SMTPServer>();
            servers = SMTPServer.LoadSMTPServers();
            string ServerName = "Server-" + DateTime.Now.Millisecond.ToString();
            servers.Add(new SMTPServer() { ssl = chkSSL.Checked, fromEmail = txtfrom.Text, fromName = txtfrom.Text, login = txtLogin.Text, host = txthost.Text, name = ServerName, password = txtPassword.Text, port = int.Parse(txtport.Value.ToString()) });
            SMTPServer.SaveSMTPServers(servers);
            MessageBox.Show("Added Successfully with name '" + ServerName + "' !.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmBack frback = new FrmBack();
            frback.Show(this);
            FrmAddNewSMTP frm = new FrmAddNewSMTP(true, servers[servers.Count - 1].Id, servers);
            frm.ShowDialog();
            frback.Close();
            SMTPServer.SaveSMTPServers(servers);
        }
        Settings settings = Settings.LoadSettings();
        private void button3_Click(object sender, EventArgs e)
        {
            settings.EnableVerification = chkEnableVerification.Checked;
            settings.SecondsBetweenMessages = int.Parse(numSecondsBetweenMessages.Value.ToString());
            settings.SecondsAfterXMessages = int.Parse(numSecondsWaitAfterXMessages.Value.ToString());
            settings.WaitAfterXMessages = int.Parse(numWaitSecondsAfterXMessages.Value.ToString());
            settings.NumberOfThreads = int.Parse(numThreads.Value.ToString());
            Settings.SaveChanges(settings);
            MessageBox.Show("Changes Saved Successfully !!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
                Opacity += .1;
            else
                tmrShow.Enabled = false;
        }

        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstCampaings.SelectedItems.Count > 0)
            {
                FrmBack frback = new FrmBack();
                frback.Show(this);
                FrmViewReport frm = new FrmViewReport(campaigns[lstCampaings.SelectedItems[0].Index]);
                frm.ShowDialog();
                frback.Close();
            }
            else
            {
                MessageBox.Show("Please select a campaign!!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
