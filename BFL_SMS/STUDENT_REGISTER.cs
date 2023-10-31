using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFL_SMS
{
    class STUDENT_REGISTER
    {
        public int YEARS_ID { get; set; }
        public string SITUATION { get; set; }
        public string PAY_OR_NOT { get; set; }
        public string STUDENT_ID { get; set; }
        public string COURSE_ID { get; set; }
        public int GRADE { get; set; }
        public int CLASSROOM { get; set; }
        public int SHIFT { get; set; }
        public DateTime REG_DATE { get; set; }
        public DateTime START { get; set; }
        public STUDENT_REGISTER(int y, string situ, string pay, string st_id, string c_id, int g_id, int cl_id, int shiftid, DateTime r_da, DateTime start)
        {
            YEARS_ID = y;
            SITUATION = situ;
            PAY_OR_NOT =pay;
            STUDENT_ID = st_id;
            COURSE_ID = c_id;
            GRADE = g_id;
            CLASSROOM = cl_id;
            SHIFT = shiftid;
            REG_DATE = r_da;
            START = start;
        }
        public static void DisplayData(string query, DataGridView dvg)
        {
            string sql = query;
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dvg.DataSource = dt;
            con.Close();
        }

        public static void InsertStudentRegister(STUDENT_REGISTER reg_student)
        {
            string sql = @"insert into tbSTUDENT_Reg(Y_ID,SITUATION,PAY_NOT_PAY,St_ID,COID,G_ID,R_ID,ID,RE_DATE,START) 
                                 values(@y,@situ,@pay,@stid,@cid,@grade,@room,@shift,@reg_date,@start)";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@y", SqlDbType.Int).Value = reg_student.YEARS_ID;
            cmd.Parameters.Add("@situ", SqlDbType.NVarChar).Value = reg_student.SITUATION;
            cmd.Parameters.Add("@pay", SqlDbType.NVarChar).Value = reg_student.PAY_OR_NOT;
            cmd.Parameters.Add("@stid", SqlDbType.NVarChar).Value = reg_student.STUDENT_ID;
            cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = reg_student.COURSE_ID;
            cmd.Parameters.Add("@grade", SqlDbType.Int).Value = reg_student.GRADE;
            cmd.Parameters.Add("@room", SqlDbType.Int).Value = reg_student.CLASSROOM;
            cmd.Parameters.Add("@shift", SqlDbType.Int).Value = reg_student.SHIFT;
            cmd.Parameters.Add("@reg_date", SqlDbType.Date).Value = reg_student.REG_DATE;
            cmd.Parameters.Add("@start", SqlDbType.Date).Value = reg_student.START;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("ចុះឈ្មោះបានសម្រេច", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (SqlException ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("ចុះឈ្មោះមិនបានសម្រេច", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UpdateStudentRegister(STUDENT_REGISTER reg_student,int reg_no)
        {
            string sql = @"UPDATE tbSTUDENT_Reg SET Y_ID=@y,SITUATION=@situ,PAY_NOT_PAY=@pay,St_ID=@stid,COID=@cid,G_ID=@grade,
                                R_ID=@room,ID=@shift,RE_DATE=@reg_date,START=@start WHERE STR_ID=@reg_no";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@y", SqlDbType.Int).Value = reg_student.YEARS_ID;
            cmd.Parameters.Add("@situ", SqlDbType.NVarChar).Value = reg_student.SITUATION;
            cmd.Parameters.Add("@pay", SqlDbType.NVarChar).Value = reg_student.PAY_OR_NOT;
            cmd.Parameters.Add("@stid", SqlDbType.NVarChar).Value = reg_student.STUDENT_ID;
            cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = reg_student.COURSE_ID;
            cmd.Parameters.Add("@grade", SqlDbType.Int).Value = reg_student.GRADE;
            cmd.Parameters.Add("@room", SqlDbType.Int).Value = reg_student.CLASSROOM;
            cmd.Parameters.Add("@shift", SqlDbType.Int).Value = reg_student.SHIFT;
            cmd.Parameters.Add("@reg_date", SqlDbType.Date).Value = reg_student.REG_DATE;
            cmd.Parameters.Add("@start", SqlDbType.Date).Value = reg_student.START;
            cmd.Parameters.Add("@reg_no", SqlDbType.Int).Value = reg_no;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("​កែប្រែការចុះឈ្មោះសិស្សបានសម្រេច", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (SqlException ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("កែប្រែការចុះឈ្មោះសិស្សមិនបានសម្រេច", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteStudentRegister( int reg_no)
        {
            string sql = @"DELETE FROM tbSTUDENT_Reg  WHERE STR_ID=@reg_no";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@reg_no", SqlDbType.Int).Value = reg_no;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("​ការចុះឈ្មោះសិស្សលុបបានសម្រេច", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (SqlException ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("កែប្រែការចុះឈ្មោះសិស្សមិនបានសម្រេច", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
