namespace dentist.forms
{
    partial class FrmAddUpdatePatinet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUpdatePatinet));
            label22 = new Label();
            lbDateTimeLong = new Label();
            lbDateTime = new Label();
            pictureBox10 = new PictureBox();
            panel1 = new Panel();
            tbPatientid = new TextBox();
            btClose = new Button();
            btSave = new Button();
            btAddPatient = new Bunifu.Framework.UI.BunifuThinButton2();
            btSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            btDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            btUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            pictureBox2 = new PictureBox();
            ucExtraInfo1 = new UCExtraInfo();
            lblTitle = new Label();
            llPatinetid = new Label();
            lbPatientID = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(11, 100);
            label22.Margin = new Padding(5, 0, 5, 0);
            label22.Name = "label22";
            label22.Size = new Size(90, 20);
            label22.TabIndex = 124;
            label22.Text = "Patint ID :";
            // 
            // lbDateTimeLong
            // 
            lbDateTimeLong.AutoSize = true;
            lbDateTimeLong.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDateTimeLong.Location = new Point(15, 644);
            lbDateTimeLong.Margin = new Padding(4, 0, 4, 0);
            lbDateTimeLong.Name = "lbDateTimeLong";
            lbDateTimeLong.Size = new Size(45, 16);
            lbDateTimeLong.TabIndex = 123;
            lbDateTimeLong.Text = "label1";
            // 
            // lbDateTime
            // 
            lbDateTime.AutoSize = true;
            lbDateTime.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDateTime.Location = new Point(30, 687);
            lbDateTime.Margin = new Padding(4, 0, 4, 0);
            lbDateTime.Name = "lbDateTime";
            lbDateTime.Size = new Size(55, 18);
            lbDateTime.TabIndex = 122;
            lbDateTime.Text = "label1";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.id_card_sign_icon_identity_card_badge_symbol_vector_2873815;
            pictureBox10.Location = new Point(154, 93);
            pictureBox10.Margin = new Padding(4, 3, 4, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(36, 30);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 126;
            pictureBox10.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(tbPatientid);
            panel1.Controls.Add(btClose);
            panel1.Controls.Add(btSave);
            panel1.Controls.Add(btAddPatient);
            panel1.Controls.Add(btSearch);
            panel1.Controls.Add(btDelete);
            panel1.Controls.Add(btUpdate);
            panel1.Controls.Add(lbDateTimeLong);
            panel1.Controls.Add(lbDateTime);
            panel1.Location = new Point(649, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 717);
            panel1.TabIndex = 127;
            // 
            // tbPatientid
            // 
            tbPatientid.Location = new Point(45, 68);
            tbPatientid.Name = "tbPatientid";
            tbPatientid.Size = new Size(100, 23);
            tbPatientid.TabIndex = 134;
            tbPatientid.TextChanged += txbPatientid_TextChanged;
            // 
            // btClose
            // 
            btClose.Image = (Image)resources.GetObject("btClose.Image");
            btClose.ImageAlign = ContentAlignment.MiddleLeft;
            btClose.Location = new Point(3, 570);
            btClose.Name = "btClose";
            btClose.Size = new Size(86, 32);
            btClose.TabIndex = 131;
            btClose.Text = "Close";
            btClose.TextAlign = ContentAlignment.MiddleRight;
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.Image = Properties.Resources.Save_32;
            btSave.ImageAlign = ContentAlignment.MiddleLeft;
            btSave.Location = new Point(92, 570);
            btSave.Name = "btSave";
            btSave.Size = new Size(86, 32);
            btSave.TabIndex = 130;
            btSave.Text = "Save";
            btSave.TextAlign = ContentAlignment.MiddleRight;
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btAddPatient
            // 
            btAddPatient.ActiveBorderThickness = 1;
            btAddPatient.ActiveCornerRadius = 20;
            btAddPatient.ActiveFillColor = Color.PowderBlue;
            btAddPatient.ActiveForecolor = Color.Thistle;
            btAddPatient.ActiveLineColor = Color.SeaGreen;
            btAddPatient.BackColor = SystemColors.HotTrack;
            btAddPatient.BackgroundImage = (Image)resources.GetObject("btAddPatient.BackgroundImage");
            btAddPatient.ButtonText = "Add";
            btAddPatient.Cursor = Cursors.Hand;
            btAddPatient.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btAddPatient.ForeColor = Color.SeaGreen;
            btAddPatient.IdleBorderThickness = 1;
            btAddPatient.IdleCornerRadius = 20;
            btAddPatient.IdleFillColor = Color.White;
            btAddPatient.IdleForecolor = Color.SeaGreen;
            btAddPatient.IdleLineColor = Color.SeaGreen;
            btAddPatient.Location = new Point(15, 125);
            btAddPatient.Margin = new Padding(6);
            btAddPatient.Name = "btAddPatient";
            btAddPatient.Size = new Size(163, 76);
            btAddPatient.TabIndex = 129;
            btAddPatient.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btSearch
            // 
            btSearch.ActiveBorderThickness = 1;
            btSearch.ActiveCornerRadius = 20;
            btSearch.ActiveFillColor = Color.SeaGreen;
            btSearch.ActiveForecolor = Color.White;
            btSearch.ActiveLineColor = Color.SeaGreen;
            btSearch.BackColor = SystemColors.HotTrack;
            btSearch.BackgroundImage = (Image)resources.GetObject("btSearch.BackgroundImage");
            btSearch.ButtonText = "Search";
            btSearch.Cursor = Cursors.Hand;
            btSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSearch.ForeColor = Color.SeaGreen;
            btSearch.IdleBorderThickness = 1;
            btSearch.IdleCornerRadius = 20;
            btSearch.IdleFillColor = Color.White;
            btSearch.IdleForecolor = Color.SeaGreen;
            btSearch.IdleLineColor = Color.SeaGreen;
            btSearch.Location = new Point(15, 451);
            btSearch.Margin = new Padding(6);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(163, 84);
            btSearch.TabIndex = 127;
            btSearch.TextAlign = ContentAlignment.MiddleCenter;
            btSearch.Click += btSearch_Click;
            // 
            // btDelete
            // 
            btDelete.ActiveBorderThickness = 1;
            btDelete.ActiveCornerRadius = 20;
            btDelete.ActiveFillColor = Color.Red;
            btDelete.ActiveForecolor = Color.Red;
            btDelete.ActiveLineColor = Color.Red;
            btDelete.BackColor = SystemColors.HotTrack;
            btDelete.BackgroundImage = (Image)resources.GetObject("btDelete.BackgroundImage");
            btDelete.ButtonText = "Delete";
            btDelete.Cursor = Cursors.Hand;
            btDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDelete.ForeColor = Color.SeaGreen;
            btDelete.IdleBorderThickness = 1;
            btDelete.IdleCornerRadius = 20;
            btDelete.IdleFillColor = Color.White;
            btDelete.IdleForecolor = Color.Red;
            btDelete.IdleLineColor = Color.Tomato;
            btDelete.Location = new Point(15, 337);
            btDelete.Margin = new Padding(6);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(163, 80);
            btDelete.TabIndex = 126;
            btDelete.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btUpdate
            // 
            btUpdate.ActiveBorderThickness = 1;
            btUpdate.ActiveCornerRadius = 20;
            btUpdate.ActiveFillColor = Color.Wheat;
            btUpdate.ActiveForecolor = Color.Yellow;
            btUpdate.ActiveLineColor = Color.Sienna;
            btUpdate.BackColor = SystemColors.HotTrack;
            btUpdate.BackgroundImage = (Image)resources.GetObject("btUpdate.BackgroundImage");
            btUpdate.ButtonText = "Update";
            btUpdate.Cursor = Cursors.Hand;
            btUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btUpdate.ForeColor = Color.OrangeRed;
            btUpdate.IdleBorderThickness = 1;
            btUpdate.IdleCornerRadius = 20;
            btUpdate.IdleFillColor = Color.White;
            btUpdate.IdleForecolor = Color.Sienna;
            btUpdate.IdleLineColor = Color.SeaShell;
            btUpdate.Location = new Point(15, 230);
            btUpdate.Margin = new Padding(6);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(163, 76);
            btUpdate.TabIndex = 125;
            btUpdate.TabStop = false;
            btUpdate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources._3416079;
            pictureBox2.Location = new Point(812, 2);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 128;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // ucExtraInfo1
            // 
            ucExtraInfo1.Location = new Point(4, 46);
            ucExtraInfo1.Margin = new Padding(4, 3, 4, 3);
            ucExtraInfo1.Name = "ucExtraInfo1";
            ucExtraInfo1.Size = new Size(624, 717);
            ucExtraInfo1.TabIndex = 128;
            ucExtraInfo1.Load += ucExtraInfo1_Load;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Snap ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(255, 192, 255);
            lblTitle.Location = new Point(264, 18);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(115, 25);
            lblTitle.TabIndex = 132;
            lblTitle.Text = "Add New";
            // 
            // llPatinetid
            // 
            llPatinetid.AutoSize = true;
            llPatinetid.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llPatinetid.Location = new Point(13, 27);
            llPatinetid.Margin = new Padding(4, 0, 4, 0);
            llPatinetid.Name = "llPatinetid";
            llPatinetid.Size = new Size(73, 16);
            llPatinetid.TabIndex = 132;
            llPatinetid.Text = "PatientID:";
            // 
            // lbPatientID
            // 
            lbPatientID.AutoSize = true;
            lbPatientID.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPatientID.ForeColor = SystemColors.Info;
            lbPatientID.Location = new Point(94, 29);
            lbPatientID.Margin = new Padding(4, 0, 4, 0);
            lbPatientID.Name = "lbPatientID";
            lbPatientID.Size = new Size(15, 16);
            lbPatientID.TabIndex = 133;
            lbPatientID.Text = "0";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmAddUpdatePatinet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(842, 768);
            Controls.Add(lbPatientID);
            Controls.Add(llPatinetid);
            Controls.Add(lblTitle);
            Controls.Add(ucExtraInfo1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox10);
            Controls.Add(label22);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmAddUpdatePatinet";
            Text = "FrmAddNewPatinet";
            Load += FrmAddNewPatinet_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbDateTimeLong;
        private System.Windows.Forms.Label lbDateTime;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btDelete;
        private PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btAddPatient;
        private Button btClose;
        private Button btSave;
        private UCExtraInfo ucExtraInfo1;
        private Label lblTitle;
        private Label llPatinetid;
        private Label lbPatientID;
        private TextBox tbPatientid;
        private ErrorProvider errorProvider1;
    }
}