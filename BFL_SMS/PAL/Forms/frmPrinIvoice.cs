using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Data;
namespace BFL_SMS.PAL.Forms
{
    public partial class frmPrinIvoice : Form
    {
        public frmPrinIvoice()
        {
            InitializeComponent();
        }
        public int GET_ID;
        private void frmPrinIvoice_Load(object sender, EventArgs e)
        {
            LoadTreatmentReport();
        }
        public void LoadTreatmentReport()
        {
           SqlConnection con = DBCONNECTION.GetConnection();
            DataSet1 ds = new DataSet1();
            string sql = @"SELECT * FROM View_Payment where P_ID='" + GET_ID + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(ds.View_Payment);
            CrystalReportInvoicePayement cry = new CrystalReportInvoicePayement();
            cry.SetDataSource(ds);
            CR_InvoicePrint.ReportSource = cry;
            con.Close();

        }
    }
}
