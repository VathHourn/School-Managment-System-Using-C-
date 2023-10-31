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
    class Course_Infomation
    {
        public string COURSE_ID { get; set; }
        public string COURSE_NAME { get; set; }
        public decimal PRICE { get; set; }
        public Course_Infomation(string ID, string NAME, decimal COST){
            COURSE_ID=ID;
            COURSE_NAME = NAME;
            PRICE = COST;
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
        public static void DeleteCOURSE(string id)
        {
            string sql = @"DELETE FROM tbCOURSE where COID=@id";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
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
        public static void ADDCOURSE(Course_Infomation cname)
        {
            string sql = @"INSERT INTO tbCOURSE VALUES(@id,@name,@p)";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = cname.COURSE_ID;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = cname.COURSE_NAME;
            cmd.Parameters.Add("@p", SqlDbType.Decimal).Value = cname.PRICE;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (SqlException ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UPDATECOURSE(Course_Infomation cname,string ID)
        {
            string sql = @"UPDATE tbCOURSE SET CO_NAME=@name, CO_PRICE=@p WHERE COID=@id";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = cname.COURSE_NAME;
            cmd.Parameters.Add("@p", SqlDbType.Decimal).Value = cname.PRICE;
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = ID;
            //            try
            //            {
            cmd.ExecuteNonQuery();
            //                MessageBox.Show("UPDATED", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            //            catch (SqlException ex)
            //#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            //            {
            //                MessageBox.Show("Not UPDATED", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            con.Close();
        }
    }
}
