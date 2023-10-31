using BFL_SMS.PAL.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFL_SMS.PAL.User_Control
{
    public partial class frmReport : UserControl
    {
        public frmReport()
        {
            InitializeComponent();
            dtTodate.Enabled = false;
            dtFrom.Enabled = false;
            dtFromYear.Enabled = false;
            dtToYear.Enabled = false;
        }
        public void LoadMonthReport()
        {
            SqlConnection con = DBCONNECTION.GetConnection();
            DataSet1 ds = new DataSet1();
            string sql = @"SELECT * FROM View_Payment
                            WHERE DATE BETWEEN '" + dtFrom.Text+ "' AND '" + dtTodate.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(ds.View_Payment);
            CR_INCOMEDESIGN cry = new CR_INCOMEDESIGN();
            cry.SetDataSource(ds);
            CRV_INCOME.ReportSource = cry;
            con.Close();
        }
        public void LoadDialyReport()
        {
            SqlConnection con = DBCONNECTION.GetConnection();
            DataSet1 ds = new DataSet1();
            string sql = @"SELECT * FROM View_Payment
                            WHERE DATE ='" + dtFrom.Text + "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(ds.View_Payment);
            CR_INCOMEDESIGN cry = new CR_INCOMEDESIGN();
            cry.SetDataSource(ds);
            CRV_INCOME.ReportSource = cry;
            con.Close();
        }
        //SELECT * FROM View_Payment WHERE YEAR(DATE)='2023'
        public void LoadYEARReport()
        {
            SqlConnection con = DBCONNECTION.GetConnection();
            DataSet1 ds = new DataSet1();
            string sql = @"SELECT * FROM View_Payment
                            WHERE YEAR(DATE) BETWEEN '" + dtFromYear.Text + "' AND  '" + dtToYear.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(ds.View_Payment);
            CR_INCOMEDESIGN cry = new CR_INCOMEDESIGN();
            cry.SetDataSource(ds);
            CRV_INCOME.ReportSource = cry;
            con.Close();
        }
        private void btnDialyReport_Click(object sender, EventArgs e)
        {
            dtFrom.Enabled = true ;
            dtTodate.Enabled = false;
            dtFromYear.Enabled = false;
            dtToYear.Enabled = false;
            LoadDialyReport();
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            dtFrom.Enabled = true;
            dtTodate.Enabled = true ;
            dtFromYear.Enabled = false;
            dtToYear.Enabled = false;
            LoadMonthReport();
        }

        private void btnYearReport_Click(object sender, EventArgs e)
        {
            dtFrom.Enabled = false;
            dtTodate.Enabled = false;
            dtFromYear.Enabled = true;
            dtToYear.Enabled = true;
            LoadYEARReport();
        }
    }
}
