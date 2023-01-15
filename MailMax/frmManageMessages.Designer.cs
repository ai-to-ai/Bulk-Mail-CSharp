
namespace MailMax
{
    partial class frmManageMessages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageMessages));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstMessages = new System.Windows.Forms.ListView();
            this.MailName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteThisMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrShow = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 55);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Image = global::MailMax.Properties.Resources.Minimize;
            this.label4.Location = new System.Drawing.Point(593, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 30);
            this.label4.TabIndex = 3;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseLeave += new System.EventHandler(this.lblHoverEffect_MouseLeave);
            this.label4.MouseHover += new System.EventHandler(this.lblHoverEffect_MouseHover);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblHoverEffect_MouseMove);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Enabled = false;
            this.label3.Image = global::MailMax.Properties.Resources.Maximze;
            this.label3.Location = new System.Drawing.Point(631, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 30);
            this.label3.TabIndex = 2;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(668, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 30);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.lblHoverEffect_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.lblHoverEffect_MouseHover);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblHoverEffect_MouseMove);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(713, 55);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail Messages Settings";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstMessages
            // 
            this.lstMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.lstMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MailName,
            this.Date});
            this.lstMessages.ContextMenuStrip = this.contextMenuStrip1;
            this.lstMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMessages.ForeColor = System.Drawing.Color.White;
            this.lstMessages.FullRowSelect = true;
            this.lstMessages.HideSelection = false;
            this.lstMessages.Location = new System.Drawing.Point(12, 61);
            this.lstMessages.MultiSelect = false;
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(690, 381);
            this.lstMessages.TabIndex = 39;
            this.lstMessages.UseCompatibleStateImageBehavior = false;
            this.lstMessages.View = System.Windows.Forms.View.Details;
            // 
            // MailName
            // 
            this.MailName.Text = "Name";
            this.MailName.Width = 286;
            // 
            // Date
            // 
            this.Date.Text = "Date Updated";
            this.Date.Width = 195;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewMessageToolStripMenuItem,
            this.editThisToolStripMenuItem,
            this.deleteThisMessageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 70);
            // 
            // addNewMessageToolStripMenuItem
            // 
            this.addNewMessageToolStripMenuItem.Name = "addNewMessageToolStripMenuItem";
            this.addNewMessageToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addNewMessageToolStripMenuItem.Text = "Add new message";
            this.addNewMessageToolStripMenuItem.Click += new System.EventHandler(this.addNewMessageToolStripMenuItem_Click);
            // 
            // editThisToolStripMenuItem
            // 
            this.editThisToolStripMenuItem.Name = "editThisToolStripMenuItem";
            this.editThisToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.editThisToolStripMenuItem.Text = "Edit this message";
            this.editThisToolStripMenuItem.Click += new System.EventHandler(this.editThisToolStripMenuItem_Click);
            // 
            // deleteThisMessageToolStripMenuItem
            // 
            this.deleteThisMessageToolStripMenuItem.Name = "deleteThisMessageToolStripMenuItem";
            this.deleteThisMessageToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.deleteThisMessageToolStripMenuItem.Text = "Delete this message";
            this.deleteThisMessageToolStripMenuItem.Click += new System.EventHandler(this.deleteThisMessageToolStripMenuItem_Click);
            // 
            // tmrShow
            // 
            this.tmrShow.Enabled = true;
            this.tmrShow.Interval = 20;
            this.tmrShow.Tick += new System.EventHandler(this.tmrShow_Tick);
            // 
            // frmManageMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(713, 456);
            this.ControlBox = false;
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageMessages";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmManageMessages_Load);
            this.Resize += new System.EventHandler(this.frmManageMessages_Resize);
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstMessages;
        private System.Windows.Forms.ColumnHeader MailName;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editThisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteThisMessageToolStripMenuItem;
        private System.Windows.Forms.Timer tmrShow;
    }
}