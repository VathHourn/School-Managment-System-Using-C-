using BFL_SMS.PAL.User_Control;
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

namespace BFL_SMS
{
    public partial class frmNewStudent_List : Form
    {
        public frmStudent_Control stc;
        public frmNewStudent_List()
        {
            InitializeComponent();
            stc = new frmStudent_Control();
        }

        private void frmNewStudent_List_Load(object sender, EventArgs e)
        {
            Display();
            txtSearchST.ForeColor = Color.Gray;
            txtSearchST.Text = "ស្វែងរកឈ្មោះសិស្ស";
        }
        public void Display()
        {
            string query = "SELECT * FROM tbStudent";
            STUENTINFOMATIONSTORE.DisplayData(query, dataGridViewStudent);
        }
        
        private void dataGridViewStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // frmStudent_Control stc = new frmStudent_Control();
          
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearchST.Text == "ស្វែងរកឈ្មោះសិស្ស")
            {
                txtSearchST.Text = null;
                txtSearchST.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchST.Text.Trim()))
            {
                txtSearchST.ForeColor = Color.Gray;
                txtSearchST.Text = "ស្វែងរកឈ្មោះសិស្ស";
            }
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];
                comboBoxStudent_ID.Text = row.Cells["StudentID"].Value.ToString();
                //stc.txtReg_Kname.Text = row.Cells["Kname"].Value.ToString();
                //stc.txtReg_Ename.Text = row.Cells["Ename"].Value.ToString();
                //if (row.Cells["sex"].Value.ToString() == "M")
                //{
                //    stc.rdMale_Reg.Checked = true;
                //}
                //else
                //{
                //    stc.rdFemale_Reg.Checked = true;
                //}
                //stc.dateTimePickerReg_DOB.Text = row.Cells["dob"].Value.ToString();
                //// return;
            }
           // this.Close();
        }

        private void txtSearchST_TextChanged(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM tbSTUDENT WHERE St_ID LIKE'%" + txtSearchST.Text + "%' OR ST_KH_Name LIKE'%" + txtSearchST.Text + "%'" +
              "OR ST_EN_Name LIKE'%" + txtSearchST.Text + "%' OR GENDER LIKE'%" + txtSearchST.Text + "%' OR DOB LIKE'%" + txtSearchST.Text + "%'" +
              "OR PARENTS LIKE'%" + txtSearchST.Text + "%'";
            STUENTINFOMATIONSTORE.DisplayData(sql, dataGridViewStudent);
        }
        public void LoadCheckTeeth()
        {
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand("select St_ID,ST_KH_Name,ST_EN_Name,GENDER,DOB from tbSTUDENT WHERE St_ID= '" + comboBoxStudent_ID.Text + "' ", con);
            SqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string studentid = dr["St_ID"].ToString();
                    string studentkn = dr["ST_KH_Name"].ToString();
                    string studenten = dr["ST_EN_Name"].ToString();
                    string pri = dr["GENDER"].ToString();
                    // DateTime dob = dr.GetDateTime("DOB").ToString();
                    stc.txtReg_StudentID.Text = studentid;
                    stc.txtReg_Kname.Text = studentkn;
                    stc.txtReg_Ename.Text = studenten;
                    if (dr["GENDER"].ToString() == "F")
                    {
                        stc.rdFemale_Reg.Checked = true;
                    }
                    else
                    {
                        stc.rdMale_Reg.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
           
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            LoadCheckTeeth();
        }
    }
}
