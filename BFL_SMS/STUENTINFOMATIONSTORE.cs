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
    class STUENTINFOMATIONSTORE
    {
        public string STUDENT_ID { get; set; }
        public string STUDENT_KH_NAME { get; set; }
        public string STUDENT_EN_NAME { get; set; }
        public string GENDER { get; set; }
        public DateTime DATEOFBIRTH { get; set; }
        public string PARENTS { get; set; }
        public string PARENTS_POS { get; set; }
        public string TELEPHONE { get; set; }
        public string ADDRESS { get; set; }
       // public string IMAGE { get; set; }
        public STUENTINFOMATIONSTORE(string id, string kname, string ename, string sex, DateTime dob, string parent, string parentP, string tel, string add)
        {
            STUDENT_ID = id;
            STUDENT_KH_NAME = kname;
            STUDENT_EN_NAME = ename;
            GENDER = sex;
            DATEOFBIRTH = dob;
            PARENTS = parent;
            PARENTS_POS = parentP;
            TELEPHONE = tel;
            ADDRESS = add;
            //IMAGE = pic;
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
        public static void InsertStudentInformation(STUENTINFOMATIONSTORE student)
        {
            string sql = @"INSERT INTO tbSTUDENT(St_ID, ST_KH_Name, ST_EN_Name, GENDER, DOB, PARENTS, PARENTS_POS, TEL, ADDRES)
                            VALUES(@sid,@kname,@ename,@gender,@dob,@parent,@position,@tel,@add)";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@sid", SqlDbType.NVarChar).Value = student.STUDENT_ID ;
            cmd.Parameters.Add("@kname", SqlDbType.NVarChar).Value = student.STUDENT_KH_NAME;
            cmd.Parameters.Add("@ename", SqlDbType.NVarChar).Value = student.STUDENT_EN_NAME;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = student.GENDER;
            cmd.Parameters.Add("@dob", SqlDbType.Date).Value = student.DATEOFBIRTH;
            cmd.Parameters.Add("@parent", SqlDbType.NVarChar).Value = student.PARENTS;
            cmd.Parameters.Add("@position", SqlDbType.NVarChar).Value = student.PARENTS_POS;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = student.TELEPHONE;
            cmd.Parameters.Add("@add", SqlDbType.NVarChar).Value = student.ADDRESS;
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

        public static void UpdateStudentInformation(STUENTINFOMATIONSTORE student, string sid)
        {
            string sql = @"UPDATE tbSTUDENT SET ST_KH_Name=@kname, ST_EN_Name=@ename, GENDER=@gender,
                                DOB=@dob, PARENTS=@parent, PARENTS_POS=@position, TEL=@tel, ADDRES=@add WHERE St_ID=@sid ";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@kname", SqlDbType.NVarChar).Value = student.STUDENT_KH_NAME;
            cmd.Parameters.Add("@ename", SqlDbType.NVarChar).Value = student.STUDENT_EN_NAME;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = student.GENDER;
            cmd.Parameters.Add("@dob", SqlDbType.Date).Value = student.DATEOFBIRTH;
            cmd.Parameters.Add("@parent", SqlDbType.NVarChar).Value = student.PARENTS;
            cmd.Parameters.Add("@position", SqlDbType.NVarChar).Value = student.PARENTS_POS;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = student.TELEPHONE;
            cmd.Parameters.Add("@add", SqlDbType.NVarChar).Value = student.ADDRESS;
            cmd.Parameters.Add("@sid", SqlDbType.NVarChar).Value = sid;
            // cmd.ExecuteNonQuery();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("កែប្រែទិន្នន័យសិស្សបានសម្រេច", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (SqlException ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("កែប្រែទិន្នន័យសិស្សមិនបានសម្រេច", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteStudentInformation(string sid)
        {
            string sql = @"DELETE FROM tbSTUDENT WHERE St_ID=@sid ";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@sid", SqlDbType.NVarChar).Value = sid;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("ការលុបទិន្នន័យសិស្សបានសម្រេច", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (SqlException ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("ការលុបកែប្រែទិន្នន័យសិស្សមិនបានសម្រេច", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
