using System.ComponentModel;
using System.Windows.Forms;
using dentist.Properties;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dentist.forms
{
    public partial class frmSendSMSandWhaatsapp : Form
    {
        public enum enMode { SMS = 0, Whatsapp }
        private enMode _mode;

        public frmSendSMSandWhaatsapp(string tel, string name, enMode mode)
        {
            InitializeComponent();
            txtName.Text = name;
            txtTel.Text = tel;

            _mode = mode;
        }

        private void FrmSendSMSandWhatsapp_Load(object sender, EventArgs e)
        {
            if (_mode == enMode.SMS)
            {
                lblMode.Text = "SMS";

                try
                {


                    btSend.Image =
                        Image.FromFile("E:\\DentistProject - Copy\\dentist\\Resources\\SMS.png");
                    BackColor = Color.AntiqueWhite;

                }
                catch
                {
                    return;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateEmptyTextBoxAndIsNumbers(object sender, CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);

            if (!clsValidatoin.IsNumber(Temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required Numbers!");
            }


            else if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            TextBox Temp = ((TextBox)sender);

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }
        private void btSend_Click(object sender, EventArgs e)
        {
           if(_mode==enMode.Whatsapp)
                System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" + txtTel + "&text=" + txtMessage);



        }
    }
}
