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
    class SHIFT_INFOMATION
    {
        public string SHIFT { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan OUT { get; set; }
        public SHIFT_INFOMATION(string sif, TimeSpan start, TimeSpan ends)
        {
            SHIFT = sif;
            Start = start;
            OUT = ends;
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
        public static void DeleteSHIFT(int id)
        {
            string sql = @"delete from tbSTUDY_SHIFT where ID=@id";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("ទិន្នន័ត្រូវបានលុប", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (SqlException ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("លុបមិនបានសម្រេច", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void ADDSHIFT(SHIFT_INFOMATION shift)
        {
            string sql = @"INSERT INTO tbSTUDY_SHIFT(SHIFT,START,ENDS) VALUES(@grad,@start,@ens)";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@sift", SqlDbType.NVarChar).Value = shift.SHIFT;
            cmd.Parameters.Add("@start", SqlDbType.Time).Value = shift.Start;
             cmd.Parameters.Add("@ens", SqlDbType.Time).Value = shift.OUT;
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
        public static void UPDATESHIFT(SHIFT_INFOMATION shift,int id)
        {
            string sql = @"UPDATE tbSTUDY_SHIFT SET SHIFTT=@sift,START=@start,ENDS=@ens WHERE ID=@id";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@sift", SqlDbType.NVarChar).Value = shift.SHIFT;
            cmd.Parameters.Add("@start", SqlDbType.Time).Value = shift.Start;
            cmd.Parameters.Add("@ens", SqlDbType.Time).Value = shift.OUT;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Have Been Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
