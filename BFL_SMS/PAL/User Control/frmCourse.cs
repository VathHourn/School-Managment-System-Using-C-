using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFL_SMS.PAL.User_Control
{
    public partial class frmCourse : UserControl
    {
        public frmCourse()
        {
            InitializeComponent();
            AutoID();
            ShowCourse();
        }
        public void AutoID()
        {
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand("SELECT max(COID)  FROM tbCOURSE", con);
            var maxid = cmd.ExecuteScalar() as string;
            if (maxid == null)
            {
                txtCourseID.Text = "CO-001";
            }
            else
            {
                int intval = int.Parse(maxid.Substring(3, 3));
                intval++;
                txtCourseID.Text = string.Format("CO-{0:000}", intval);
            }
            con.Close();
        }
        public void ShowCourse()
        {
            string sql = "SELECT * FROM tbCOURSE";
            Course_Infomation.DisplayData(sql, DVG_CourseShow);
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Decimal X;
            char ch = e.KeyChar;
            if (ch == (char)8)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtCoursPrice.Text + ch, out X))
            {
                e.Handled = true;
            }
        }

        private void DVG_CourseShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                if (MessageBox.Show("តើអ្នកពិតជាត្រូវការលុបទិន្នន័យនេះមែនឬទេ?", "Warrning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Course_Infomation.DeleteCOURSE(DVG_CourseShow.Rows[e.RowIndex].Cells[0].Value.ToString());
                    ShowCourse();
                }
                return;
            }
        }
        string cid, cname;
        decimal price;

        private void DVG_CourseShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row =DVG_CourseShow.Rows[e.RowIndex];
                txtCourseID.Text = row.Cells[0].Value.ToString();
                txtCourseName.Text = row.Cells[1].Value.ToString();
                txtCoursPrice.Text = row.Cells[2].Value.ToString();
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AutoID();
            txtCourseName.Clear();
            txtCoursPrice.Clear();
        }

        private void btnCoEdit_Click(object sender, EventArgs e)
        {
            cid = txtCourseID.Text;
            cname = txtCourseName.Text;
            price = decimal.Parse(txtCoursPrice.Text);
            if (string.IsNullOrEmpty(txtCourseID.Text))
            {
                MessageBox.Show("Please input course id...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtCourseName.Text))
            {
                MessageBox.Show("Please input course Name...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtCoursPrice.Text))
            {
                MessageBox.Show("Please input course price...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Course_Infomation course = new Course_Infomation(cid, cname, price);
                Course_Infomation.UPDATECOURSE(course,cid);
            }
            ShowCourse();
            AutoID();
            txtCourseName.Clear();
            txtCoursPrice.Clear();
        
    }

        private void btnCoSave_Click(object sender, EventArgs e)
        {
            cid = txtCourseID.Text;
            cname = txtCourseName.Text;
            price = decimal.Parse(txtCoursPrice.Text);
            if (string.IsNullOrEmpty(txtCourseID.Text))
            {
                MessageBox.Show("Please input course id...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtCourseName.Text))
            {
                MessageBox.Show("Please input course Name...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtCoursPrice.Text))
            {
                MessageBox.Show("Please input course price...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Course_Infomation course = new Course_Infomation(cid,cname,price);
                Course_Infomation.ADDCOURSE(course);
            }
            ShowCourse();
            AutoID();
            txtCourseName.Clear();
            txtCoursPrice.Clear();
            frmGrade grade = new frmGrade();
            grade.LoadGRADE();
            frmStudent_Control st = new frmStudent_Control();
            st.PopulateCourse();
        }
    }
}
