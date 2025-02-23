namespace dentist
{
    partial class UCPatientInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            llRemoveImage = new LinkLabel();
            pbFemale = new PictureBox();
            pbMale = new PictureBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            label5 = new Label();
            pbName = new PictureBox();
            label10 = new Label();
            label7 = new Label();
            llSetImage = new LinkLabel();
            pbDateOfBirth = new PictureBox();
            pbPatientTC = new PictureBox();
            pbPhone = new PictureBox();
            dtpDateOfBirth = new DateTimePicker();
            txtPhone = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label1 = new Label();
            txtFirstName = new TextBox();
            pbPersonImage = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFemale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDateOfBirth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPatientTC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(llRemoveImage);
            groupBox1.Controls.Add(pbFemale);
            groupBox1.Controls.Add(pbMale);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(pbName);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(llSetImage);
            groupBox1.Controls.Add(pbDateOfBirth);
            groupBox1.Controls.Add(pbPatientTC);
            groupBox1.Controls.Add(pbPhone);
            groupBox1.Controls.Add(dtpDateOfBirth);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(pbPersonImage);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(4, 3);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(621, 343);
            groupBox1.TabIndex = 114;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prsonal Info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // llRemoveImage
            // 
            llRemoveImage.AutoSize = true;
            llRemoveImage.Location = new Point(433, 325);
            llRemoveImage.Margin = new Padding(4, 0, 4, 0);
            llRemoveImage.Name = "llRemoveImage";
            llRemoveImage.Size = new Size(50, 15);
            llRemoveImage.TabIndex = 112;
            llRemoveImage.TabStop = true;
            llRemoveImage.Text = "Remove";
            llRemoveImage.LinkClicked += llRemoveImage_LinkClicked_1;
            // 
            // pbFemale
            // 
            pbFemale.Image = Properties.Resources.Woman_32;
            pbFemale.Location = new Point(275, 223);
            pbFemale.Margin = new Padding(4, 3, 4, 3);
            pbFemale.Name = "pbFemale";
            pbFemale.Size = new Size(36, 30);
            pbFemale.SizeMode = PictureBoxSizeMode.Zoom;
            pbFemale.TabIndex = 110;
            pbFemale.TabStop = false;
            // 
            // pbMale
            // 
            pbMale.Image = Properties.Resources._25348792;
            pbMale.Location = new Point(149, 223);
            pbMale.Margin = new Padding(4, 3, 4, 3);
            pbMale.Name = "pbMale";
            pbMale.Size = new Size(36, 30);
            pbMale.SizeMode = PictureBoxSizeMode.Zoom;
            pbMale.TabIndex = 109;
            pbMale.TabStop = false;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Checked = true;
            rbFemale.Location = new Point(320, 226);
            rbFemale.Margin = new Padding(4, 3, 4, 3);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 8;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.Click += rbFemale_Click;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(198, 223);
            rbMale.Margin = new Padding(4, 3, 4, 3);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 7;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.Click += rbMale_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 223);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 106;
            label5.Text = "Gendor:";
            // 
            // pbName
            // 
            pbName.Image = Properties.Resources._25348791;
            pbName.Location = new Point(149, 65);
            pbName.Margin = new Padding(4, 3, 4, 3);
            pbName.Name = "pbName";
            pbName.Size = new Size(36, 30);
            pbName.SizeMode = PictureBoxSizeMode.Zoom;
            pbName.TabIndex = 105;
            pbName.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(477, 36);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 103;
            label10.Text = "Last";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(265, 38);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 100;
            label7.Text = "First";
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.Location = new Point(415, 300);
            llSetImage.Margin = new Padding(4, 0, 4, 0);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(59, 15);
            llSetImage.TabIndex = 13;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // pbDateOfBirth
            // 
            pbDateOfBirth.Image = Properties.Resources.Calendar_32;
            pbDateOfBirth.Location = new Point(149, 168);
            pbDateOfBirth.Margin = new Padding(4, 3, 4, 3);
            pbDateOfBirth.Name = "pbDateOfBirth";
            pbDateOfBirth.Size = new Size(36, 30);
            pbDateOfBirth.SizeMode = PictureBoxSizeMode.Zoom;
            pbDateOfBirth.TabIndex = 96;
            pbDateOfBirth.TabStop = false;
            // 
            // pbPatientTC
            // 
            pbPatientTC.Image = Properties.Resources._6565864;
            pbPatientTC.Location = new Point(149, 119);
            pbPatientTC.Margin = new Padding(4, 3, 4, 3);
            pbPatientTC.Name = "pbPatientTC";
            pbPatientTC.Size = new Size(36, 30);
            pbPatientTC.SizeMode = PictureBoxSizeMode.Zoom;
            pbPatientTC.TabIndex = 95;
            pbPatientTC.TabStop = false;
            // 
            // pbPhone
            // 
            pbPhone.Image = Properties.Resources.call_321;
            pbPhone.Location = new Point(148, 260);
            pbPhone.Margin = new Padding(4, 3, 4, 3);
            pbPhone.Name = "pbPhone";
            pbPhone.Size = new Size(36, 30);
            pbPhone.SizeMode = PictureBoxSizeMode.Zoom;
            pbPhone.TabIndex = 94;
            pbPhone.TabStop = false;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CustomFormat = "dd/M/yyyy";
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.Location = new Point(192, 166);
            dtpDateOfBirth.Margin = new Padding(4, 3, 4, 3);
            dtpDateOfBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(194, 23);
            dtpDateOfBirth.TabIndex = 6;
            dtpDateOfBirth.Value = new DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(192, 260);
            txtPhone.Margin = new Padding(5, 6, 5, 6);
            txtPhone.MaxLength = 50;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(194, 23);
            txtPhone.TabIndex = 9;
            txtPhone.Validating += ValidateEmptyTextBoxAndIsNumber;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 260);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 90;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 169);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 89;
            label3.Text = "Date Of Birth:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(194, 119);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 23);
            txtEmail.TabIndex = 5;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 119);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 88;
            label2.Text = "Email:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(414, 65);
            txtLastName.Margin = new Padding(5, 6, 5, 6);
            txtLastName.MaxLength = 50;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(194, 23);
            txtLastName.TabIndex = 4;
            txtLastName.Validating += ValidateEmptyTextBox;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 67);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 87;
            label1.Text = "Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(194, 67);
            txtFirstName.Margin = new Padding(5, 6, 5, 6);
            txtFirstName.MaxLength = 50;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(194, 23);
            txtFirstName.TabIndex = 1;
            txtFirstName.Validating += ValidateEmptyTextBox;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonImage.BorderStyle = BorderStyle.FixedSingle;
            pbPersonImage.Image = Properties.Resources.Female_512;
            pbPersonImage.InitialImage = null;
            pbPersonImage.Location = new Point(414, 102);
            pbPersonImage.Margin = new Padding(5, 6, 5, 6);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(197, 192);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 85;
            pbPersonImage.TabStop = false;
            pbPersonImage.Click += pbPersonImage_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // UCPatientInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UCPatientInfo";
            Size = new Size(629, 355);
            Load += UCPatientInfo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFemale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDateOfBirth).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPatientTC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbFemale;
        private System.Windows.Forms.PictureBox pbMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbDateOfBirth;
        private System.Windows.Forms.PictureBox pbPatientTC;
        private System.Windows.Forms.PictureBox pbPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.LinkLabel llRemoveImage;
        public System.Windows.Forms.RadioButton rbFemale;
        public System.Windows.Forms.RadioButton rbMale;
        public System.Windows.Forms.LinkLabel llSetImage;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.PictureBox pbPersonImage;
        public System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
