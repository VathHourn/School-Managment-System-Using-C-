using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BFL_SMS.PAL.User_Control
{
    public partial class UserControlAddClass : UserControl
    {
        private string sql = @"Data Source=LAPTOP-R76U6T47\SQLEXPRESS;Initial Catalog=bfl_sms; Integrated Security=True;";
        private string CID = "";
        public UserControlAddClass()
        {
            InitializeComponent();
        }
        private void IntegerType(KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        public void ClearTextBox()
        {
            txtClassName.Clear();
            txtFemale.Clear();
            txtMale.Clear();
            txtHwStudent.Clear();
            tabControlAddClass.SelectedTab = tabPageAddclass;
        }
        private void ClearTextBox1()
        {
            txtUpAddClass.Clear();
            txtUpHwStudent.Clear();
            txtUpMale.Clear();
            txtUpFemale.Clear();
            // tabControlAddClass.SelectedTab = tabPageUpClass;
            CID = "";
        }
        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxSearch, "ស្វែងរក");
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if(txtClassName.Text.Trim() == string.Empty || txtHwStudent.Text.Trim()==string.Empty || txtMale.Text.Trim()==string.Empty || txtFemale.Text.Trim() == string.Empty)
            {
                MessageBox.Show("First Fill Out All Fields.","Required all fields",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool check = Attendance.Attendance.AddClass(txtClassName.Text.Trim(), txtHwStudent.Text.Trim(), txtMale.Text.Trim(), txtFemale.Text.Trim(),sql);
                if (check)
                {
                    ClearTextBox();
                }
            }
        }

        private void tabPageUpClass_Leave(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageSearchClass_Enter(object sender, EventArgs e)
        {
            txtClassSearch.Clear();
            Attendance.Attendance.DisplayAndSearchAllData("Select * from Class_Table",dataGridViewClass,sql);
            dataGridViewClass.Columns[0].Visible = false;
            labelCount.Text = dataGridViewClass.Rows.Count.ToString();
        }

        private void tabPageAddclass_Enter(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageAddclass_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void txtHwStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void txtMale_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void txtFemale_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void txtUpHwStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void txtUpMale_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void txtUpFemale_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void txtClassSearch_TextChanged(object sender, EventArgs e)
        {
            Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM Class_Table WHERE Class_Name LIKE '%"+txtClassSearch.Text+"%' ",dataGridViewClass,sql);
        }

        private void dataGridViewClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClass.Rows[e.RowIndex];
                CID = row.Cells[0].Value.ToString();
                txtUpAddClass.Text = row.Cells[1].Value.ToString();
                txtUpHwStudent.Text = row.Cells[2].Value.ToString();
                txtUpMale.Text = row.Cells[3].Value.ToString();
                txtUpFemale.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CID != "")
            {
                if (txtUpAddClass.Text.Trim() == string.Empty || txtUpHwStudent.Text.Trim() == string.Empty || txtUpMale.Text.Trim() == string.Empty || txtUpFemale.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("First Fill Out All Fields.", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool check = Attendance.Attendance.UpdateClass(CID, txtUpAddClass.Text.Trim(), txtUpHwStudent.Text.Trim(), txtUpMale.Text.Trim(), txtUpFemale.Text.Trim(), sql);
                    if (check)
                        ClearTextBox1();
                }
            }
            else
            {
                MessageBox.Show("First Select Row From Table.","Select Row",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CID != "")
            {
                if (txtUpAddClass.Text.Trim() == string.Empty || txtUpHwStudent.Text.Trim() == string.Empty || txtUpMale.Text.Trim() == string.Empty || txtUpFemale.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("First Fill Out All Fields.", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Are you want to delete this class?","Delete Class",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        bool check = Attendance.Attendance.DeleteClass(CID, sql);
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
