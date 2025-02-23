namespace dentist.forms
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            lbDateTime = new Label();
            lbDateTimeLong = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btscrenLogen = new Bunifu.Framework.UI.BunifuThinButton2();
            pictureBox2 = new PictureBox();
            btNewPatinent = new Button();
            btPatientsMenegent = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbDateTime
            // 
            lbDateTime.AutoSize = true;
            lbDateTime.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDateTime.Location = new Point(1240, 72);
            lbDateTime.Margin = new Padding(4, 0, 4, 0);
            lbDateTime.Name = "lbDateTime";
            lbDateTime.Size = new Size(55, 18);
            lbDateTime.TabIndex = 2;
            lbDateTime.Text = "label1";
            // 
            // lbDateTimeLong
            // 
            lbDateTimeLong.AutoSize = true;
            lbDateTimeLong.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDateTimeLong.Location = new Point(1225, 28);
            lbDateTimeLong.Margin = new Padding(4, 0, 4, 0);
            lbDateTimeLong.Name = "lbDateTimeLong";
            lbDateTimeLong.Size = new Size(45, 16);
            lbDateTimeLong.TabIndex = 3;
            lbDateTimeLong.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(13, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 23);
            label1.TabIndex = 18;
            label1.Text = "Dr : Aml EL Ghandour";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Tan;
            label2.Location = new Point(48, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 23);
            label2.TabIndex = 22;
            label2.Text = "T \\012115266";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btscrenLogen);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbDateTime);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lbDateTimeLong);
            panel1.Location = new Point(2, 906);
            panel1.Name = "panel1";
            panel1.Size = new Size(1302, 100);
            panel1.TabIndex = 24;
            // 
            // btscrenLogen
            // 
            btscrenLogen.ActiveBorderThickness = 1;
            btscrenLogen.ActiveCornerRadius = 20;
            btscrenLogen.ActiveFillColor = Color.SeaGreen;
            btscrenLogen.ActiveForecolor = Color.White;
            btscrenLogen.ActiveLineColor = Color.SeaGreen;
            btscrenLogen.BackColor = Color.FromArgb(64, 64, 64);
            btscrenLogen.BackgroundImage = (Image)resources.GetObject("btscrenLogen.BackgroundImage");
            btscrenLogen.ButtonText = "Home Page";
            btscrenLogen.Cursor = Cursors.Hand;
            btscrenLogen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btscrenLogen.ForeColor = Color.SeaGreen;
            btscrenLogen.IdleBorderThickness = 1;
            btscrenLogen.IdleCornerRadius = 20;
            btscrenLogen.IdleFillColor = Color.White;
            btscrenLogen.IdleForecolor = Color.SeaGreen;
            btscrenLogen.IdleLineColor = Color.SeaGreen;
            btscrenLogen.Location = new Point(468, 43);
            btscrenLogen.Margin = new Padding(6);
            btscrenLogen.Name = "btscrenLogen";
            btscrenLogen.Size = new Size(163, 38);
            btscrenLogen.TabIndex = 30;
            btscrenLogen.TextAlign = ContentAlignment.MiddleCenter;
            btscrenLogen.Click += btscrenLogen_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources._3416079;
            pictureBox2.Location = new Point(1265, 1);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btNewPatinent
            // 
            btNewPatinent.BackgroundImage = (Image)resources.GetObject("btNewPatinent.BackgroundImage");
            btNewPatinent.BackgroundImageLayout = ImageLayout.Stretch;
            btNewPatinent.FlatStyle = FlatStyle.Flat;
            btNewPatinent.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btNewPatinent.ForeColor = Color.Black;
            btNewPatinent.Location = new Point(2, 138);
            btNewPatinent.Name = "btNewPatinent";
            btNewPatinent.Size = new Size(102, 112);
            btNewPatinent.TabIndex = 29;
            btNewPatinent.Text = "New Patinet";
            btNewPatinent.TextAlign = ContentAlignment.BottomCenter;
            btNewPatinent.UseVisualStyleBackColor = true;
            btNewPatinent.Click += button1_Click;
            // 
            // btPatientsMenegent
            // 
            btPatientsMenegent.BackgroundImage = (Image)resources.GetObject("btPatientsMenegent.BackgroundImage");
            btPatientsMenegent.BackgroundImageLayout = ImageLayout.Stretch;
            btPatientsMenegent.FlatStyle = FlatStyle.Flat;
            btPatientsMenegent.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btPatientsMenegent.ForeColor = Color.SlateGray;
            btPatientsMenegent.Location = new Point(2, 12);
            btPatientsMenegent.Name = "btPatientsMenegent";
            btPatientsMenegent.Size = new Size(102, 112);
            btPatientsMenegent.TabIndex = 30;
            btPatientsMenegent.Text = "Patients";
            btPatientsMenegent.TextAlign = ContentAlignment.BottomCenter;
            btPatientsMenegent.UseVisualStyleBackColor = true;
            btPatientsMenegent.Click += btPatientsMenegent_Click;
            // 
            // FrmHome
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1300, 1003);
            Controls.Add(btPatientsMenegent);
            Controls.Add(btNewPatinent);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmHome";
            WindowState = FormWindowState.Maximized;
            Load += FrmHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuTileButton btPatients;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Label lbDateTimeLong;
        private Bunifu.Framework.UI.BunifuTileButton btSetting;
        private Bunifu.Framework.UI.BunifuTileButton btSpending;
        private Bunifu.Framework.UI.BunifuTileButton btIncome;
        private Bunifu.Framework.UI.BunifuTileButton btStaffMane;
        private Bunifu.Framework.UI.BunifuTileButton btNewStaff;
        private Bunifu.Framework.UI.BunifuTileButton btPatientManegment;
        private Bunifu.Framework.UI.BunifuTileButton btPatient;
        private Bunifu.Framework.UI.BunifuTileButton btConsumption;
        private Bunifu.Framework.UI.BunifuTileButton btStaffs;
        private Bunifu.Framework.UI.BunifuTileButton btEarnsDebts;
        private Bunifu.Framework.UI.BunifuTileButton btDebts;
        private Bunifu.Framework.UI.BunifuTileButton btEames;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton btLanguge;
        private Bunifu.Framework.UI.BunifuTileButton btPackup;
        private Bunifu.Framework.UI.BunifuFlatButton btHome;
        private System.Windows.Forms.Label label2;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button btNewPatinent;
        private Bunifu.Framework.UI.BunifuThinButton2 btscrenLogen;
        private Button btPatientsMenegent;
    }
}