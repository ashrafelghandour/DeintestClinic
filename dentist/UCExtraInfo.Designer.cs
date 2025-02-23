namespace dentist
{
    partial class UCExtraInfo
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
            groupBox2 = new GroupBox();
            PBNotes = new PictureBox();
            CBState = new ComboBox();
            tbReind = new TextBox();
            label15 = new Label();
            tbPayed = new TextBox();
            label14 = new Label();
            tbCost = new TextBox();
            label13 = new Label();
            PBState = new PictureBox();
            label11 = new Label();
            PBDate = new PictureBox();
            dtDate = new DateTimePicker();
            label9 = new Label();
            TBNotes = new TextBox();
            label12 = new Label();
            txtPatinetTC = new TextBox();
            label6 = new Label();
            PBEmail = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ucPatientInfo1 = new UCPatientInfo();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBNotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBState).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PBNotes);
            groupBox2.Controls.Add(CBState);
            groupBox2.Controls.Add(tbReind);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(tbPayed);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(tbCost);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(PBState);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(PBDate);
            groupBox2.Controls.Add(dtDate);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(TBNotes);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtPatinetTC);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(PBEmail);
            groupBox2.Location = new Point(4, 387);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(612, 324);
            groupBox2.TabIndex = 114;
            groupBox2.TabStop = false;
            groupBox2.Text = "Extra info";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // PBNotes
            // 
            PBNotes.Image = Properties.Resources.ApplicationTitle;
            PBNotes.Location = new Point(134, 215);
            PBNotes.Margin = new Padding(4, 3, 4, 3);
            PBNotes.Name = "PBNotes";
            PBNotes.Size = new Size(36, 30);
            PBNotes.SizeMode = PictureBoxSizeMode.Zoom;
            PBNotes.TabIndex = 114;
            PBNotes.TabStop = false;
            // 
            // CBState
            // 
            CBState.FormattingEnabled = true;
            CBState.Location = new Point(180, 40);
            CBState.Margin = new Padding(4, 3, 4, 3);
            CBState.Name = "CBState";
            CBState.Size = new Size(160, 23);
            CBState.TabIndex = 113;
            // 
            // tbReind
            // 
            tbReind.Enabled = false;
            tbReind.Location = new Point(516, 180);
            tbReind.Margin = new Padding(5, 6, 5, 6);
            tbReind.MaxLength = 50;
            tbReind.Name = "tbReind";
            tbReind.ReadOnly = true;
            tbReind.Size = new Size(93, 23);
            tbReind.TabIndex = 110;
            tbReind.Validating += ValidateEmptyTextBoxAndIsNumbers;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(410, 180);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(75, 20);
            label15.TabIndex = 111;
            label15.Text = "Remind:";
            // 
            // tbPayed
            // 
            tbPayed.Location = new Point(295, 178);
            tbPayed.Margin = new Padding(5, 6, 5, 6);
            tbPayed.MaxLength = 50;
            tbPayed.Name = "tbPayed";
            tbPayed.Size = new Size(93, 23);
            tbPayed.TabIndex = 108;
            tbPayed.TextChanged += tbPayed_TextChanged;
            tbPayed.KeyUp += tbPayed_KeyUp;
            tbPayed.Validating += ValidateEmptyTextBoxAndIsNumbers;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(198, 175);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(63, 20);
            label14.TabIndex = 109;
            label14.Text = "Payed:";
            // 
            // tbCost
            // 
            tbCost.Location = new Point(78, 180);
            tbCost.Margin = new Padding(5, 6, 5, 6);
            tbCost.MaxLength = 50;
            tbCost.Name = "tbCost";
            tbCost.Size = new Size(93, 23);
            tbCost.TabIndex = 106;
            tbCost.TextChanged += tbCost_TextChanged;
            tbCost.Validating += ValidateEmptyTextBoxAndIsNumbers;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(9, 178);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(51, 20);
            label13.TabIndex = 107;
            label13.Text = "Cost:";
            // 
            // PBState
            // 
            PBState.Image = Properties.Resources._1077012;
            PBState.Location = new Point(134, 42);
            PBState.Margin = new Padding(4, 3, 4, 3);
            PBState.Name = "PBState";
            PBState.Size = new Size(36, 30);
            PBState.SizeMode = PictureBoxSizeMode.Zoom;
            PBState.TabIndex = 105;
            PBState.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(7, 42);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 104;
            label11.Text = "State:";
            // 
            // PBDate
            // 
            PBDate.Image = Properties.Resources._4444027;
            PBDate.Location = new Point(134, 78);
            PBDate.Margin = new Padding(4, 3, 4, 3);
            PBDate.Name = "PBDate";
            PBDate.Size = new Size(36, 30);
            PBDate.SizeMode = PictureBoxSizeMode.Zoom;
            PBDate.TabIndex = 102;
            PBDate.TabStop = false;
            // 
            // dtDate
            // 
            dtDate.CustomFormat = "dd/M/yyyy";
            dtDate.Format = DateTimePickerFormat.Custom;
            dtDate.Location = new Point(180, 78);
            dtDate.Margin = new Padding(4, 3, 4, 3);
            dtDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(160, 23);
            dtDate.TabIndex = 100;
            dtDate.Value = new DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(9, 78);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 101;
            label9.Text = "Date:";
            // 
            // TBNotes
            // 
            TBNotes.Location = new Point(196, 215);
            TBNotes.Margin = new Padding(5, 6, 5, 6);
            TBNotes.MaxLength = 50;
            TBNotes.Multiline = true;
            TBNotes.Name = "TBNotes";
            TBNotes.Size = new Size(416, 108);
            TBNotes.TabIndex = 12;
            TBNotes.Validating += ValidateEmptyTextBox;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(21, 215);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(61, 20);
            label12.TabIndex = 92;
            label12.Text = "Notes:";
            // 
            // txtPatinetTC
            // 
            txtPatinetTC.Location = new Point(180, 127);
            txtPatinetTC.Margin = new Padding(5, 6, 5, 6);
            txtPatinetTC.MaxLength = 50;
            txtPatinetTC.Name = "txtPatinetTC";
            txtPatinetTC.Size = new Size(160, 23);
            txtPatinetTC.TabIndex = 10;
            txtPatinetTC.Validating += ValidateEmptyTextBox;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 127);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 91;
            label6.Text = "Patinet TC:";
            // 
            // PBEmail
            // 
            PBEmail.Image = Properties.Resources._25348792;
            PBEmail.Location = new Point(134, 127);
            PBEmail.Margin = new Padding(4, 3, 4, 3);
            PBEmail.Name = "PBEmail";
            PBEmail.Size = new Size(36, 30);
            PBEmail.SizeMode = PictureBoxSizeMode.Zoom;
            PBEmail.TabIndex = 97;
            PBEmail.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ucPatientInfo1
            // 
            ucPatientInfo1.Location = new Point(0, 3);
            ucPatientInfo1.Margin = new Padding(4, 3, 4, 3);
            ucPatientInfo1.Name = "ucPatientInfo1";
            ucPatientInfo1.Size = new Size(629, 355);
            ucPatientInfo1.TabIndex = 115;
            ucPatientInfo1.Load += ucPatientInfo1_Load;
            // 
            // UCExtraInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ucPatientInfo1);
            Controls.Add(groupBox2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UCExtraInfo";
            Size = new Size(624, 721);
            Load += UCExtraInfo_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBNotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBState).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox PBState;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox PBDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox PBNotes;
        public System.Windows.Forms.TextBox tbReind;
        public System.Windows.Forms.TextBox tbPayed;
        public System.Windows.Forms.TextBox tbCost;
        public System.Windows.Forms.DateTimePicker dtDate;
        public System.Windows.Forms.ComboBox CBState;
        public System.Windows.Forms.TextBox txtPatinetTC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PBEmail;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox TBNotes;
        public UCPatientInfo ucPatientInfo1;
    }
}
