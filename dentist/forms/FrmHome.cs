using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentist.forms
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _LoadData()
        {


            lbDateTime.Text = DateTime.Now.ToShortTimeString();
            lbDateTimeLong.Text = DateTime.Now.ToLongDateString();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }




        private void btPatient_Click(object sender, EventArgs e)
        {
            Form frm = new FrmAddUpdatePatinet();
            this.Hide();
            frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btscrenLogen_Click(object sender, EventArgs e)
        {
            FrmLog frmLog = new FrmLog();
            this.Hide();
            frmLog.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmAddUpdatePatinet frm = new FrmAddUpdatePatinet();
            frm.ShowDialog();
        }

        private void btPatientsMenegent_Click(object sender, EventArgs e)
        {
            FrmPatientsMenegment frmPMenegment = new FrmPatientsMenegment();
            frmPMenegment.ShowDialog();
        }
    }
}
