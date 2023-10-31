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
    public partial class frmMain : Form
    {
        public string UserName, Role;
        public frmMain()
        {
            InitializeComponent();
            timerDateTimeAndHOur.Start();
        }

        private void btnLOGOUT_Click(object sender, EventArgs e)
        {
            DialogResult dailogResult = MessageBox.Show("Are you want to log out ?","Log out",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dailogResult == DialogResult.Yes)
            {
                timerDateTimeAndHOur.Stop();
                Close();
            }
            else
                panelExpand.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void timerDateTimeAndHOur_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime now1 = DateTime.Now;
            labelTime.Text = now.ToString("F");
            //lblPMandAM.Text = now1.ToString("hh:mm:ss tt");
        }
        private void MoveSlide( Control button)
        {
            panelSlide.Location = new Point(button.Location.X - button.Location.X,button.Location.Y-180);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MoveSlide(btnDashboard);
            userControlDashboard.Count();
            userControlDashboard.Visible = true;
            userControlAddClass1.Visible = false;
            frmStudent_Control1.Visible = false;
            frmStudent_Fee1.Visible = false;
            frmCourse1.Visible = false;
            frmGrade1.Visible = false;
            frmReport1.Visible = false;
            frmScoremanagement1.Visible = false;
        }

        private void btnAttandence_Click(object sender, EventArgs e)
        {
            MoveSlide(btnAttandence);
            userControlDashboard.Visible = false;
            userControlAddClass1.Visible = false;
            frmStudent_Control1.Visible = false;
            frmStudent_Fee1.Visible = false;
            frmCourse1.Visible = true;
            frmGrade1.Visible = false;
            frmReport1.Visible = false;
            frmScoremanagement1.Visible = false;
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            MoveSlide(btnAddClass);
            userControlDashboard.Visible = false;
            // userControlAddClass1.Visible = true;
            frmGrade1.Visible = true;
            frmStudent_Control1.Visible = false;
            userControlAddClass1.ClearTextBox();
            frmStudent_Fee1.Visible = false;
            frmCourse1.Visible = false;
            frmReport1.Visible = false;
            frmScoremanagement1.Visible = false;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            MoveSlide(btnAddStudent);
            userControlDashboard.Visible = false;
            userControlAddClass1.Visible = false;
            frmStudent_Control1.ClearTextBox();            
            frmStudent_Control1.Visible = true;
            frmStudent_Fee1.Visible = false;
            frmCourse1.Visible = false;
            frmGrade1.Visible = false;
            frmReport1.Visible = false;
            frmScoremanagement1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MoveSlide(btnReport);
            userControlDashboard.Visible = false;
            userControlAddClass1.Visible = false;
            frmStudent_Control1.Visible = false;
            frmStudent_Fee1.Visible = true;
            frmCourse1.Visible = false;
            frmGrade1.Visible = false;
            frmReport1.Visible = false;
            frmScoremanagement1.Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MoveSlide(btnRegister);
            userControlDashboard.Visible = false;
            userControlAddClass1.Visible = false;
            frmStudent_Control1.Visible = false;
            frmStudent_Fee1.Visible = false;
            frmCourse1.Visible = false;
            frmGrade1.Visible = false;
            frmReport1.Visible = false;
            frmScoremanagement1.Visible = true;
        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (panelExpand.Visible)
            {
                panelExpand.Visible = false;
            }
            else
                panelExpand.Visible = true;
        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnIncomReport_Click(object sender, EventArgs e)
        {
            MoveSlide(btnIncomReport);
            userControlDashboard.Visible = false;
            userControlAddClass1.Visible = false;
            frmStudent_Control1.Visible = false;
            frmStudent_Fee1.Visible = false;
            frmCourse1.Visible = false;
            frmGrade1.Visible = false;
            frmReport1.Visible = true;
            frmScoremanagement1.Visible = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            labelUserName.Text = UserName;
            labelRole.Text = Role;

            if (Role == "User")
            {
                btnDashboard.Hide();
                btnAddStudent.Hide();
                btnAddClass.Hide();
                btnRegister.Hide();
            }
        }
    }
}
