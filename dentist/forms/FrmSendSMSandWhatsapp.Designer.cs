namespace dentist.forms
{
    partial class frmSendSMSandWhaatsapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendSMSandWhaatsapp));
            errorProvider1 = new ErrorProvider(components);
            btSend = new Button();
            label1 = new Label();
            label2 = new Label();
            ll = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtTel = new TextBox();
            txtFrom = new TextBox();
            txtMessage = new TextBox();
            button1 = new Button();
            lblMode = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btSend
            // 
            errorProvider1.SetIconAlignment(btSend, ErrorIconAlignment.TopLeft);
            btSend.Image = (Image)resources.GetObject("btSend.Image");
            btSend.ImageAlign = ContentAlignment.MiddleLeft;
            btSend.Location = new Point(77, 444);
            btSend.Name = "btSend";
            btSend.Size = new Size(95, 37);
            btSend.TabIndex = 132;
            btSend.Text = "Send";
            btSend.TextAlign = ContentAlignment.MiddleRight;
            btSend.UseVisualStyleBackColor = true;
            btSend.Click += btSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 16);
            label1.TabIndex = 78;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 112);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(30, 16);
            label2.TabIndex = 79;
            label2.Text = "Tel:";
            // 
            // ll
            // 
            ll.AutoSize = true;
            ll.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ll.Location = new Point(13, 148);
            ll.Margin = new Padding(4, 0, 4, 0);
            ll.Name = "ll";
            ll.Size = new Size(43, 16);
            ll.TabIndex = 80;
            ll.Text = "From:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1, 299);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 16);
            label4.TabIndex = 81;
            label4.Text = "Message:";
            // 
            // txtName
            // 
            txtName.Location = new Point(77, 59);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(205, 23);
            txtName.TabIndex = 82;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(77, 106);
            txtTel.Name = "txtTel";
            txtTel.ReadOnly = true;
            txtTel.Size = new Size(205, 23);
            txtTel.TabIndex = 83;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(77, 142);
            txtFrom.Name = "txtFrom";
            txtFrom.ReadOnly = true;
            txtFrom.ScrollBars = ScrollBars.Horizontal;
            txtFrom.Size = new Size(205, 23);
            txtFrom.TabIndex = 84;
            txtFrom.Text = "Dr Aml El Ghandour";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(77, 186);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(205, 227);
            txtMessage.TabIndex = 85;
            txtMessage.Validating += ValidateEmptyTextBox;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(187, 444);
            button1.Name = "button1";
            button1.Size = new Size(95, 37);
            button1.TabIndex = 134;
            button1.Text = "Close";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMode.Location = new Point(13, 9);
            lblMode.Margin = new Padding(4, 0, 4, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(73, 16);
            lblMode.TabIndex = 135;
            lblMode.Text = "Whatsapp";
            // 
            // frmSendSMSandWhaatsapp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(294, 496);
            Controls.Add(lblMode);
            Controls.Add(button1);
            Controls.Add(btSend);
            Controls.Add(txtMessage);
            Controls.Add(txtFrom);
            Controls.Add(txtTel);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(ll);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmSendSMSandWhaatsapp";
            Text = "frmSendSMSandWhaatsapp";
            Load += FrmSendSMSandWhatsapp_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Label label4;
        private Label ll;
        private Label label2;
        private Label label1;
        private TextBox txtFrom;
        private TextBox txtTel;
        private TextBox txtName;
        private TextBox txtMessage;
        private Button btSend;
        private Button button1;
        private Label lblMode;
    }
}