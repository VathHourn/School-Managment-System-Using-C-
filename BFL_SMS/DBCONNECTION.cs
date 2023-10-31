using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFL_SMS
{
    class DBCONNECTION
    {
        public static SqlConnection GetConnection()
        {
            string sql = "Data Source=LAPTOP-R76U6T47\\SQLEXPRESS;Initial Catalog=bfl_sms; Integrated Security=True;";
            SqlConnection con = new SqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("CONNECTION SUCESSFULL! \n", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
    }
}
