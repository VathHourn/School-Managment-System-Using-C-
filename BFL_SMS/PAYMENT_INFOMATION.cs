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
    class PAYMENT_INFOMATION
    {
        public int ST_Not_Payid { get; set; }
        public int ST_RegisterNo { get; set; }
        public int UserID { get; set; }
        public DateTime Date { get; set; }
        public DateTime ENDDate { get; set; }
        public int QUANTITY { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public decimal Receive { get; set; }
        public decimal Balance { get; set; }
        public string Description { get; set; }
        public PAYMENT_INFOMATION(int npid,int st_rid, int user,DateTime endsdate,int qty,decimal dis,decimal total,decimal receive,decimal balance,string des)
        {
            ST_Not_Payid = npid;
            ST_RegisterNo = st_rid;
            UserID = user;
           // Date = date;
            ENDDate = endsdate;
            QUANTITY = qty;
            Discount = dis;
            Total = total;
            Receive = receive;
            Balance = balance;
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
        public static void InsertPaymentInfo(PAYMENT_INFOMATION pay)
        {
            string sql = @"insert into tbPAYMENT(N_ID,STR_ID,User_ID,DATE,ENS_DATE,QTY,DIS,TOTAL,RECIEVE,BALANCE,DESCR)
                            VALUES(@npid,@st_regNo,@User_ID,CURRENT_TIMESTAMP,@endsdate,@qty,@dis,@total,@receive,@balanc,@des)";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@npid", SqlDbType.Int).Value = pay.ST_Not_Payid;
            cmd.Parameters.Add("@st_regNo", SqlDbType.Int).Value = pay.ST_RegisterNo;
            cmd.Parameters.Add("@User_ID", SqlDbType.Int).Value = pay.UserID;
            cmd.Parameters.Add("@endsdate", SqlDbType.Date).Value = pay.ENDDate;
            cmd.Parameters.Add("@qty", SqlDbType.Int).Value = pay.QUANTITY;
            cmd.Parameters.Add("@dis", SqlDbType.Decimal).Value = pay.Discount;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = pay.Total;
            cmd.Parameters.Add("@receive", SqlDbType.Decimal).Value = pay.Receive;
            cmd.Parameters.Add("@balanc", SqlDbType.Decimal).Value = pay.Balance;
            cmd.Parameters.Add("@des", SqlDbType.NVarChar).Value = pay.Description;
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
        public static void DELETPaymentInfo(int pay)
        {
            string sql = @"DELETE FROM tbPAYMENT WHERE P_ID=@pid";
            SqlConnection con = DBCONNECTION.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@pid", SqlDbType.Int).Value = pay;
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
    }
}
