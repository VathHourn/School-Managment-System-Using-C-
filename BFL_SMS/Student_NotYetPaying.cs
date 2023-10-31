using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BFL_SMS
{
    class Student_NotYetPaying
    {
        public int STUDENT_Reg_No { get; set; }
        public DateTime Date_For_Pay { get; set; }
        public string Description { get; set; }
        public Student_NotYetPaying( DateTime pay, int id, string des)
        {
            STUDENT_Reg_No = id;
            Date_For_Pay = pay;
            Description = des;
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
        public static void InsertStudentInformation(Student_NotYetPaying student)
        {
            string sql = @"insert into tbNOTPAY(PayDate,STR_ID,Descri) values(@date,@id,@des)";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = student.Date_For_Pay;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = student.STUDENT_Reg_No;
            cmd.Parameters.Add("@des", SqlDbType.NVarChar).Value = student.Description;          
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("សិស្សដែលមិនទាន់បានបង់ប្រាក់ត្រូវបានរក្សាទុកបានសម្រេច", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (SqlException ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("សិស្សដែលមិនទាន់បានបង់ប្រាក់ត្រូវបានរក្សាទុកមិនបានសម្រេច", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UpdateStudentNotpay(Student_NotYetPaying student,int id)
        {
            string sql = @"UPDATE tbNOTPAY SET PayDate=@date, STR_ID=@str_id, Descri=@des WHERE N_ID=@id";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = student.Date_For_Pay;
            cmd.Parameters.Add("@str_id", SqlDbType.Int).Value = student.STUDENT_Reg_No;
            cmd.Parameters.Add("@des", SqlDbType.NVarChar).Value = student.Description;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("សិស្សដែលមិនទាន់បានបង់ប្រាក់ត្រូវបានរក្សាទុកបានសម្រេច", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (SqlException ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("សិស្សដែលមិនទាន់បានបង់ប្រាក់ត្រូវបានរក្សាទុកមិនបានសម្រេច", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteStudentNotpay( int id)
        {
            string sql = @"DELETE FROM tbNOTPAY WHERE N_ID=@id";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
//            try
//            {
               cmd.ExecuteNonQuery();
//                MessageBox.Show("សិស្សដែលមិនទាន់បានបង់ប្រាក់ត្រូវបានលុបចេញបានសម្រេច", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//#pragma warning disable CS0168 // The variable 'ex' is declared but never used
//            catch (SqlException ex)
//#pragma warning restore CS0168 // The variable 'ex' is declared but never used
//            {
//                MessageBox.Show("សិស្សដែលមិនទាន់បានបង់ប្រាក់លុបចេញមិនបានសម្រេច", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
            con.Close();
        }
    }
}
