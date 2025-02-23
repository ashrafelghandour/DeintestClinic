using dentist.Properties;
using DentistBusinessLeyer;
using DentistDataAccessLeyer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

using System.Windows.Forms;

namespace dentist.forms
{
    public partial class FrmAddUpdatePatinet : Form
    {
        public delegate void DataBackEventHandler(object sender, int? PatinetID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        private PatinetDTO? _Patinet = new PatinetDTO();


        private ClsPerson.enMode _Mode;
        private int _PatinetID = -1;

        public FrmAddUpdatePatinet()
        {
            InitializeComponent();
            _Mode = ClsPerson.enMode.AddNew;
        }
        public FrmAddUpdatePatinet(int PatinetID)
        {
            InitializeComponent();
            _Mode = ClsPerson.enMode.Update;
            _PatinetID = PatinetID;
            _LoadData();
        }

        private void _ResetDefualtValues()
        {


            _FillStatesInComoboBox();

            lbPatientID.Text = "N/A";


            if (_Mode == ClsPerson.enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                tbPatientid.Enabled = false;
                btSearch.Enabled = false;
            }
            else
            {
                tbPatientid.Enabled = true;
                btSearch.Enabled = true;
                lblTitle.Text = "Update Person";
            }


            lbDateTime.Text = DateTime.Now.ToShortTimeString();
            lbDateTimeLong.Text = DateTime.Now.ToLongDateString();




            ucExtraInfo1.ucPatientInfo1.llRemoveImage.Visible = (ucExtraInfo1.ucPatientInfo1.pbPersonImage.ImageLocation != null);


            ucExtraInfo1.ucPatientInfo1.txtFirstName.Text = string.Empty;

            ucExtraInfo1.ucPatientInfo1.txtLastName.Text = string.Empty;


            ucExtraInfo1.ucPatientInfo1.txtPhone.Text = string.Empty;

            ucExtraInfo1.ucPatientInfo1.txtEmail.Text = string.Empty;



            ucExtraInfo1.CBState.SelectedIndex = 0;

            ucExtraInfo1.dtDate.Value = DateTime.Now;

            ucExtraInfo1.txtPatinetTC.Text = string.Empty;

            ucExtraInfo1.tbCost.Text = string.Empty;
            ucExtraInfo1.tbReind.Text = string.Empty;
            ucExtraInfo1.tbPayed.Text = string.Empty;


        }

        private void _LoadData()
        {

            _Patinet = ClsPatinet.FindPatient(_PatinetID)?.PatinetDTO;

            if (_Patinet == null)
            {
                MessageBox.Show("No Person with ID = " + _PatinetID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            _Mode = ClsPerson.enMode.Update;

            //the following code will not be executed if the person was not found
            lbPatientID.Text = _Patinet.PatientID.ToString();

            ucExtraInfo1.ucPatientInfo1.dtpDateOfBirth.Value = _Patinet.BirthDay;
            ucExtraInfo1.ucPatientInfo1.llRemoveImage.Visible = (ucExtraInfo1.ucPatientInfo1.pbPersonImage.ImageLocation != null);

            IEnumerable<string> Name = _Patinet.Name.Split(' ');

            ucExtraInfo1.ucPatientInfo1.txtFirstName.Text = Name.First();
            ucExtraInfo1.ucPatientInfo1.txtLastName.Text = Name.Last();
            ucExtraInfo1.ucPatientInfo1.txtPhone.Text = _Patinet.Phone;
            ucExtraInfo1.ucPatientInfo1.txtEmail.Text = _Patinet.Email;
            ucExtraInfo1.CBState.SelectedText = clsState.GetStateByID(_Patinet.StateID);
            ucExtraInfo1.dtDate.Value = _Patinet.Patientdate;
            ucExtraInfo1.txtPatinetTC.Text = _Patinet.PatientTC;
            ucExtraInfo1.tbCost.Text = _Patinet.cost.ToString();
            ucExtraInfo1.tbReind.Text = _Patinet.Remind.ToString();
            ucExtraInfo1.tbPayed.Text = _Patinet.Paied.ToString();
            ucExtraInfo1.TBNotes.Text = _Patinet.Notes.ToString();

            if (_Patinet.gender == false)
                ucExtraInfo1.ucPatientInfo1.rbMale.Checked = true;
            else
                ucExtraInfo1.ucPatientInfo1.rbFemale.Checked = true;



            //load person image incase it was set.
            if (_Patinet.Image != null)
            {
                MemoryStream stream = new MemoryStream(_Patinet.Image);

                ucExtraInfo1.ucPatientInfo1.pbPersonImage.Image = Image.FromStream(stream);

                ucExtraInfo1.ucPatientInfo1.llRemoveImage.Visible = true;


            }

            //hide/show the remove linke incase there is no image for the person.

        }

        private void _FillStatesInComoboBox()
        {
            SortedSet<string> ssSates = clsState.GetAllStates();

            foreach (string row in ssSates)
            {
                ucExtraInfo1.CBState.Items.Add(row);
            }
        }
        private void FrmAddNewPatinet_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (_Mode ==    ClsPerson.enMode.Update)
                _LoadData();
        }






        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("If you leave this page,you will not be saved", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            ClsPatinet _clsPatinet = new ClsPatinet(ucExtraInfo1.ucPatientInfo1.GetPersonInfo(), _Patinet, _Mode);

            if (_clsPatinet.Save())
            {

                lbPatientID.Text = _clsPatinet.PatientID.ToString();
                //change form mode to update.
                _Mode = ClsPerson.enMode.Update;
                lblTitle.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _clsPatinet.PatientID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ucExtraInfo1_Load(object sender, EventArgs e)
        {

        }



        private void txbPatientid_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btSearch_Click(object sender, EventArgs e)
        {
            Form form = new FrmAddUpdatePatinet(int.Parse(tbPatientid.Text));
            this.Hide();
            form.ShowDialog();
        }
    }
}
