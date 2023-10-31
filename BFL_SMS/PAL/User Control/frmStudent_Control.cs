using BFL_SMS.PAL.Forms;
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
    public partial class frmStudent_Control : UserControl
    {
        SqlConnection con = DBCONNECTION.GetConnection();
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;
        private string sid = "";
        public frmStudent_Control()
        {
            InitializeComponent();
            AutoID();
            AutoReg_ID();
            Display();
            LoadYears();
            PopulateCourse();
            LoadClass();
            LoadStudyShift();
            LoadGRADE();
            PopulateSTUDENT();
            LoadStudyShiftCARD();
            LoadGRADECARD();
            LoadYearsCARD();
            //LoadSTUDENT_ID_CARD();
            CMBSTUDENT_ID.Text = null;
            CMB_GRADECARD.Text = null;
            CMB_SHIFTCARD.Text = null;
            CMB_YEARCARD.Text = null;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDeleteStudent.Enabled = false;
            btnStudentUpdate.Enabled = false;
            btnRegister.Enabled = false;
            btnEditing.Enabled = false;
            btnclear.Enabled = false;

        }
        public void PopulateSTUDENT()
        {
            da = new SqlDataAdapter("select STR_ID,ST_EN_Name from VIEW_REGISTER_STUDENT", con);
            dt = new DataTable();
            da.Fill(dt);
            CMBSTUDENT_ID.DataSource = null;
            CMBSTUDENT_ID.Items.Clear();
            CMBSTUDENT_ID.DataSource = dt;
            CMBSTUDENT_ID.DisplayMember = "ST_EN_Name";
            CMBSTUDENT_ID.ValueMember = "STR_ID";
        }
        private void LoadYears()
        {
            da = new SqlDataAdapter("Select Y_ID,FROM_Y From tbYEARS", con);
            dt = new DataTable();
            da.Fill(dt);
            cmbYears.DataSource = null;
            cmbYears.Items.Clear();
            cmbYears.DataSource = dt;
            cmbYears.DisplayMember = "FROM_Y";
            cmbYears.ValueMember = "Y_ID";
        }
        public void LoadClass()
        {
            da = new SqlDataAdapter("Select R_ID,CL_ROOM from tbCLASSROOM", con);
            dt = new DataTable();
            da.Fill(dt);
            cmbClassroom.DataSource = null;
            cmbClassroom.Items.Clear();
            cmbClassroom.DataSource = dt;
            cmbClassroom.DisplayMember = "CL_ROOM";
            cmbClassroom.ValueMember = "R_ID";
        }
        public void PopulateCourse()
        {
            da = new SqlDataAdapter("select COID,CO_NAME from tbCOURSE", con);
            dt = new DataTable();
            da.Fill(dt);
            cmbCourse.DataSource = null;
            cmbCourse.Items.Clear();
            cmbCourse.DataSource = dt;
            cmbCourse.DisplayMember = "CO_NAME";
            cmbCourse.ValueMember = "COID";
        }
        public void LoadGRADE()
        {
            da = new SqlDataAdapter("select G_ID,GRADE from tbGRADE", con);
            dt = new DataTable();
            da.Fill(dt);
            cmbGrade.DataSource = null;
            cmbGrade.Items.Clear();
            cmbGrade.DataSource = dt;
            cmbGrade.DisplayMember = "GRADE";
            cmbGrade.ValueMember = "G_ID";
        }
        private void LoadGRADECARD()
        {
            da = new SqlDataAdapter("select G_ID,GRADE from tbGRADE", con);
            dt = new DataTable();
            da.Fill(dt);
            CMB_GRADECARD.DataSource = null;
            CMB_GRADECARD.Items.Clear();
            CMB_GRADECARD.DataSource = dt;
            CMB_GRADECARD.DisplayMember = "GRADE";
            CMB_GRADECARD.ValueMember = "G_ID";
        }
        private void LoadStudyShiftCARD()
        {
            da = new SqlDataAdapter("select ID,SHIFTT from tbSTUDY_SHIFT", con);
            dt = new DataTable();
            da.Fill(dt);
            CMB_SHIFTCARD.DataSource = null;
            CMB_SHIFTCARD.Items.Clear();
            CMB_SHIFTCARD.DataSource = dt;
            CMB_SHIFTCARD.DisplayMember = "SHIFTT";
            CMB_SHIFTCARD.ValueMember = "ID";
        }
        private void LoadStudyShift()
        {
            da = new SqlDataAdapter("select ID,SHIFTT from tbSTUDY_SHIFT", con);
            dt = new DataTable();
            da.Fill(dt);
            cmbStudy_Shift.DataSource = null;
            cmbStudy_Shift.Items.Clear();
            cmbStudy_Shift.DataSource = dt;
            cmbStudy_Shift.DisplayMember = "SHIFTT";
            cmbStudy_Shift.ValueMember = "ID";
        }
        public void AutoID()
        {
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand("SELECT max(St_ID)  FROM tbSTUDENT", con);
            var maxid = cmd.ExecuteScalar() as string;
            if (maxid == null)
            {
                txtStudentID.Text = "BFL-0001";
            }
            else
            {
                int intval = int.Parse(maxid.Substring(4, 4));
                intval++;
                txtStudentID.Text = string.Format("BFL-{0:0000}", intval);
            }
            con.Close();
        }
        SqlDataReader dr;
        public void AutoReg_ID()
        {
            SqlConnection con = DBCONNECTION.GetConnection();
            cmd = new SqlCommand("Select Max(STR_ID)+1 from tbSTUDENT_Reg", con);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    txtReg_No.Text = dr[0].ToString();
                    if (txtReg_No.Text == "")
                    {
                        txtReg_No.Text = "1";

                    }
                }
            }
            else
            {
                txtReg_No.Text = "1";
                return;
            }
            con.Close();
        }
        public void Display()
        {
            string query = "SELECT * FROM tbStudent";
            STUENTINFOMATIONSTORE.DisplayData(query, dataGridViewStudent);
        }
        public void DisplayStudent_Reg()
        {
            string query = "SELECT * FROM VIEW_REGISTER_STUDENT";
            STUDENT_REGISTER.DisplayData(query, DVG_RegisterStudent);
        }
        public void ClearTextBox()
        {
            txtKStudentName.Clear();
            txtENName.Clear();
            rdFemale.Checked = false;
            rdMale.Checked = false;
            dateTimePickerDOB.Value =DateTime.Today;
            txtParantname.Clear();
            cmbPPosition.SelectedIndex = -1;
            txtTelephone.Clear();
            txtAddress.Clear();
            tabControlStudentInfo.SelectedTab = tabPageAddStudent;
        }
       public string studentID, studentK, studentE, studentG ;
       public DateTime studentD;
        public void Loastudent()
        {
            studentID = txtReg_StudentID.Text;
            studentK = txtReg_Kname.Text;
            studentE = txtReg_Ename.Text;
            studentD = DateTime.Parse(dateTimePickerReg_DOB.Value.ToString());
        }
        public void ClearTextBox_Reg()
        {
            txtReg_No.Clear();
            txtReg_StudentID.Clear();
            txtReg_Kname.Clear();
            txtReg_Ename.Clear();
            txtCoursePrice.Clear();
            txtIN.Clear();
            txtOUT.Clear();
            cmbSituation.SelectedIndex = -1;
            cmbPayorNOT.SelectedIndex = -1;
            cmbClassroom.Text = null;
            cmbCourse.Text = null;
            cmbGrade.Text = null;
            cmbYears.Text = null;
            cmbStudy_Shift.Text = null;
            txtReg_No.Text = null;
        }
        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBoxSearch_MouseHover(object sender, EventArgs e)
        {

        }
       public string gender = "";
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentID.Text.Trim()))
            {
                MessageBox.Show("Please Input Student ID...","Missing",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
           else if (string.IsNullOrEmpty(txtKStudentName.Text.Trim()))
            {
                MessageBox.Show("Please Input Student Kh Name...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(string.IsNullOrEmpty(txtENName.Text.Trim()))
            {
                MessageBox.Show("Please Input Student English Name...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(string.IsNullOrEmpty(txtParantname.Text.Trim()))
            {
                MessageBox.Show("Please Input Parents Name...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //else if(cmbPPosition.SelectedValue == null)
            //{
            //    MessageBox.Show("Please Input Select Parent Position...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            else if(string.IsNullOrEmpty(txtTelephone.Text.Trim()))
            {
                MessageBox.Show("Please Input Telephone...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                MessageBox.Show("Please Input Address...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (rdFemale.Checked == true)
                {
                    gender = "F";
                }
                else
                {
                    gender = "M";
                }
                STUENTINFOMATIONSTORE student = new STUENTINFOMATIONSTORE(txtStudentID.Text.Trim(), txtKStudentName.Text.Trim(),
                                                                                                                                txtENName.Text.Trim(), gender, DateTime.Parse(dateTimePickerDOB.Value.ToString()),
                                                                                                                                txtParantname.Text.Trim(), cmbPPosition.SelectedItem.ToString(),
                                                                                                                                txtTelephone.Text.Trim(), txtAddress.Text.Trim());
                STUENTINFOMATIONSTORE.InsertStudentInformation(student);
            }
            ClearTextBox();
            AutoID();
            Display();
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];
                txtStudentID.Text = txtReg_StudentID.Text=row.Cells[0].Value.ToString();
                txtKStudentName.Text=txtReg_Kname.Text = row.Cells[1].Value.ToString();
                txtENName.Text=txtReg_Ename.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value.ToString()=="M")
                {
                    rdMale.Checked =rdMale_Reg.Checked= true;
                }
                else {
                    rdFemale.Checked=rdFemale_Reg.Checked = true;
                 }
                dateTimePickerDOB.Text=dateTimePickerReg_DOB.Text = row.Cells[4].Value.ToString();
                txtParantname.Text = row.Cells[5].Value.ToString();
                cmbPPosition.Text = row.Cells[6].Value.ToString();
                txtTelephone.Text = row.Cells[7].Value.ToString();
                txtAddress.Text = row.Cells[8].Value.ToString();
            }
            btnDeleteStudent.Enabled = true;
            btnStudentUpdate.Enabled = true;
           btnSave.Enabled = false;
        }

        private void dataGridViewStudent_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridViewStudent.CurrentRow != null)
            //{
            //    DataGridViewRow row = dataGridViewStudent.CurrentRow;
            //    SqlConnection con = DBCONNECTION.GetConnection();
            //    SqlCommand cmd = new SqlCommand("InsertOrUpdateStudent", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    if (row.Cells["StudentID"].Value == DBNull.Value)
            //        cmd.Parameters.AddWithValue("@sid", 0);
            //    else
            //        cmd.Parameters.AddWithValue("@sid", row.Cells["StudentID"].Value);
            //    cmd.Parameters.AddWithValue("@kn", row.Cells["Column2"].Value == DBNull.Value ? "" : row.Cells[2].Value.ToString());
            //    cmd.Parameters.AddWithValue("@en", row.Cells["Column3"].Value == DBNull.Value ? "" : row.Cells[3].Value.ToString());
            //    cmd.Parameters.AddWithValue("@gen", row.Cells["Column4"].Value == DBNull.Value ? "" : row.Cells[4].Value.ToString());
            //    cmd.Parameters.AddWithValue("@dob", Convert.ToDateTime(row.Cells["Column5"].Value == DBNull.Value ? "" : row.Cells[5].Value.ToString()));
            //    cmd.Parameters.AddWithValue("@pa", row.Cells["Column6"].Value == DBNull.Value ? "" : row.Cells[6].Value.ToString());
            //    cmd.Parameters.AddWithValue("@po", row.Cells["Column7"].Value == DBNull.Value ? "" : row.Cells[7].Value.ToString());
            //    cmd.Parameters.AddWithValue("@tel", row.Cells["Column8"].Value == DBNull.Value ? "" : row.Cells[8].Value.ToString());
            //    cmd.Parameters.AddWithValue("@ad", row.Cells["Column9"].Value == DBNull.Value ? "" : row.Cells[9].Value.ToString());
            //    cmd.Parameters.AddWithValue("@sid", row.Cells["Column10"].Value == DBNull.Value ? "" : row.Cells[10].Value.ToString());
            //    cmd.ExecuteNonQuery();
            //}
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            AutoID();
            btnSave.Enabled = true;
            btnDeleteStudent.Enabled = false;
            btnStudentUpdate.Enabled = false;
        }
        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            sid = txtStudentID.Text;
            STUENTINFOMATIONSTORE student = new STUENTINFOMATIONSTORE(sid, txtKStudentName.Text.Trim(),
                                                                                                                                txtENName.Text.Trim(), gender, DateTime.Parse(dateTimePickerDOB.Value.ToString()),
                                                                                                                                txtParantname.Text.Trim(), cmbPPosition.SelectedItem.ToString(),
                                                                                                                                txtTelephone.Text.Trim(), txtAddress.Text.Trim());
            STUENTINFOMATIONSTORE.UpdateStudentInformation(student, sid);
            Display();
            AutoID();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            sid = txtStudentID.Text;
            STUENTINFOMATIONSTORE student = new STUENTINFOMATIONSTORE(sid, txtKStudentName.Text.Trim(),
                                                                                                                                txtENName.Text.Trim(), gender, DateTime.Parse(dateTimePickerDOB.Value.ToString()),
                                                                                                                                txtParantname.Text.Trim(), cmbPPosition.SelectedItem.ToString(),
                                                                                                                                txtTelephone.Text.Trim(), txtAddress.Text.Trim());
            STUENTINFOMATIONSTORE.DeleteStudentInformation(sid);
            Display();
            AutoID();
        }

        private void cmbCourse_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string CourseID = cmbCourse.SelectedValue.ToString();
            cmd = new SqlCommand("select COID,CO_NAME,FORMAT (CO_PRICE, 'c', 'km-KH') from tbCOURSE where COID='" + CourseID + "' " , con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtCoursePrice.Text =dr[2].ToString();   //FORMAT (CO_PRICE, 'c', 'km-KH')
            }
            dr.Dispose();
            cmd.Dispose();
        }
        int shiftID;
        private void cmbStudy_Shift_SelectionChangeCommitted(object sender, EventArgs e)
        {
             shiftID = int.Parse(cmbStudy_Shift.SelectedValue.ToString());
            cmd = new SqlCommand("select ID,SHIFTT,START,ENDS from tbSTUDY_SHIFT where ID=" + shiftID  , con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtIN.Text = dr[2].ToString();
                txtOUT.Text = dr[3].ToString();
            }
            dr.Dispose();
            cmd.Dispose();
        }

        private void btnCreatNew_Click(object sender, EventArgs e)
        {
            ClearTextBox_Reg();
            AutoReg_ID();
            btnRegister.Enabled = true;
        }
        private int year, grade_id,clas_id,shif_id;

        private void frmStudent_Control_Load(object sender, EventArgs e)
        {
            DisplayStudent_Reg();
            txtStudentSearching.ForeColor = Color.Gray;
            txtStudentSearching.Text = "ស្វែងរកពត៌មានសិស្ស";
            textBoxSearchRG.ForeColor = Color.Gray;
            textBoxSearchRG.Text = "ស្វែងរកពត៌មានសិស្សដែលបានចុះឈ្មោះហើយ";
            cmbClassroom.Text = null;
            cmbCourse.Text = null;
            cmbGrade.Text = null;
            cmbYears.Text = null;
            cmbStudy_Shift.Text = null;
            txtReg_No.Text = null;                   
        }

        private void txtStudentSearch_Enter(object sender, EventArgs e)
        {
            //if(txtStudentSearch1.Text == "ស្វែងរកពត៌មានសិស្ស")
            //{
            //    txtStudentSearch1.Text = null;
            //    txtStudentSearch1.ForeColor = Color.Black;
            //}
        }

        private void dateTimePickerDOB_Enter(object sender, EventArgs e)
        {
            SendKeys.Send("%{DOWN}");
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchRG.Text == "ស្វែងរកពត៌មានសិស្សដែលបានចុះឈ្មោះហើយ")
            {
                textBoxSearchRG.Text = null;
                textBoxSearchRG.ForeColor = Color.Black;
            }
        }

        private void DVG_RegisterStudent_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
                       
        }

        private void DVG_RegisterStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DVG_RegisterStudent.Rows[e.RowIndex];
                txtReg_No.Text = row.Cells[1].Value.ToString();
                txtReg_StudentID.Text = row.Cells[2].Value.ToString();
                 txtReg_Kname.Text = row.Cells[3].Value.ToString();
                txtReg_Ename.Text = row.Cells[4].Value.ToString();
                if (row.Cells[5].Value.ToString() == "M")
                {
                     rdMale_Reg.Checked = true;
                }
                else
                {
                     rdFemale_Reg.Checked = true;
                }
                 dateTimePickerReg_DOB.Text = row.Cells[6].Value.ToString();
                cmbCourse.Text = row.Cells[7].Value.ToString();
                txtCoursePrice.Text = row.Cells[8].Value.ToString();
                cmbGrade.Text = row.Cells[9].Value.ToString();
                cmbClassroom.Text = row.Cells[10].Value.ToString();
                cmbYears.Text = row.Cells[11].Value.ToString();
                cmbSituation.Text = row.Cells[12].Value.ToString();
                cmbPayorNOT.Text = row.Cells[13].Value.ToString();
                dateTimePickerRegister.Text = row.Cells[14].Value.ToString();
                dateTimePickerStart.Text = row.Cells[15].Value.ToString();
                cmbStudy_Shift.Text = row.Cells[16].Value.ToString();
                txtIN.Text = row.Cells[17].Value.ToString();
                txtOUT.Text = row.Cells[18].Value.ToString();
            }
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("តើអ្នកពិតជាត្រូវការលុបទិន្នន័យនេះមែនឬទេ?", "Warrning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    STUDENT_REGISTER.DeleteStudentRegister(int.Parse(DVG_RegisterStudent.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    DisplayStudent_Reg();
                }
                return;
            }
            btnclear.Enabled = true;
            btnEditing.Enabled = true;
            btnRegister.Enabled = false;
        }
        int reg_no;
        private void btnEditing_Click(object sender, EventArgs e)
        {
            year = int.Parse(cmbYears.SelectedValue.ToString());
            sit = cmbSituation.SelectedItem.ToString();
            pay = cmbPayorNOT.SelectedItem.ToString();
            stu_id = txtReg_StudentID.Text;
            co_id = cmbCourse.SelectedValue.ToString();
            grade_id = int.Parse(cmbGrade.SelectedValue.ToString());
            clas_id = int.Parse(cmbClassroom.SelectedValue.ToString());
            shif_id = int.Parse(cmbStudy_Shift.SelectedValue.ToString());
            re_date = DateTime.Parse(dateTimePickerRegister.Text);
            start = DateTime.Parse(dateTimePickerStart.Text);
            reg_no =int.Parse(txtReg_No.Text);
            STUDENT_REGISTER student = new STUDENT_REGISTER(year, sit, pay, stu_id, co_id, grade_id, clas_id, shif_id, re_date, start);
            STUDENT_REGISTER.UpdateStudentRegister(student, reg_no);
            ClearTextBox_Reg();
            DisplayStudent_Reg();
            AutoReg_ID();
            //PopulateSTUDENT();
            //LoadStudyShiftCARD();
            //LoadGRADECARD();
            //LoadYearsCARD();
        }

        private void btnST_idSearch_Click(object sender, EventArgs e)
        {
            frmNewStudent_List st = new frmNewStudent_List();
            st.ShowDialog();
        }    
        public void Searching()
        {
            string sql = @"SELECT * FROM tbSTUDENT WHERE St_ID LIKE'%" + textBoxSearchRG.Text + "%' OR ST_KH_Name LIKE'%" + textBoxSearchRG.Text+ "%'" +
                "OR ST_EN_Name LIKE'%" + textBoxSearchRG.Text+ "%' OR GENDER LIKE'%" + textBoxSearchRG.Text+ "%' OR DOB LIKE'%" + textBoxSearchRG.Text+ "%'" +
                "OR PARENTS LIKE'%" + textBoxSearchRG.Text+ "%'";
            STUENTINFOMATIONSTORE.DisplayData(sql, dataGridViewStudent);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Searching();
        }
        public void LoadSTUDENT_ID_CARD()
        {
            SqlConnection con = DBCONNECTION.GetConnection();
            DataSet1 ds = new DataSet1();
            string sql = @"select * from VIEW_REGISTER_STUDENT​ WHERE ST_EN_Name='" + CMBSTUDENT_ID.Text + "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(ds.VIEW_REGISTER_STUDENT);
            CR_STUDENT_ID_CARD cry = new CR_STUDENT_ID_CARD();
            cry.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cry;
            con.Close();
        }
        private void CMBSTUDENT_ID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void CMBSTUDENT_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = DBCONNECTION.GetConnection();
            DataSet1 ds = new DataSet1();
            string sql = @"SELECT * FROM VIEW_REGISTER_STUDENT
                            WHERE ST_EN_Name= '" + CMBSTUDENT_ID.Text + "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(ds.VIEW_REGISTER_STUDENT);
            CR_STUDENT_ID_CARD cry = new CR_STUDENT_ID_CARD();
            cry.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cry;
            con.Close();
            CMB_GRADECARD.Text = null;
            CMB_SHIFTCARD.Text = null;
            CMB_YEARCARD.Text = null;
        }

        private void CMB_GRADECARD_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = DBCONNECTION.GetConnection();
            DataSet1 ds = new DataSet1();
            string sql = @"select * from VIEW_REGISTER_STUDENT​ WHERE GRADE='" + CMB_GRADECARD.Text + "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(ds.VIEW_REGISTER_STUDENT);
            CR_STUDENT_ID_CARD cry = new CR_STUDENT_ID_CARD();
            cry.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cry;
            con.Close();
            CMBSTUDENT_ID.Text = null;
            CMB_SHIFTCARD.Text = null;
            CMB_YEARCARD.Text = null;
        }

        private void CMB_SHIFTCARD_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection con = DBCONNECTION.GetConnection();
            DataSet1 ds = new DataSet1();
            string sql = @"select * from VIEW_REGISTER_STUDENT​ WHERE SHIFTT=N'" + CMB_SHIFTCARD.Text + "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(ds.VIEW_REGISTER_STUDENT);
            CR_STUDENT_ID_CARD cry = new CR_STUDENT_ID_CARD();
            cry.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cry;
            con.Close();
            CMBSTUDENT_ID.Text = null;
            CMB_GRADECARD.Text = null;
            CMB_YEARCARD.Text = null;
        }
        private void LoadYearsCARD()
        {
            da = new SqlDataAdapter("Select Y_ID,FROM_Y From tbYEARS", con);
            dt = new DataTable();
            da.Fill(dt);
            CMB_YEARCARD.DataSource = null;
            CMB_YEARCARD.Items.Clear();
            CMB_YEARCARD.DataSource = dt;
            CMB_YEARCARD.DisplayMember = "FROM_Y";
            CMB_YEARCARD.ValueMember = "Y_ID";
        }
        private void CMB_YEARCARD_SelectedIndexChanged(object sender, EventArgs e)
        {          
            SqlConnection con = DBCONNECTION.GetConnection();
            DataSet1 ds = new DataSet1();
            string sql = @"select * from VIEW_REGISTER_STUDENT​ WHERE FROM_Y='" + CMB_YEARCARD.Text + "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(ds.VIEW_REGISTER_STUDENT);
            CR_STUDENT_ID_CARD cry = new CR_STUDENT_ID_CARD();
            cry.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cry;
            con.Close();
            CMBSTUDENT_ID.Text = null;
            CMB_GRADECARD.Text = null;
            CMB_SHIFTCARD.Text = null;
        }

        private void textBoxSearchRG_TextChanged(object sender, EventArgs e)
        {
                string sql = @"select * from VIEW_REGISTER_STUDENT​ WHERE St_ID LIKE'%" + textBoxSearchRG.Text + "%' OR " +
                "ST_KH_Name LIKE N'%" + textBoxSearchRG.Text + "%' OR ST_EN_Name LIKE '%" + textBoxSearchRG.Text + "%' ";
            STUENTINFOMATIONSTORE.DisplayData(sql, DVG_RegisterStudent);      
        }

        private void txtStudentSearching_TextChanged(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM tbSTUDENT WHERE St_ID LIKE'%" + txtStudentSearching.Text + "%' OR ST_KH_Name LIKE'%" + txtStudentSearching.Text + "%'" +
               "OR ST_EN_Name LIKE'%" + txtStudentSearching.Text + "%' OR GENDER LIKE'%" + txtStudentSearching.Text + "%' OR DOB LIKE'%" + txtStudentSearching.Text + "%'" +
               "OR PARENTS LIKE'%" + txtStudentSearching.Text + "%'";
            STUENTINFOMATIONSTORE.DisplayData(sql, dataGridViewStudent);          
        }

        private void txtStudentSearching_Enter(object sender, EventArgs e)
        {
            if (txtStudentSearching.Text == "ស្វែងរកពត៌មានសិស្ស")
            {
                txtStudentSearching.Text = null;
                txtStudentSearching.ForeColor = Color.Black;
            }
        }

        private void txtStudentSearching_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentSearching.Text.Trim()))
            {
                txtStudentSearching.ForeColor = Color.Gray;
                txtStudentSearching.Text = "ស្វែងរកពត៌មានសិស្ស";
            }
        }

        private string sit, pay, stu_id, co_id;
        private DateTime re_date, start;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReg_StudentID.Text))
            {
                MessageBox.Show("Please Input Student Infomation...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbCourse.SelectedItem == null)
            {
                MessageBox.Show("Please Select Course...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbGrade.SelectedItem == null)
            {
                MessageBox.Show("Please Select Class Room...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbClassroom.SelectedItem == null)
            {
                MessageBox.Show("Please Select Your Room...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbStudy_Shift.SelectedItem == null)
            {
                MessageBox.Show("Please Select Your Shift Time...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbSituation.SelectedItem == null)
            {
                MessageBox.Show("Please Input Select Student Situation...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbPayorNOT.SelectedItem == null)
            {
                MessageBox.Show("Please Select Student Pay OR Not...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbYears.SelectedItem == null)
            {
                MessageBox.Show("Please Select Year Study...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            year = int.Parse(cmbYears.SelectedValue.ToString());
            sit = cmbSituation.SelectedItem.ToString();
            pay = cmbPayorNOT.SelectedItem.ToString();
            stu_id = txtReg_StudentID.Text;
            co_id = cmbCourse.SelectedValue.ToString();
            grade_id = int.Parse(cmbGrade.SelectedValue.ToString());
            clas_id = int.Parse(cmbClassroom.SelectedValue.ToString());
            shif_id = int.Parse(cmbStudy_Shift.SelectedValue.ToString());
            re_date = DateTime.Parse(dateTimePickerRegister.Text);
            start = DateTime.Parse(dateTimePickerStart.Text);
            STUDENT_REGISTER reg = new STUDENT_REGISTER(year, sit, pay, stu_id, co_id, grade_id, clas_id, shif_id, re_date, start);
            STUDENT_REGISTER.InsertStudentRegister(reg);
            ClearTextBox_Reg();
            DisplayStudent_Reg();
            AutoReg_ID();
            PopulateSTUDENT();
            LoadStudyShiftCARD();
            LoadGRADECARD();
            LoadYearsCARD();
        }
    }
}
