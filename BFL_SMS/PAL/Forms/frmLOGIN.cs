using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFL_SMS.PAL.Forms
{
    public partial class frmLOGIN : Form
    {
        private string sql = @"Data Source=LAPTOP-R76U6T47\SQLEXPRESS;Initial Catalog=bfl_sms; Integrated Security=True;";
        public frmLOGIN()
        {
            InitializeComponent();
        }

        private void pictureBox1Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2Min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2Show, "Show Password");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Hide Password");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pictureBox2Show.Show();
            pictureBox1.Hide();
        }

        private void pictureBox2Show_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pictureBox2Show.Hide();
            pictureBox1.Show();
        }

        private void frmLOGIN_Load(object sender, EventArgs e)
        {
            lblError.Hide();
            pictureBoxError.Hide();
            pictureBox1.Hide();
        }

        private void pictureBox1Close_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1Close, "Close Password");
        }

        private void pictureBox2Min_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2Min, "Minimized Password");
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            string check = Attendance.Attendance.IsValidNamePass(txtUserName.Text.Trim(), txtPassword.Text.Trim(),sql);
            if(txtUserName.Text.Trim() !=string.Empty && txtPassword.Text.Trim() != string.Empty)
            {
                if(check != "")
                {
                    frmMain main = new frmMain();
                    main.UserName = txtUserName.Text;
                    main.Role = check;
                    txtUserName.Clear();
                    txtPassword.Clear();
                    pictureBox1_Click(sender, e);
                    txtUserName.Focus();
                    pictureBoxError.Hide();
                    lblError.Hide();
                    main.ShowDialog();
                }
                else
                {
                    pictureBoxError.Show();
                    lblError.Show();
                }
            }
        }

        private void txtUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLOGIN.PerformClick();
                e.Handled = true;
            }
        }

        private void lblForgetPass_Click(object sender, EventArgs e)
        {
            frmForgetPassword forgetpass = new frmForgetPassword();
            forgetpass.ShowDialog();
            Application.Exit();
        }
    }
}
