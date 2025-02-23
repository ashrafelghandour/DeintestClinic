using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentistBusinessLeyer;
using DentistDataAccessLeyer;

namespace dentist
{
    public partial class UCExtraInfo : UserControl
    {

        public UCExtraInfo()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);


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



        public PatinetDTO GetPatinet()
        {
            int StateID = clsState.GetStateByName(CBState.Text.Trim());

            return new PatinetDTO(ucPatientInfo1.GetPersonInfo(),
                TBNotes.Text, 0, txtPatinetTC.Text.Trim(),
               StateID, DateTime.Parse(dtDate.Text), Convert.ToSingle(tbCost.Text), Convert.ToSingle(tbPayed.Text), Convert.ToSingle(tbReind.Text));
        }

        private void UCExtraInfo_Load(object sender, EventArgs e)
        {

        }

        private void tbCost_TextChanged(object sender, EventArgs e)
       {
            if (tbPayed.Text == "")
            {
                tbReind.Text = tbCost.Text.Trim();
            }
            else
            {
                try
                {
                    tbReind.Text = (Convert.ToInt32(tbCost.Text) - Convert.ToInt32(tbPayed.Text)).ToString();

                }
                catch
                {
                    return;
                }
            }
        }

        private void tbPayed_TextChanged(object sender, EventArgs e)
        {
            try
            {


                tbReind.Text = (Convert.ToInt32(tbCost.Text) - Convert.ToInt32(tbPayed.Text)).ToString();
            }
            catch
            {
                return;

            }
        }

        private void tbPayed_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPayed.Text == "")
            {
                tbReind.Text = tbCost.Text.Trim();
            }
        }

        private void ucPatientInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
