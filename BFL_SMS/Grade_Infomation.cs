using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace BFL_SMS
{
    class Grade_Infomation
    {
       // public int ID { get; set; }
        public string Grade_ID { get; set; }
        public string Course_ID { get; set; }
        public Grade_Infomation(string gid,string cid)
        {
          //  ID = id;
            Grade_ID = gid;
            Course_ID = cid;
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
        public static void DeleteGrade(int id)
        {
            string sql = @"delete from tbGRADE where G_ID=@id";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            //            try
            //            {
            cmd.ExecuteNonQuery();
            //                MessageBox.Show("ទិន្នន័ត្រូវបានលុប", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            //            catch (SqlException ex)
            //#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            //            {
            //                MessageBox.Show("លុបមិនបានសម្រេច", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            con.Close();
        }
        public static void ADDGrade(Grade_Infomation cname)
        {
            string sql = @"INSERT INTO tbGRADE(GRADE,COID) VALUES(@grad,@cid)";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
           // cmd.Parameters.Add("@id", SqlDbType.Int).Value = cname.ID;
            cmd.Parameters.Add("@grad", SqlDbType.NVarChar).Value = cname.Grade_ID;
            cmd.Parameters.Add("@cid", SqlDbType.NVarChar).Value = cname.Course_ID;          
//            try
//            {
                cmd.ExecuteNonQuery();
//                MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//#pragma warning disable CS0168 // The variable 'ex' is declared but never used
//            catch (SqlException ex)
//#pragma warning restore CS0168 // The variable 'ex' is declared but never used
//            {
//                MessageBox.Show("Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
            con.Close();
        }
        public static void UpdateGrade(Grade_Infomation cname,int id)
        {
            string sql = @"Update tbGRADE Set GRADE=@grade, COID=@cid Where G_ID=@id";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@grade", SqlDbType.NVarChar).Value = cname.Grade_ID;
            cmd.Parameters.Add("@cid", SqlDbType.NVarChar).Value = cname.Course_ID;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (SqlException ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("Not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
