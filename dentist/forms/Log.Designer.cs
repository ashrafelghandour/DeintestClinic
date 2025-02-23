namespace dentist
{
    partial class FrmLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLog));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tbUserName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pbOpenEye = new PictureBox();
            btForgetPassw = new Bunifu.Framework.UI.BunifuThinButton2();
            btLog = new Bunifu.Framework.UI.BunifuThinButton2();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pbClose_Eye = new PictureBox();
            pictureBox1 = new PictureBox();
            tbPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            rbAdmin = new RadioButton();
            groupBox1 = new GroupBox();
            rdUser = new RadioButton();
            chkRememberMe = new CheckBox();
            chbShowPass = new CheckBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbOpenEye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose_Eye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(332, 158);
            tbUserName.Margin = new Padding(4, 3, 4, 3);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(163, 23);
            tbUserName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 136);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 3;
            label1.Text = "User Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 121);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 16);
            label3.TabIndex = 7;
            label3.Text = "Dr : Aml El Ghandour";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 208);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 6;
            label2.Text = "password : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(484, 108);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 16);
            label4.TabIndex = 10;
            label4.Text = "Creating Beautifful ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(484, 136);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 16);
            label5.TabIndex = 11;
            label5.Text = "Natural Results";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pbOpenEye
            // 
            pbOpenEye.Image = Properties.Resources._159604;
            pbOpenEye.Location = new Point(444, 210);
            pbOpenEye.Margin = new Padding(4, 3, 4, 3);
            pbOpenEye.Name = "pbOpenEye";
            pbOpenEye.Size = new Size(33, 23);
            pbOpenEye.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOpenEye.TabIndex = 21;
            pbOpenEye.TabStop = false;
            // 
            // btForgetPassw
            // 
            btForgetPassw.ActiveBorderThickness = 1;
            btForgetPassw.ActiveCornerRadius = 20;
            btForgetPassw.ActiveFillColor = Color.SeaGreen;
            btForgetPassw.ActiveForecolor = Color.White;
            btForgetPassw.ActiveLineColor = Color.SeaGreen;
            btForgetPassw.BackColor = Color.Tan;
            btForgetPassw.BackgroundImage = (Image)resources.GetObject("btForgetPassw.BackgroundImage");
            btForgetPassw.ButtonText = " Forget Passwred";
            btForgetPassw.Cursor = Cursors.Hand;
            btForgetPassw.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btForgetPassw.ForeColor = Color.SeaGreen;
            btForgetPassw.IdleBorderThickness = 1;
            btForgetPassw.IdleCornerRadius = 20;
            btForgetPassw.IdleFillColor = Color.White;
            btForgetPassw.IdleForecolor = Color.SeaGreen;
            btForgetPassw.IdleLineColor = Color.SeaGreen;
            btForgetPassw.Location = new Point(332, 350);
            btForgetPassw.Margin = new Padding(6);
            btForgetPassw.Name = "btForgetPassw";
            btForgetPassw.Size = new Size(163, 38);
            btForgetPassw.TabIndex = 20;
            btForgetPassw.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btLog
            // 
            btLog.ActiveBorderThickness = 1;
            btLog.ActiveCornerRadius = 20;
            btLog.ActiveFillColor = Color.SeaGreen;
            btLog.ActiveForecolor = Color.White;
            btLog.ActiveLineColor = Color.SeaGreen;
            btLog.BackColor = Color.Tan;
            btLog.BackgroundImage = (Image)resources.GetObject("btLog.BackgroundImage");
            btLog.ButtonText = "Log in";
            btLog.Cursor = Cursors.Hand;
            btLog.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLog.ForeColor = Color.SeaGreen;
            btLog.IdleBorderThickness = 1;
            btLog.IdleCornerRadius = 20;
            btLog.IdleFillColor = Color.White;
            btLog.IdleForecolor = Color.SeaGreen;
            btLog.IdleLineColor = Color.SeaGreen;
            btLog.Location = new Point(332, 300);
            btLog.Margin = new Padding(6);
            btLog.Name = "btLog";
            btLog.Size = new Size(163, 38);
            btLog.TabIndex = 19;
            btLog.TextAlign = ContentAlignment.MiddleCenter;
            btLog.Click += btLog_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._2905841;
            pictureBox5.Location = new Point(468, 5);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 88);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._2441077;
            pictureBox4.Location = new Point(332, 5);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 88);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._9706582;
            pictureBox3.Location = new Point(444, 121);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pbClose_Eye
            // 
            pbClose_Eye.Image = (Image)resources.GetObject("pbClose_Eye.Image");
            pbClose_Eye.Location = new Point(444, 210);
            pbClose_Eye.Margin = new Padding(4, 3, 4, 3);
            pbClose_Eye.Name = "pbClose_Eye";
            pbClose_Eye.Size = new Size(33, 23);
            pbClose_Eye.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClose_Eye.TabIndex = 4;
            pbClose_Eye.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 158);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tbPass
            // 
            tbPass.BackColor = Color.White;
            tbPass.Cursor = Cursors.IBeam;
            tbPass.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.World);
            tbPass.ForeColor = Color.FromArgb(64, 64, 64);
            tbPass.HintForeColor = Color.Empty;
            tbPass.HintText = "";
            tbPass.isPassword = true;
            tbPass.LineFocusedColor = Color.Blue;
            tbPass.LineIdleColor = Color.Gray;
            tbPass.LineMouseHoverColor = Color.Blue;
            tbPass.LineThickness = 3;
            tbPass.Location = new Point(332, 237);
            tbPass.Margin = new Padding(5);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(163, 25);
            tbPass.TabIndex = 22;
            tbPass.TextAlign = HorizontalAlignment.Left;
            // 
            // rbAdmin
            // 
            rbAdmin.AutoSize = true;
            rbAdmin.Location = new Point(7, 55);
            rbAdmin.Margin = new Padding(4, 3, 4, 3);
            rbAdmin.Name = "rbAdmin";
            rbAdmin.Size = new Size(61, 19);
            rbAdmin.TabIndex = 23;
            rbAdmin.Text = "Admin";
            rbAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdUser);
            groupBox1.Controls.Add(rbAdmin);
            groupBox1.Location = new Point(510, 171);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(114, 95);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // rdUser
            // 
            rdUser.AutoSize = true;
            rdUser.Checked = true;
            rdUser.Location = new Point(7, 22);
            rdUser.Margin = new Padding(4, 3, 4, 3);
            rdUser.Name = "rdUser";
            rdUser.Size = new Size(48, 19);
            rdUser.TabIndex = 24;
            rdUser.TabStop = true;
            rdUser.Text = "User";
            rdUser.UseVisualStyleBackColor = true;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Location = new Point(464, 272);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(104, 19);
            chkRememberMe.TabIndex = 25;
            chkRememberMe.Text = "Remember Me";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // chbShowPass
            // 
            chbShowPass.AutoSize = true;
            chbShowPass.Checked = true;
            chbShowPass.CheckState = CheckState.Checked;
            chbShowPass.Location = new Point(332, 272);
            chbShowPass.Name = "chbShowPass";
            chbShowPass.Size = new Size(81, 19);
            chbShowPass.TabIndex = 26;
            chbShowPass.Text = "Show Pass";
            chbShowPass.UseVisualStyleBackColor = true;
            chbShowPass.CheckedChanged += chbShowPass_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources._3416079;
            pictureBox2.Location = new Point(603, 350);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FrmLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(644, 402);
            Controls.Add(pictureBox2);
            Controls.Add(chbShowPass);
            Controls.Add(chkRememberMe);
            Controls.Add(groupBox1);
            Controls.Add(tbPass);
            Controls.Add(pbOpenEye);
            Controls.Add(btForgetPassw);
            Controls.Add(btLog);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pbClose_Eye);
            Controls.Add(label1);
            Controls.Add(tbUserName);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmLog_Load;
            ((System.ComponentModel.ISupportInitialize)pbOpenEye).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose_Eye).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbClose_Eye;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 btLog;
        private Bunifu.Framework.UI.BunifuThinButton2 btForgetPassw;
        private System.Windows.Forms.PictureBox pbOpenEye;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPass;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdUser;
        private CheckBox chkRememberMe;
        private CheckBox chbShowPass;
        private PictureBox pictureBox2;
    }
}

