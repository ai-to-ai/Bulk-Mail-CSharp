
namespace MailMax
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblManageSMTP = new System.Windows.Forms.Label();
            this.lbManageMessages = new System.Windows.Forms.Label();
            this.lblMnageSources = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblEmailAutomation = new System.Windows.Forms.Label();
            this.lblSmtpTester = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEmailAutomation = new System.Windows.Forms.Panel();
            this.lstCampaings = new System.Windows.Forms.ListView();
            this.campaignName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Emails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cntCamaigns = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartCampaignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button7 = new System.Windows.Forms.Button();
            this.pnlSmtpTester = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtto = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.chkAuthentication = new System.Windows.Forms.CheckBox();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.txtport = new System.Windows.Forms.NumericUpDown();
            this.txthost = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label30 = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.chkEnableVerification = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numSecondsWaitAfterXMessages = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numWaitSecondsAfterXMessages = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numSecondsBetweenMessages = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tmrShow = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlEmailAutomation.SuspendLayout();
            this.cntCamaigns.SuspendLayout();
            this.pnlSmtpTester.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtport)).BeginInit();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSecondsWaitAfterXMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaitSecondsAfterXMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecondsBetweenMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.lblManageSMTP);
            this.pnlMenu.Controls.Add(this.lbManageMessages);
            this.pnlMenu.Controls.Add(this.lblMnageSources);
            this.pnlMenu.Controls.Add(this.lblSettings);
            this.pnlMenu.Controls.Add(this.lblEmailAutomation);
            this.pnlMenu.Controls.Add(this.lblSmtpTester);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 55);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(213, 491);
            this.pnlMenu.TabIndex = 4;
            // 
            // lblManageSMTP
            // 
            this.lblManageSMTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblManageSMTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageSMTP.Location = new System.Drawing.Point(0, 130);
            this.lblManageSMTP.Name = "lblManageSMTP";
            this.lblManageSMTP.Size = new System.Drawing.Size(210, 37);
            this.lblManageSMTP.TabIndex = 9;
            this.lblManageSMTP.Text = "SMTP Servers";
            this.lblManageSMTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblManageSMTP.Click += new System.EventHandler(this.lblManageSMTP_Click);
            this.lblManageSMTP.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.lblManageSMTP.MouseHover += new System.EventHandler(this.label2_MouseHover);
            this.lblManageSMTP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // lbManageMessages
            // 
            this.lbManageMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbManageMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManageMessages.Location = new System.Drawing.Point(0, 80);
            this.lbManageMessages.Name = "lbManageMessages";
            this.lbManageMessages.Size = new System.Drawing.Size(210, 37);
            this.lbManageMessages.TabIndex = 8;
            this.lbManageMessages.Text = "Mail Messages";
            this.lbManageMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbManageMessages.Click += new System.EventHandler(this.lbManageMessages_Click);
            this.lbManageMessages.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.lbManageMessages.MouseHover += new System.EventHandler(this.label2_MouseHover);
            this.lbManageMessages.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // lblMnageSources
            // 
            this.lblMnageSources.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMnageSources.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMnageSources.Location = new System.Drawing.Point(0, 30);
            this.lblMnageSources.Name = "lblMnageSources";
            this.lblMnageSources.Size = new System.Drawing.Size(210, 37);
            this.lblMnageSources.TabIndex = 7;
            this.lblMnageSources.Text = "Sources(Emails)";
            this.lblMnageSources.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMnageSources.Click += new System.EventHandler(this.label6_Click);
            this.lblMnageSources.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.lblMnageSources.MouseHover += new System.EventHandler(this.label2_MouseHover);
            this.lblMnageSources.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // lblSettings
            // 
            this.lblSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.Location = new System.Drawing.Point(0, 445);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(210, 37);
            this.lblSettings.TabIndex = 6;
            this.lblSettings.Text = "General Settings";
            this.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSettings.Click += new System.EventHandler(this.lblSettings_Click);
            this.lblSettings.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.lblSettings.MouseHover += new System.EventHandler(this.label2_MouseHover);
            this.lblSettings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // lblEmailAutomation
            // 
            this.lblEmailAutomation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmailAutomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAutomation.Location = new System.Drawing.Point(0, 230);
            this.lblEmailAutomation.Name = "lblEmailAutomation";
            this.lblEmailAutomation.Size = new System.Drawing.Size(210, 37);
            this.lblEmailAutomation.TabIndex = 5;
            this.lblEmailAutomation.Text = "Campaings";
            this.lblEmailAutomation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmailAutomation.Click += new System.EventHandler(this.label7_Click);
            this.lblEmailAutomation.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.lblEmailAutomation.MouseHover += new System.EventHandler(this.label2_MouseHover);
            this.lblEmailAutomation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // lblSmtpTester
            // 
            this.lblSmtpTester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSmtpTester.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmtpTester.Location = new System.Drawing.Point(0, 180);
            this.lblSmtpTester.Name = "lblSmtpTester";
            this.lblSmtpTester.Size = new System.Drawing.Size(210, 37);
            this.lblSmtpTester.TabIndex = 4;
            this.lblSmtpTester.Text = "SMTP Tester";
            this.lblSmtpTester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSmtpTester.Click += new System.EventHandler(this.lblSmtpTester_Click);
            this.lblSmtpTester.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.lblSmtpTester.MouseHover += new System.EventHandler(this.label2_MouseHover);
            this.lblSmtpTester.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 55);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Image = global::MailMax.Properties.Resources.Minimize;
            this.label4.Location = new System.Drawing.Point(800, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 30);
            this.label4.TabIndex = 3;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label4.MouseHover += new System.EventHandler(this.label2_MouseHover);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Image = global::MailMax.Properties.Resources.Maximze;
            this.label3.Location = new System.Drawing.Point(838, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 30);
            this.label3.TabIndex = 2;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.label2_MouseHover);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(875, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 30);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 55);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "MailMax";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEmailAutomation
            // 
            this.pnlEmailAutomation.Controls.Add(this.lstCampaings);
            this.pnlEmailAutomation.Controls.Add(this.button7);
            this.pnlEmailAutomation.Location = new System.Drawing.Point(230, 77);
            this.pnlEmailAutomation.Name = "pnlEmailAutomation";
            this.pnlEmailAutomation.Size = new System.Drawing.Size(685, 461);
            this.pnlEmailAutomation.TabIndex = 7;
            this.pnlEmailAutomation.Visible = false;
            // 
            // lstCampaings
            // 
            this.lstCampaings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.lstCampaings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.campaignName,
            this.Emails,
            this.State});
            this.lstCampaings.ContextMenuStrip = this.cntCamaigns;
            this.lstCampaings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCampaings.ForeColor = System.Drawing.Color.White;
            this.lstCampaings.FullRowSelect = true;
            this.lstCampaings.HideSelection = false;
            this.lstCampaings.Location = new System.Drawing.Point(7, 62);
            this.lstCampaings.MultiSelect = false;
            this.lstCampaings.Name = "lstCampaings";
            this.lstCampaings.Size = new System.Drawing.Size(669, 381);
            this.lstCampaings.TabIndex = 38;
            this.lstCampaings.UseCompatibleStateImageBehavior = false;
            this.lstCampaings.View = System.Windows.Forms.View.Details;
            this.lstCampaings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstCampaings_MouseClick);
            // 
            // campaignName
            // 
            this.campaignName.Text = "Campaign Name";
            this.campaignName.Width = 286;
            // 
            // Emails
            // 
            this.Emails.Text = "Emails sent";
            this.Emails.Width = 195;
            // 
            // State
            // 
            this.State.Text = "State";
            this.State.Width = 84;
            // 
            // cntCamaigns
            // 
            this.cntCamaigns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.restartCampaignToolStripMenuItem,
            this.viewReportToolStripMenuItem});
            this.cntCamaigns.Name = "cntAutomationSettings";
            this.cntCamaigns.Size = new System.Drawing.Size(186, 136);
            this.cntCamaigns.Opening += new System.ComponentModel.CancelEventHandler(this.cntCamaigns_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem1.Text = "Edit this campaign";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem3.Text = "Delete this campaign";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Enabled = false;
            this.startToolStripMenuItem.Image = global::MailMax.Properties.Resources.Custom_Icon_Design_Flatastic_9_Start;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.startToolStripMenuItem.Text = "Start Campaign";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Image = global::MailMax.Properties.Resources.stop;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.stopToolStripMenuItem.Text = "Stop Campaign";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // restartCampaignToolStripMenuItem
            // 
            this.restartCampaignToolStripMenuItem.Enabled = false;
            this.restartCampaignToolStripMenuItem.Name = "restartCampaignToolStripMenuItem";
            this.restartCampaignToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.restartCampaignToolStripMenuItem.Text = "Restart Campaign";
            this.restartCampaignToolStripMenuItem.Click += new System.EventHandler(this.restartCampaignToolStripMenuItem_Click);
            // 
            // viewReportToolStripMenuItem
            // 
            this.viewReportToolStripMenuItem.Enabled = false;
            this.viewReportToolStripMenuItem.Name = "viewReportToolStripMenuItem";
            this.viewReportToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.viewReportToolStripMenuItem.Text = "View Report";
            this.viewReportToolStripMenuItem.Click += new System.EventHandler(this.viewReportToolStripMenuItem_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(514, 8);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 38);
            this.button7.TabIndex = 37;
            this.button7.Text = "New Campaign";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pnlSmtpTester
            // 
            this.pnlSmtpTester.Controls.Add(this.button1);
            this.pnlSmtpTester.Controls.Add(this.label25);
            this.pnlSmtpTester.Controls.Add(this.label23);
            this.pnlSmtpTester.Controls.Add(this.label22);
            this.pnlSmtpTester.Controls.Add(this.label17);
            this.pnlSmtpTester.Controls.Add(this.label16);
            this.pnlSmtpTester.Controls.Add(this.label15);
            this.pnlSmtpTester.Controls.Add(this.label13);
            this.pnlSmtpTester.Controls.Add(this.label12);
            this.pnlSmtpTester.Controls.Add(this.label7);
            this.pnlSmtpTester.Controls.Add(this.txtto);
            this.pnlSmtpTester.Controls.Add(this.label18);
            this.pnlSmtpTester.Controls.Add(this.txtfrom);
            this.pnlSmtpTester.Controls.Add(this.label19);
            this.pnlSmtpTester.Controls.Add(this.txtPassword);
            this.pnlSmtpTester.Controls.Add(this.label20);
            this.pnlSmtpTester.Controls.Add(this.txtLogin);
            this.pnlSmtpTester.Controls.Add(this.label21);
            this.pnlSmtpTester.Controls.Add(this.chkAuthentication);
            this.pnlSmtpTester.Controls.Add(this.chkSSL);
            this.pnlSmtpTester.Controls.Add(this.txtport);
            this.pnlSmtpTester.Controls.Add(this.txthost);
            this.pnlSmtpTester.Controls.Add(this.label24);
            this.pnlSmtpTester.Controls.Add(this.button8);
            this.pnlSmtpTester.Location = new System.Drawing.Point(230, 77);
            this.pnlSmtpTester.Name = "pnlSmtpTester";
            this.pnlSmtpTester.Size = new System.Drawing.Size(685, 461);
            this.pnlSmtpTester.TabIndex = 9;
            this.pnlSmtpTester.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(246, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 38);
            this.button1.TabIndex = 60;
            this.button1.Text = "Add To SMTP Servers";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label25
            // 
            this.label25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(246, 251);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(43, 23);
            this.label25.TabIndex = 59;
            this.label25.Text = "?";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label23
            // 
            this.label23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(560, 249);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 23);
            this.label23.TabIndex = 58;
            this.label23.Text = "?";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label22
            // 
            this.label22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(556, 178);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 23);
            this.label22.TabIndex = 57;
            this.label22.Text = "?";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label17
            // 
            this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(246, 178);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 23);
            this.label17.TabIndex = 56;
            this.label17.Text = "?";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(242, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 23);
            this.label16.TabIndex = 55;
            this.label16.Text = "?";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(525, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 23);
            this.label15.TabIndex = 54;
            this.label15.Text = "?";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label13
            // 
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(556, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 23);
            this.label13.TabIndex = 53;
            this.label13.Text = "?";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(246, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 23);
            this.label12.TabIndex = 52;
            this.label12.Text = "?";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Port :";
            // 
            // txtto
            // 
            this.txtto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.txtto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtto.ForeColor = System.Drawing.Color.White;
            this.txtto.Location = new System.Drawing.Point(357, 274);
            this.txtto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(246, 24);
            this.txtto.TabIndex = 50;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(354, 254);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 18);
            this.label18.TabIndex = 49;
            this.label18.Text = "Email to :";
            // 
            // txtfrom
            // 
            this.txtfrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.txtfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfrom.ForeColor = System.Drawing.Color.White;
            this.txtfrom.Location = new System.Drawing.Point(356, 202);
            this.txtfrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(246, 24);
            this.txtfrom.TabIndex = 48;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(353, 182);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 18);
            this.label19.TabIndex = 47;
            this.label19.Text = "Email from :";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(43, 276);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(246, 24);
            this.txtPassword.TabIndex = 46;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(40, 256);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 18);
            this.label20.TabIndex = 45;
            this.label20.Text = "Password :";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.txtLogin.Enabled = false;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.White;
            this.txtLogin.Location = new System.Drawing.Point(43, 202);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(246, 24);
            this.txtLogin.TabIndex = 44;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(40, 182);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 18);
            this.label21.TabIndex = 43;
            this.label21.Text = "Login :";
            // 
            // chkAuthentication
            // 
            this.chkAuthentication.AutoSize = true;
            this.chkAuthentication.BackColor = System.Drawing.Color.Transparent;
            this.chkAuthentication.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAuthentication.Location = new System.Drawing.Point(370, 126);
            this.chkAuthentication.Name = "chkAuthentication";
            this.chkAuthentication.Size = new System.Drawing.Size(149, 22);
            this.chkAuthentication.TabIndex = 42;
            this.chkAuthentication.Text = "Use authentication";
            this.chkAuthentication.UseVisualStyleBackColor = false;
            this.chkAuthentication.CheckedChanged += new System.EventHandler(this.chkAuthentication_CheckedChanged);
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.BackColor = System.Drawing.Color.Transparent;
            this.chkSSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSSL.Location = new System.Drawing.Point(43, 126);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(193, 22);
            this.chkSSL.TabIndex = 41;
            this.chkSSL.Text = "Use Secured Connection";
            this.chkSSL.UseVisualStyleBackColor = false;
            // 
            // txtport
            // 
            this.txtport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.txtport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtport.ForeColor = System.Drawing.Color.White;
            this.txtport.Location = new System.Drawing.Point(356, 62);
            this.txtport.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtport.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(246, 24);
            this.txtport.TabIndex = 38;
            this.txtport.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // txthost
            // 
            this.txthost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.txthost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthost.ForeColor = System.Drawing.Color.White;
            this.txthost.Location = new System.Drawing.Point(43, 61);
            this.txthost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(246, 24);
            this.txthost.TabIndex = 37;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(40, 39);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 18);
            this.label24.TabIndex = 36;
            this.label24.Text = "SMTP host :";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(438, 372);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(165, 38);
            this.button8.TabIndex = 35;
            this.button8.Text = "Test Server";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.label29);
            this.pnlHome.Controls.Add(this.pictureBox1);
            this.pnlHome.Controls.Add(this.label30);
            this.pnlHome.Location = new System.Drawing.Point(230, 77);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(685, 461);
            this.pnlHome.TabIndex = 11;
            this.pnlHome.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHome_Paint);
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(35, 310);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(602, 116);
            this.label29.TabIndex = 35;
            this.label29.Text = "Welcome to MailMax, The most Advanced Email Bulk Sender with incredible features " +
    "and options.";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MailMax.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(253, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(166, 263);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(338, 24);
            this.label30.TabIndex = 33;
            this.label30.Text = "MailMax : Advanced Bulk Email Sender";
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.chkEnableVerification);
            this.pnlSettings.Controls.Add(this.label10);
            this.pnlSettings.Controls.Add(this.numSecondsWaitAfterXMessages);
            this.pnlSettings.Controls.Add(this.label9);
            this.pnlSettings.Controls.Add(this.numWaitSecondsAfterXMessages);
            this.pnlSettings.Controls.Add(this.label8);
            this.pnlSettings.Controls.Add(this.numSecondsBetweenMessages);
            this.pnlSettings.Controls.Add(this.label6);
            this.pnlSettings.Controls.Add(this.label5);
            this.pnlSettings.Controls.Add(this.label34);
            this.pnlSettings.Controls.Add(this.button3);
            this.pnlSettings.Location = new System.Drawing.Point(230, 77);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(685, 461);
            this.pnlSettings.TabIndex = 12;
            this.pnlSettings.Visible = false;
            // 
            // chkEnableVerification
            // 
            this.chkEnableVerification.AutoSize = true;
            this.chkEnableVerification.Checked = true;
            this.chkEnableVerification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableVerification.Location = new System.Drawing.Point(39, 238);
            this.chkEnableVerification.Name = "chkEnableVerification";
            this.chkEnableVerification.Size = new System.Drawing.Size(383, 22);
            this.chkEnableVerification.TabIndex = 46;
            this.chkEnableVerification.Text = "Enable email verification before send (Recommended)";
            this.chkEnableVerification.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(356, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 18);
            this.label10.TabIndex = 45;
            this.label10.Text = "emails sent";
            // 
            // numSecondsWaitAfterXMessages
            // 
            this.numSecondsWaitAfterXMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.numSecondsWaitAfterXMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSecondsWaitAfterXMessages.ForeColor = System.Drawing.Color.White;
            this.numSecondsWaitAfterXMessages.Location = new System.Drawing.Point(293, 181);
            this.numSecondsWaitAfterXMessages.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSecondsWaitAfterXMessages.Name = "numSecondsWaitAfterXMessages";
            this.numSecondsWaitAfterXMessages.Size = new System.Drawing.Size(57, 24);
            this.numSecondsWaitAfterXMessages.TabIndex = 44;
            this.numSecondsWaitAfterXMessages.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(147, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 18);
            this.label9.TabIndex = 43;
            this.label9.Text = "seconds after every ";
            // 
            // numWaitSecondsAfterXMessages
            // 
            this.numWaitSecondsAfterXMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.numWaitSecondsAfterXMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWaitSecondsAfterXMessages.ForeColor = System.Drawing.Color.White;
            this.numWaitSecondsAfterXMessages.Location = new System.Drawing.Point(84, 179);
            this.numWaitSecondsAfterXMessages.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWaitSecondsAfterXMessages.Name = "numWaitSecondsAfterXMessages";
            this.numWaitSecondsAfterXMessages.Size = new System.Drawing.Size(57, 24);
            this.numWaitSecondsAfterXMessages.TabIndex = 42;
            this.numWaitSecondsAfterXMessages.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 18);
            this.label8.TabIndex = 41;
            this.label8.Text = "Wait ";
            // 
            // numSecondsBetweenMessages
            // 
            this.numSecondsBetweenMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.numSecondsBetweenMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSecondsBetweenMessages.ForeColor = System.Drawing.Color.White;
            this.numSecondsBetweenMessages.Location = new System.Drawing.Point(308, 123);
            this.numSecondsBetweenMessages.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSecondsBetweenMessages.Name = "numSecondsBetweenMessages";
            this.numSecondsBetweenMessages.Size = new System.Drawing.Size(110, 24);
            this.numSecondsBetweenMessages.TabIndex = 40;
            this.numSecondsBetweenMessages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Seconds to wait after every email sent :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 2);
            this.label5.TabIndex = 37;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(34, 41);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(172, 25);
            this.label34.TabIndex = 36;
            this.label34.Text = "General Settings";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(510, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 38);
            this.button3.TabIndex = 35;
            this.button3.Text = "Save Changes";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tmrShow
            // 
            this.tmrShow.Enabled = true;
            this.tmrShow.Interval = 20;
            this.tmrShow.Tick += new System.EventHandler(this.tmrShow_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(920, 546);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEmailAutomation);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlSmtpTester);
            this.Controls.Add(this.pnlHome);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pnlMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlEmailAutomation.ResumeLayout(false);
            this.cntCamaigns.ResumeLayout(false);
            this.pnlSmtpTester.ResumeLayout(false);
            this.pnlSmtpTester.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtport)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSecondsWaitAfterXMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaitSecondsAfterXMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecondsBetweenMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSmtpTester;
        private System.Windows.Forms.Label lblEmailAutomation;
        private System.Windows.Forms.Panel pnlEmailAutomation;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListView lstCampaings;
        private System.Windows.Forms.ColumnHeader campaignName;
        private System.Windows.Forms.ColumnHeader Emails;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ContextMenuStrip cntCamaigns;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartCampaignToolStripMenuItem;
        private System.Windows.Forms.Panel pnlSmtpTester;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox chkAuthentication;
        private System.Windows.Forms.CheckBox chkSSL;
        private System.Windows.Forms.NumericUpDown txtport;
        private System.Windows.Forms.TextBox txthost;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblManageSMTP;
        private System.Windows.Forms.Label lbManageMessages;
        private System.Windows.Forms.Label lblMnageSources;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numSecondsWaitAfterXMessages;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numWaitSecondsAfterXMessages;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numSecondsBetweenMessages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkEnableVerification;
        private System.Windows.Forms.ToolStripMenuItem viewReportToolStripMenuItem;
        private System.Windows.Forms.Timer tmrShow;
    }
}

