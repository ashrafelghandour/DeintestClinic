using System.Windows.Forms;
using System;

namespace dentist.forms
{
    partial class FrmPatientsMenegment
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientsMenegment));
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btContact = new Bunifu.Framework.UI.BunifuThinButton2();
            btPrintAll = new Bunifu.Framework.UI.BunifuThinButton2();
            btPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            btBack = new Button();
            btUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            btAddPatient = new Bunifu.Framework.UI.BunifuThinButton2();
            dgvPatents = new DataGridView();
            cmsPatient = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            lbll = new Label();
            lblRecordsCount = new Label();
            pnlButensSend = new Panel();
            btWhatsapp = new Bunifu.Framework.UI.BunifuThinButton2();
            btSMS = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatents).BeginInit();
            cmsPatient.SuspendLayout();
            pnlButensSend.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1270, -1);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(-4, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1302, 100);
            panel3.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(521, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 23);
            label1.TabIndex = 30;
            label1.Text = "Patinets Menegment";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btContact);
            panel2.Controls.Add(btPrintAll);
            panel2.Controls.Add(btPrint);
            panel2.Controls.Add(btBack);
            panel2.Controls.Add(btUpdate);
            panel2.Controls.Add(btAddPatient);
            panel2.Location = new Point(-4, 908);
            panel2.Name = "panel2";
            panel2.Size = new Size(1302, 100);
            panel2.TabIndex = 32;
            // 
            // btContact
            // 
            btContact.ActiveBorderThickness = 1;
            btContact.ActiveCornerRadius = 20;
            btContact.ActiveFillColor = Color.PowderBlue;
            btContact.ActiveForecolor = Color.Thistle;
            btContact.ActiveLineColor = Color.SeaGreen;
            btContact.BackColor = Color.FromArgb(64, 64, 64);
            btContact.BackgroundImage = (Image)resources.GetObject("btContact.BackgroundImage");
            btContact.BackgroundImageLayout = ImageLayout.Stretch;
            btContact.ButtonText = "Contact";
            btContact.Cursor = Cursors.Hand;
            btContact.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btContact.ForeColor = Color.Gray;
            btContact.IdleBorderThickness = 1;
            btContact.IdleCornerRadius = 20;
            btContact.IdleFillColor = Color.White;
            btContact.IdleForecolor = Color.SeaGreen;
            btContact.IdleLineColor = Color.SeaGreen;
            btContact.Location = new Point(625, 16);
            btContact.Margin = new Padding(6);
            btContact.Name = "btContact";
            btContact.Size = new Size(102, 76);
            btContact.TabIndex = 133;
            btContact.TextAlign = ContentAlignment.MiddleCenter;
            btContact.Click += bunifuThinButton21_Click_1;
            // 
            // btPrintAll
            // 
            btPrintAll.ActiveBorderThickness = 1;
            btPrintAll.ActiveCornerRadius = 20;
            btPrintAll.ActiveFillColor = Color.SeaGreen;
            btPrintAll.ActiveForecolor = Color.White;
            btPrintAll.ActiveLineColor = Color.SeaGreen;
            btPrintAll.BackColor = Color.FromArgb(64, 64, 64);
            btPrintAll.BackgroundImage = (Image)resources.GetObject("btPrintAll.BackgroundImage");
            btPrintAll.ButtonText = "Print All";
            btPrintAll.Cursor = Cursors.Hand;
            btPrintAll.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btPrintAll.ForeColor = Color.SeaGreen;
            btPrintAll.IdleBorderThickness = 1;
            btPrintAll.IdleCornerRadius = 20;
            btPrintAll.IdleFillColor = Color.White;
            btPrintAll.IdleForecolor = Color.SeaGreen;
            btPrintAll.IdleLineColor = Color.SeaGreen;
            btPrintAll.Location = new Point(1097, 12);
            btPrintAll.Margin = new Padding(6);
            btPrintAll.Name = "btPrintAll";
            btPrintAll.Size = new Size(99, 76);
            btPrintAll.TabIndex = 132;
            btPrintAll.TextAlign = ContentAlignment.MiddleCenter;
            btPrintAll.Click += bunifuThinButton21_Click;
            // 
            // btPrint
            // 
            btPrint.ActiveBorderThickness = 1;
            btPrint.ActiveCornerRadius = 20;
            btPrint.ActiveFillColor = Color.SeaGreen;
            btPrint.ActiveForecolor = Color.White;
            btPrint.ActiveLineColor = Color.SeaGreen;
            btPrint.BackColor = Color.FromArgb(64, 64, 64);
            btPrint.BackgroundImage = (Image)resources.GetObject("btPrint.BackgroundImage");
            btPrint.ButtonText = "Print";
            btPrint.Cursor = Cursors.Hand;
            btPrint.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btPrint.ForeColor = Color.SeaGreen;
            btPrint.IdleBorderThickness = 1;
            btPrint.IdleCornerRadius = 20;
            btPrint.IdleFillColor = Color.White;
            btPrint.IdleForecolor = Color.SeaGreen;
            btPrint.IdleLineColor = Color.SeaGreen;
            btPrint.Location = new Point(986, 12);
            btPrint.Margin = new Padding(6);
            btPrint.Name = "btPrint";
            btPrint.Size = new Size(99, 76);
            btPrint.TabIndex = 127;
            btPrint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btBack
            // 
            btBack.BackgroundImageLayout = ImageLayout.Stretch;
            btBack.Image = (Image)resources.GetObject("btBack.Image");
            btBack.ImageAlign = ContentAlignment.MiddleLeft;
            btBack.Location = new Point(1205, 28);
            btBack.Name = "btBack";
            btBack.Size = new Size(86, 32);
            btBack.TabIndex = 130;
            btBack.Text = "Back";
            btBack.TextAlign = ContentAlignment.MiddleRight;
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btSave_Click;
            // 
            // btUpdate
            // 
            btUpdate.ActiveBorderThickness = 1;
            btUpdate.ActiveCornerRadius = 20;
            btUpdate.ActiveFillColor = Color.Wheat;
            btUpdate.ActiveForecolor = Color.Yellow;
            btUpdate.ActiveLineColor = Color.Sienna;
            btUpdate.BackColor = Color.FromArgb(64, 64, 64);
            btUpdate.BackgroundImage = (Image)resources.GetObject("btUpdate.BackgroundImage");
            btUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            btUpdate.ButtonText = "Update";
            btUpdate.Cursor = Cursors.Hand;
            btUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btUpdate.ForeColor = Color.OrangeRed;
            btUpdate.IdleBorderThickness = 1;
            btUpdate.IdleCornerRadius = 20;
            btUpdate.IdleFillColor = Color.White;
            btUpdate.IdleForecolor = Color.Sienna;
            btUpdate.IdleLineColor = Color.SeaShell;
            btUpdate.Location = new Point(875, 16);
            btUpdate.Margin = new Padding(6);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(99, 76);
            btUpdate.TabIndex = 125;
            btUpdate.TabStop = false;
            btUpdate.TextAlign = ContentAlignment.MiddleCenter;
            btUpdate.Click += btUpdate_Click;
            // 
            // btAddPatient
            // 
            btAddPatient.ActiveBorderThickness = 1;
            btAddPatient.ActiveCornerRadius = 20;
            btAddPatient.ActiveFillColor = Color.PowderBlue;
            btAddPatient.ActiveForecolor = Color.Thistle;
            btAddPatient.ActiveLineColor = Color.SeaGreen;
            btAddPatient.BackColor = Color.FromArgb(64, 64, 64);
            btAddPatient.BackgroundImage = (Image)resources.GetObject("btAddPatient.BackgroundImage");
            btAddPatient.BackgroundImageLayout = ImageLayout.Stretch;
            btAddPatient.ButtonText = "Add";
            btAddPatient.Cursor = Cursors.Hand;
            btAddPatient.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddPatient.ForeColor = Color.Gray;
            btAddPatient.IdleBorderThickness = 1;
            btAddPatient.IdleCornerRadius = 20;
            btAddPatient.IdleFillColor = Color.White;
            btAddPatient.IdleForecolor = Color.SeaGreen;
            btAddPatient.IdleLineColor = Color.SeaGreen;
            btAddPatient.Location = new Point(761, 16);
            btAddPatient.Margin = new Padding(6);
            btAddPatient.Name = "btAddPatient";
            btAddPatient.Size = new Size(102, 76);
            btAddPatient.TabIndex = 129;
            btAddPatient.TextAlign = ContentAlignment.MiddleCenter;
            btAddPatient.Click += btAddPatient_Click;
            // 
            // dgvPatents
            // 
            dgvPatents.BackgroundColor = Color.White;
            dgvPatents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatents.ContextMenuStrip = cmsPatient;
            dgvPatents.Location = new Point(12, 106);
            dgvPatents.Name = "dgvPatents";
            dgvPatents.Size = new Size(1276, 589);
            dgvPatents.TabIndex = 33;
            dgvPatents.CellContentClick += dgvPatents_CellContentClick;
            // 
            // cmsPatient
            // 
            cmsPatient.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, updateToolStripMenuItem, addToolStripMenuItem });
            cmsPatient.Name = "contextMenuStrip1";
            cmsPatient.Size = new Size(113, 70);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(112, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(112, 22);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(112, 22);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(44, 729);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 31;
            label2.Text = "Filter By :";
            // 
            // cbFilterBy
            // 
            cbFilterBy.BackColor = SystemColors.ScrollBar;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "Patinet ID", "Patient TC" });
            cbFilterBy.Location = new Point(128, 730);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(149, 23);
            cbFilterBy.TabIndex = 34;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(283, 730);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(147, 23);
            txtFilterValue.TabIndex = 35;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // lbll
            // 
            lbll.AutoSize = true;
            lbll.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbll.ForeColor = Color.DarkSlateGray;
            lbll.Location = new Point(1024, 730);
            lbll.Margin = new Padding(4, 0, 4, 0);
            lbll.Name = "lbll";
            lbll.Size = new Size(118, 19);
            lbll.TabIndex = 36;
            lbll.Text = "Records Count:";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordsCount.ForeColor = Color.DarkSlateGray;
            lblRecordsCount.Location = new Point(1150, 729);
            lblRecordsCount.Margin = new Padding(4, 0, 4, 0);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(118, 19);
            lblRecordsCount.TabIndex = 37;
            lblRecordsCount.Text = "Records Count:";
            // 
            // pnlButensSend
            // 
            pnlButensSend.Controls.Add(btWhatsapp);
            pnlButensSend.Controls.Add(btSMS);
            pnlButensSend.Location = new Point(612, 729);
            pnlButensSend.Name = "pnlButensSend";
            pnlButensSend.Size = new Size(117, 182);
            pnlButensSend.TabIndex = 133;
            pnlButensSend.Visible = false;
            // 
            // btWhatsapp
            // 
            btWhatsapp.ActiveBorderThickness = 1;
            btWhatsapp.ActiveCornerRadius = 20;
            btWhatsapp.ActiveFillColor = Color.PowderBlue;
            btWhatsapp.ActiveForecolor = Color.Thistle;
            btWhatsapp.ActiveLineColor = Color.SeaGreen;
            btWhatsapp.BackColor = Color.DarkGray;
            btWhatsapp.BackgroundImage = (Image)resources.GetObject("btWhatsapp.BackgroundImage");
            btWhatsapp.BackgroundImageLayout = ImageLayout.Stretch;
            btWhatsapp.ButtonText = "Whatsapp";
            btWhatsapp.Cursor = Cursors.Hand;
            btWhatsapp.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btWhatsapp.ForeColor = Color.Gray;
            btWhatsapp.IdleBorderThickness = 1;
            btWhatsapp.IdleCornerRadius = 20;
            btWhatsapp.IdleFillColor = Color.White;
            btWhatsapp.IdleForecolor = Color.SeaGreen;
            btWhatsapp.IdleLineColor = Color.SeaGreen;
            btWhatsapp.Location = new Point(6, 1);
            btWhatsapp.Margin = new Padding(6);
            btWhatsapp.Name = "btWhatsapp";
            btWhatsapp.Size = new Size(102, 76);
            btWhatsapp.TabIndex = 135;
            btWhatsapp.TextAlign = ContentAlignment.MiddleCenter;
            btWhatsapp.Click += btWhatsapp_Click;
            // 
            // btSMS
            // 
            btSMS.ActiveBorderThickness = 1;
            btSMS.ActiveCornerRadius = 20;
            btSMS.ActiveFillColor = Color.PowderBlue;
            btSMS.ActiveForecolor = Color.Thistle;
            btSMS.ActiveLineColor = Color.SeaGreen;
            btSMS.BackColor = Color.DarkGray;
            btSMS.BackgroundImage = (Image)resources.GetObject("btSMS.BackgroundImage");
            btSMS.BackgroundImageLayout = ImageLayout.Stretch;
            btSMS.ButtonText = "SMS";
            btSMS.Cursor = Cursors.Hand;
            btSMS.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSMS.ForeColor = Color.Gray;
            btSMS.IdleBorderThickness = 1;
            btSMS.IdleCornerRadius = 20;
            btSMS.IdleFillColor = Color.White;
            btSMS.IdleForecolor = Color.SeaGreen;
            btSMS.IdleLineColor = Color.SeaGreen;
            btSMS.Location = new Point(9, 94);
            btSMS.Margin = new Padding(6);
            btSMS.Name = "btSMS";
            btSMS.Size = new Size(102, 76);
            btSMS.TabIndex = 134;
            btSMS.TextAlign = ContentAlignment.MiddleCenter;
            btSMS.Click += btSMS_Click;
            // 
            // FrmPatientsMenegment
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1300, 1003);
            Controls.Add(pnlButensSend);
            Controls.Add(lblRecordsCount);
            Controls.Add(lbll);
            Controls.Add(txtFilterValue);
            Controls.Add(cbFilterBy);
            Controls.Add(label2);
            Controls.Add(dgvPatents);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmPatientsMenegment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmHome";
            WindowState = FormWindowState.Maximized;
            Load += FrmPatientsMenegment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPatents).EndInit();
            cmsPatient.ResumeLayout(false);
            pnlButensSend.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private DataGridView dgvPatents;
        private Bunifu.Framework.UI.BunifuThinButton2 btPrint;
        private Button btBack;
        private Bunifu.Framework.UI.BunifuThinButton2 btUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btAddPatient;
        private Bunifu.Framework.UI.BunifuThinButton2 btPrintAll;
        private Label label2;
        private ComboBox cbFilterBy;
        private TextBox txtFilterValue;
        private Label lbll;
        private Label lblRecordsCount;
        private ContextMenuStrip cmsPatient;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuThinButton2 btContact;
        private Panel pnlButensSend;
        private Bunifu.Framework.UI.BunifuThinButton2 btSMS;
        private Bunifu.Framework.UI.BunifuThinButton2 btWhatsapp;
    }
}