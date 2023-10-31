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
    class CLASSROOM_INFOMATION
    {
        public string CLASSROOM { get; set; }
        public int GRADEID { get; set; }
        public CLASSROOM_INFOMATION(string clr, int gid)
        {
            CLASSROOM = clr;
            GRADEID = gid;
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
        public static void DeleteRoom(int id)
        {
            string sql = @"delete from tbCLASSROOM where R_ID=@id";
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
        public static void UpdateRoom(CLASSROOM_INFOMATION cl,int id)
        {
            string sql = @"UPDATE tbCLASSROOM SET CL_ROOM=@clr,G_ID=@gid where R_ID=@id";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@clr", SqlDbType.VarChar).Value = cl.CLASSROOM;
            cmd.Parameters.Add("@gid", SqlDbType.Int).Value = cl.GRADEID;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Have Been Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (SqlException ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("Unsucessful Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void AddRoom(CLASSROOM_INFOMATION cl)
        {
            string sql = @"INSERT INTO tbCLASSROOM(CL_ROOM,G_ID) Values(@clr,@gid)";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@clr", SqlDbType.VarChar).Value = cl.CLASSROOM;
            cmd.Parameters.Add("@gid", SqlDbType.Int).Value = cl.GRADEID;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Have Been Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (SqlException ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("Unsucessful Add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
