using System;
using System.Windows.Forms;
using dentist.forms;
using DentistBusinessLeyer;
using Microsoft.VisualBasic.ApplicationServices;

namespace dentist
{
    public partial class FrmLog : Form
    {
        public FrmLog()
        {
            InitializeComponent();


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {

                this.Opacity -= 0.05;
            }
            else
            {
                this.Close();
            }
        }



        private void FrmLog_Load(object sender, EventArgs e)
        {
            LodDataToForm();

        }

        private void LodDataToForm()
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                tbUserName.Text = UserName;
                tbPass.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;

            pbOpenEye.Visible = false;
            pbClose_Eye.Visible = true;
            tbPass.isPassword = true;

        }

        private void chbShowPass_OnChange(object sender, EventArgs e)
        {

            if (chbShowPass.Checked)
            {

                pbOpenEye.Visible = true;
                pbClose_Eye.Visible = false;
                tbPass.isPassword = false;


            }
            else
            {
                pbOpenEye.Visible = false;
                pbClose_Eye.Visible = true;
                tbPass.isPassword = true;
            }
        }



        private void Login()
        {

            string usertupe = rdUser.Checked ? "User" : "Admin";

            var HashPass = clsGlobal.ComputeHash(tbPass.Text.Trim());

            ClsUser clsUser = ClsUser.GetUserByUserNameAndPass(tbUserName.Text, HashPass, usertupe);

            if (clsUser != null)
            {

                if (chkRememberMe.Checked)
                {
                    //store username and password
                    clsGlobal.RememberUsernameAndPassword(tbUserName.Text.Trim(), tbPass.Text.Trim());

                }
                else
                {
                    //store empty username and password
                    clsGlobal.RememberUsernameAndPassword("", "");

                }



                clsGlobal.CurrentUser = clsUser;
                this.Hide();
                FrmHome frm = new FrmHome();
                frm.ShowDialog();


            }
            else
            {
                tbUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void btLog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserName.Text) || string.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("Please enter your username and passwored !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            Login();
            this.Close();
        }



     

        private void chbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPass.Checked)
            {

                pbOpenEye.Visible = true;
                pbClose_Eye.Visible = false;
                tbPass.isPassword = false;


            }
            else
            {
                pbOpenEye.Visible = false;
                pbClose_Eye.Visible = true;
                tbPass.isPassword = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure to Close Programm ?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                timer1.Start();
        }
    }

}
