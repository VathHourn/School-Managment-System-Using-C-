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
    class FULLTIME_SCORE
    {
        public int STR_ID { get; set; }
        public string TEACHERID { get; set; }
        public string MONTH { get; set; }
        public int SPEAKING { get; set; }
        public int LISTENING { get; set; }
        public int WRITING { get; set; }
        public int PAINTING { get; set; }
        public int MORAL { get; set; }
        public int DICTATION { get; set; }
        public Decimal TOTAL { get; set; }
        public Decimal AVERAGE { get; set; }
        public string RESULT { get; set; }
        public string MENTION { get; set; }
        public FULLTIME_SCORE(int str_id,string t_id,string mon, int sp,int lis,int wr, int paint, int mor,int dic,decimal total,decimal avg,string res,string men)
        {
            STR_ID = str_id;
            TEACHERID = t_id;
            MONTH = mon;
            SPEAKING = sp;
            LISTENING = lis;
            WRITING = wr;
            PAINTING = paint;
            MORAL = mor;
            DICTATION = dic;
            TOTAL = total;
            AVERAGE = avg;
            RESULT = res;
            MENTION = men;
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
        public static void ADDFULL_SCORE(FULLTIME_SCORE sc)
        {
            string sql = @"INSERT INTO tbFULLTIME_SCORE(STR_ID,T_ID,MON,SPEAK,LISTEN,WRITE,PAINTING,MORALITY,DICTATION,TOTAL,AVERAGE,RESULT,MENTION)
                                VALUES(@str_id,@t_id,@mon,@sp,@lis,@wr,@pa,@mor,@dic,@total,@avg,@res,@men)";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@str_id", SqlDbType.Int).Value = sc.STR_ID;
            cmd.Parameters.Add("@t_id", SqlDbType.NVarChar).Value = sc.TEACHERID;
            cmd.Parameters.Add("@mon", SqlDbType.NVarChar).Value = sc.MONTH;
            cmd.Parameters.Add("@sp", SqlDbType.Int).Value = sc.SPEAKING;
            cmd.Parameters.Add("@lis", SqlDbType.Int).Value = sc.LISTENING;
            cmd.Parameters.Add("@wr", SqlDbType.Int).Value = sc.WRITING;
            cmd.Parameters.Add("@pa", SqlDbType.Int).Value = sc.PAINTING;
            cmd.Parameters.Add("@mor", SqlDbType.Int).Value = sc.MORAL;
            cmd.Parameters.Add("@dic", SqlDbType.Int).Value = sc.DICTATION;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = sc.TOTAL;
            cmd.Parameters.Add("@avg", SqlDbType.Decimal).Value = sc.AVERAGE;
            cmd.Parameters.Add("@res", SqlDbType.VarChar).Value = sc.RESULT;
            cmd.Parameters.Add("@men", SqlDbType.NVarChar).Value = sc.MENTION;
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
        public static void UPDATEFULL_SCORE(FULLTIME_SCORE sc,int id)
        {
            string sql = @"UPDATE tbFULLTIME_SCORE SET STR_ID=@str_id,T_ID=@t_id,MON=@mon,SPEAK=@sp,LISTEN=@lis,WRITE=@wr,
                                PAINTING=@pa,MORALITY=@mor,DICTATION=@dic,TOTAL=@total,AVERAGE=@avg,RESULT=@res,MENTION=@men
                                WHERE SC_ID=@id";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@str_id", SqlDbType.Int).Value = sc.STR_ID;
            cmd.Parameters.Add("@t_id", SqlDbType.NVarChar).Value = sc.TEACHERID;
            cmd.Parameters.Add("@mon", SqlDbType.NVarChar).Value = sc.MONTH;
            cmd.Parameters.Add("@sp", SqlDbType.Int).Value = sc.SPEAKING;
            cmd.Parameters.Add("@lis", SqlDbType.Int).Value = sc.LISTENING;
            cmd.Parameters.Add("@wr", SqlDbType.Int).Value = sc.WRITING;
            cmd.Parameters.Add("@pa", SqlDbType.Int).Value = sc.PAINTING;
            cmd.Parameters.Add("@mor", SqlDbType.Int).Value = sc.MORAL;
            cmd.Parameters.Add("@dic", SqlDbType.Int).Value = sc.DICTATION;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = sc.TOTAL;
            cmd.Parameters.Add("@avg", SqlDbType.Decimal).Value = sc.AVERAGE;
            cmd.Parameters.Add("@res", SqlDbType.VarChar).Value = sc.RESULT;
            cmd.Parameters.Add("@men", SqlDbType.NVarChar).Value = sc.MENTION;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("SCORE UPDATED SUCCESSFUL", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (SqlException ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("Not UPDATED", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteSCORE_FULLTIME(int id)
        {
            string sql = @"delete from tbFULLTIME_SCORE where SC_ID=@id";
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
    }
}
