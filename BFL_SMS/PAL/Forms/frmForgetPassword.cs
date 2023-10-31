using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFL_SMS.PAL.Forms
{

    public partial class frmForgetPassword : Form
    {
        private string sql = @"Data Source=LAPTOP-R76U6T47\SQLEXPRESS;Initial Catalog=bfl_sms; Integrated Security=True;";
        public frmForgetPassword()
        {
            InitializeComponent();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var add = new MailAddress(email);
                return add.Address==email;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void pictureBox1Close_Click(object sender, EventArgs e)
        {
            // Close();
            frmLOGIN log = new frmLOGIN();
            log.ShowDialog();
            this.Hide();
        }

        private void pictureBox1Close_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBox1Close, "Close");
        }

        private void txtUserEmail_Enter(object sender, EventArgs e)
        {
            if (txtUserEmail.Text.Trim() == "vathcs00@gmail.com")
            {
                txtUserEmail.Clear();
                txtUserEmail.ForeColor = Color.Black;
            }
            if(!IsValidEmail(txtUserEmail.Text.Trim()) || txtUserEmail.Text.Trim() == "vathcs00@gmail.com")
            {
                pictureBoxError.Show();
            }
            else
            {
                pictureBoxError.Hide();
            }
        }

        private void txtUserEmail_Leave(object sender, EventArgs e)
        {
            if (txtUserEmail.Text.Trim() == string.Empty)
            {
                txtUserEmail.Text = "vathcs00@gmail.com";
                txtUserEmail.ForeColor = Color.DarkGray;
            }
            if (!IsValidEmail(txtUserEmail.Text.Trim()) || txtUserEmail.Text.Trim() == "vathcs00@gmail.com")
            {
                pictureBoxError.Show();
            }
            else
                pictureBoxError.Hide();
        }

        private void pictureBoxError_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxError, "Invalid email");
        }
        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(txtUserEmail.Text.Trim()))
            {
                string userName = Attendance.Attendance.GetUsernamePassword("SELECT User_Name FROM User_Table WHERE User_Email='"+txtUserEmail.Text+"'; ", sql);
                string Password = Attendance.Attendance.GetUsernamePassword("SELECT User_Pass FROM User_Table WHERE User_Email='" + txtUserEmail.Text + "'; ", sql);
                MessageBox.Show("Your Username is " + userName + " and Password is" + Password + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmForgetPassword_Load(object sender, EventArgs e)
        {
            pictureBoxError.Hide();
        }
    }
}
