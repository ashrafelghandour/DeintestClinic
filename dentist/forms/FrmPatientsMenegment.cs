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

namespace dentist.forms
{
    public partial class FrmPatientsMenegment : Form
    {
        public FrmPatientsMenegment()
        {
            InitializeComponent();
        }

        private DataTable _dtAllPatient;


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");


            if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Enabled = false;
            }
            else
                txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 

            switch (cbFilterBy.Text)
            {
                case "Patinet ID":
                    FilterColumn = "PatientID";
                    break;

                case "Patient TC":
                    FilterColumn = "PatientTC";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllPatient.DefaultView.RowFilter = "";
                lblRecordsCount.Text = (dgvPatents.Rows.Count - 1).ToString();
                return;
            }

            if (FilterColumn == "PatientTC")
            {
                _dtAllPatient.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            }
            else
                _dtAllPatient.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());



            lblRecordsCount.Text = (dgvPatents.Rows.Count - 1).ToString();

        }

        private void FrmPatientsMenegment_Load(object sender, EventArgs e)
        {

            cbFilterBy.SelectedIndex = 0;

            _dtAllPatient = ClsPatinet.GetAllPatient();



            dgvPatents.DataSource = _dtAllPatient;


            lblRecordsCount.Text = (dgvPatents.Rows.Count - 1).ToString();

            if (dgvPatents.Rows.Count > 0)
            {
                dgvPatents.Columns[0].HeaderText = "Patinet ID";
                dgvPatents.Columns[0].Width = 100;

                dgvPatents.Columns[1].HeaderText = "Patient TC";
                dgvPatents.Columns[1].Width = 100;

                dgvPatents.Columns[2].HeaderText = "Name";
                dgvPatents.Columns[2].Width = 140;

                dgvPatents.Columns[3].HeaderText = "Age";
                dgvPatents.Columns[3].Width = 40;

                dgvPatents.Columns[4].HeaderText = "Gender";
                dgvPatents.Columns[4].Width = 70;

                dgvPatents.Columns[5].HeaderText = "Phone";
                dgvPatents.Columns[5].Width = 100;

                dgvPatents.Columns[6].HeaderText = "State Name";
                dgvPatents.Columns[6].Width = 100;

                dgvPatents.Columns[7].HeaderText = "Patient Date";
                dgvPatents.Columns[7].Width = 120;

                dgvPatents.Columns[8].HeaderText = "Email";
                dgvPatents.Columns[8].Width = 200;

                dgvPatents.Columns[9].HeaderText = "Cost";
                dgvPatents.Columns[9].Width = 70;

                dgvPatents.Columns[10].HeaderText = "Payed";
                dgvPatents.Columns[10].Width = 70;

                dgvPatents.Columns[11].HeaderText = "Remind";
                dgvPatents.Columns[11].Width = 70;

            }



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Patinet ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }



        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdatePatinet frmAddNewPatinet = new FrmAddUpdatePatinet((int)(int)dgvPatents.CurrentRow.Cells[0].Value);
            frmAddNewPatinet.ShowDialog();
            FrmPatientsMenegment_Load(null, null);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdatePatinet frmAddNewPatinet = new FrmAddUpdatePatinet();
            frmAddNewPatinet.ShowDialog();
            FrmPatientsMenegment_Load(null, null);

        }

        private void btAddPatient_Click(object sender, EventArgs e)
        {
            FrmAddUpdatePatinet frmAddNewPatinet = new FrmAddUpdatePatinet();
            frmAddNewPatinet.ShowDialog();
            FrmPatientsMenegment_Load(null, null);

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            FrmAddUpdatePatinet frmAddNewPatinet = new FrmAddUpdatePatinet();
            frmAddNewPatinet.ShowDialog();
            FrmPatientsMenegment_Load(null, null);

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvPatents.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (ClsPatinet.DeletePatient((int)dgvPatents.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmPatientsMenegment_Load(null, null);
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if (pnlButensSend.Visible == false)
            {
                pnlButensSend.Visible = true;
            }
            else
            {
                pnlButensSend.Visible = false;
            }
        }

        private void btSMS_Click(object sender, EventArgs e)
        {
            var frm = new frmSendSMSandWhaatsapp((string)dgvPatents.CurrentRow.Cells[5].Value, (string)dgvPatents.CurrentRow.Cells[2].Value, frmSendSMSandWhaatsapp.enMode.SMS);
            frm.ShowDialog();
        }

        private void btWhatsapp_Click(object sender, EventArgs e)
        {
            var frm = new frmSendSMSandWhaatsapp((string)dgvPatents.CurrentRow.Cells[5].Value, (string)dgvPatents.CurrentRow.Cells[2].Value, frmSendSMSandWhaatsapp.enMode.Whatsapp);
            frm.ShowDialog();
        }

        private void dgvPatents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
