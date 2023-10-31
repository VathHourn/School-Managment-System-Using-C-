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
    public partial class UserControlAddStudent : UserControl
    {
         private string sql = @"Data Source=LAPTOP-R76U6T47\SQLEXPRESS;Initial Catalog=bfl_sms; Integrated Security=True;";
       // SqlConnection con = DBCONNECTION.GetConnection();
        private string SID = "", gender = "";
        public UserControlAddStudent()
        {
            InitializeComponent();
        }
        public void ClearTextBox()
        {
            txtStudentID.Clear();
            txtStudentName.Clear();
            rdFemale.Checked = false;
            rdMale.Checked = false;
           // txtPhone.Clear();
            txtENName.Clear();
            comboBoxClass.SelectedIndex = -1;
            tabControlAddStudent.SelectedTab = tabPageAddStudent;
        }
        private void ClearTextBox1()
        {
            txtUpStudentID.Clear();
            txtUpStudentName.Clear();
            rdMale.Checked = false;
            rdFemale.Checked = false;
          //  txtUpPhone.Clear();
            txtUpStudent_Reg.Clear();
            comboBoxUpClass.SelectedIndex = -1;
            SID = "";
        }

        private void pictureBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxSearch, "Search");
        }

        private void tabPageSearchStudent_Enter(object sender, EventArgs e)
        {
            txtStudentSearch.Clear();
            comboBoxSearchBy.SelectedIndex = -1;
            Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID,Student_Name,Student_Reg,Student_Gender,Class_Name FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID=Class_Table.Class_ID", dataGridViewStudent,sql);
            dataGridViewStudent.Columns[0].Visible = false;
            labelCountStudent.Text = dataGridViewStudent.Rows.Count.ToString();
        }

        private void tabPageAddStudent_Enter(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageAddStudent_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void tabPageUpStudent_Enter(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void comboBoxUpClass_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            
            if (rdFemale.Checked)
            {
                gender = "F";
            }
            if (rdMale.Checked)
            {
                gender = "M";
            }
            if (txtStudentID.Text.Trim() == string.Empty || txtStudentName.Text.Trim() == string.Empty || comboBoxClass.SelectedIndex==-1)
            {
                MessageBox.Show("First Fill Out All Fields.", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(rdFemale.Checked == false && rdMale.Checked == false)
            {
                MessageBox.Show("First Fill Out All Fields.", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool check=Attendance.Attendance.AddStudent(txtStudentName.Text.Trim(), txtStudentID.Text.Trim(),comboBoxClass.SelectedItem.ToString(),gender,sql);
                if (check)
                    ClearTextBox();
            }

        }

        private void comboBoxClass_Click(object sender, EventArgs e)
        {
            comboBoxClass.Items.Clear();
            Attendance.Attendance.FillComboBox("SELECT Class_Name FROM Class_Table",comboBoxClass,sql);
        }

        private void tabControlAddStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchBy.SelectedIndex == 0)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID,Student_Name,Student_Reg,Student_Gender,Class_Name FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID=Class_Table.Class_ID WHERE Student_Name Like'%"+txtStudentSearch.Text+"%' ",dataGridViewStudent,sql);
            }
            if (comboBoxSearchBy.SelectedIndex == 1)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID,Student_Name,Student_Reg,Student_Gender,Class_Name FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID=Class_Table.Class_ID WHERE Student_Reg Like'%" + txtStudentSearch.Text + "%' ", dataGridViewStudent, sql);
            }
            if (comboBoxSearchBy.SelectedIndex == 2)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID,Student_Name,Student_Reg,Student_Gender,Class_Name FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID=Class_Table.Class_ID WHERE Class_Name Like'%" + txtStudentSearch.Text + "%' ", dataGridViewStudent, sql);
            }
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex != -1)
            //{
            //    DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];
            //    SID = row.Cells["Student_ID"].Value.ToString();
            //    txtUpStudentName.Text= row.Cells["Student_Name"].Value.ToString();
            //    txtUpStudent_Reg.Text = row.Cells["Student_Reg"].Value.ToString();
            //    comboBoxUpClass.Items.Clear();
            //    Attendance.Attendance.FillComboBox("SELECT Class_Name FROM Class_Table", comboBoxClass, sql);
            //    comboBoxClass.SelectedItem= row.Cells["Class_Name"].Value.ToString();
            //    if(row.Cells["Student_Gender"].Value.ToString()== "M")
            //    {
            //        rdUpMale.Checked = true;
            //    }
            //    if (row.Cells["Student_Gender"].Value.ToString() == "F")
            //    {
            //        rdUpFemale.Checked = true;
            //    }
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SID != " ")
            {
               // string gender = "";
                if (rdUpFemale.Checked)
                {
                    gender = "F";
                }
                if (rdUpMale.Checked)
                {
                    gender = "M";
                }
                if (txtUpStudentID.Text.Trim() == string.Empty || txtUpStudentName.Text.Trim() == string.Empty  || comboBoxClass.SelectedIndex == -1)
                {
                    MessageBox.Show("First Fill Out All Fields.", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (rdUpMale.Checked == false && rdUpFemale.Checked == false)
                {
                    MessageBox.Show("First Fill Out All Fields.", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool check = Attendance.Attendance.UpdateStudent(SID,txtUpStudentName.Text.Trim(), txtUpStudentID.Text.Trim(), comboBoxUpClass.SelectedItem.ToString(), gender, sql);
                    if (check)
                        ClearTextBox1();
                }
            }
            else
            {
                MessageBox.Show("First Select Row From Table.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewStudent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];
                SID = row.Cells["Column1"].Value.ToString();
                txtUpStudentID.Text = row.Cells["Column2"].Value.ToString();
                txtUpStudent_Reg.Text= row.Cells["Column3"].Value.ToString();
                comboBoxUpClass.Items.Clear();
                Attendance.Attendance.FillComboBox("Select Class_Name from Class_Table", comboBoxUpClass, sql);
                comboBoxClass.SelectedItem= row.Cells["Column4"].Value.ToString();
                if (row.Cells["Column5"].Value.ToString() == "M")
                {
                    rdUpMale.Checked = true;
                }
                if (row.Cells["Column5"].Value.ToString() == "F")
                {
                    rdUpFemale.Checked = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SID != "")
            {
               // string gender = "";
                if (rdUpFemale.Checked)
                {
                    gender = "F";
                }
                if (rdUpMale.Checked)
                {
                    gender = "M";
                }
                if (txtUpStudentID.Text.Trim() == string.Empty || txtUpStudentName.Text.Trim() == string.Empty  || comboBoxClass.SelectedIndex == -1)
                {
                    MessageBox.Show("First Fill Out All Fields.", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (rdUpFemale.Checked == false && rdUpMale.Checked == false)
                {
                    MessageBox.Show("First Fill Out All Fields.", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Are you want to delete this Student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        bool check = Attendance.Attendance.DeleteStudent(SID, sql);
                        if (check)
                            ClearTextBox1();
                    }
                }
            }
            else
            {
                MessageBox.Show("First Select Row From Table.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
