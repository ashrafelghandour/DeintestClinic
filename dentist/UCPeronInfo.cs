using dentist.Properties;
using DentistDataAccessLeyer;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.Json;
 using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentist
{

    public partial class UCPatientInfo : UserControl
    {
        public UCPatientInfo()
        {



            InitializeComponent();

        }

        private byte[] GetPhoto()
       {
        //    Resources.Female_512;

        //    Resources._1077012;


            if (pbPersonImage.Image != Resources.Female_512|| pbPersonImage.Image != Resources._1077012)
            {
              MemoryStream stream = new MemoryStream();
              pbPersonImage.Image.Save(stream, pbPersonImage.Image.RawFormat);
              return stream.GetBuffer();
            }
            return null;
        }
        public PersonDTO GetPersonInfo()
        {
            return new PersonDTO(0,
             txtFirstName.Text.Trim()+' '+ txtLastName.Text.Trim(), DateTime.Parse(dtpDateOfBirth.Text), txtPhone.Text.Trim()
             , rbFemale.Checked, txtEmail.Text.Trim(),
             GetPhoto());
        }
        private void UCPatientInfo_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.

            //validate email format
            if (!clsValidatoin.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            };
        }



        private void ValidateEmptyTextBoxAndIsNumber(object sender, CancelEventArgs e)
        {
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



        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.ImageLocation = selectedFilePath;
                pbPersonImage.Image = Image.FromFile(openFileDialog1.FileName);
                llRemoveImage.Visible = true;
                // ...
            }
        }


        private void llRemoveImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;



            if (rbFemale.Checked)
                pbPersonImage.Image = Resources.Female_512;
            else
                pbPersonImage.Image = Resources._1077012;


            llRemoveImage.Visible = false;
        }



        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Female_512;

        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources._1077012;
        }

        private void pbPersonImage_Click(object sender, EventArgs e)
        {

        }
    }

}
