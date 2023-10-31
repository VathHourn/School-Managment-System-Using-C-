using BFL_SMS.PAL.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFL_SMS.PAL.User_Control
{
    public partial class frmStudent_Fee : UserControl
    {
        SqlConnection con = DBCONNECTION.GetConnection();
        SqlDataAdapter da;
        DataTable dt;
        public frmStudent_Fee()
        {
            InitializeComponent();
        }

        private void frmStudent_Fee_Load(object sender, EventArgs e)
        {
            //comboBoxStudentID.Focus();
            txtListStudent.ForeColor = Color.Gray;
            txtListStudent.Text = "ស្វែងរកឈ្មោះសិស្ស";
            DisplayStudent_Reg();
            LoadSEARCHCOURSE();
            comboBoxSEARCHBYCOURSE.Text = null;
            LoadClass();
            LoadGRADE();
            LoadStudyShift();
            LoadUser();
            DisplayingStudentNOTpay();
            DisplayingStudentPAID();
            AutoInvoice_No();
            AutoNotPay_No();
            comboBoxClassroom.Text = null;
            comboBoxGrade.Text = null;
            comboBoxShift.Text = null;
            cmbReciever.Text = null;
        }
        public void ClearText()
        {
            cmbClassroom.Text = null;
            cmbCourse.Text = null;
            cmbGrade.Text = null;
            cmbStudy_Shift.Text = null;
            cmbReciever.Text = null;
            txtCoursePrice.Clear();
            txtDescription.Clear();
            txtReg_Ename.Clear();
            txtReg_Kname.Clear();
            txtReg_No.Clear();
            rdFemale_Reg.Checked = false;
            rdMale_Reg.Checked = false;
            dtDatePay.Value =DateTime.Today;
            dateTimePickerReg_DOB.Value= DateTime.Today;
            txtIN.Clear();
            txtOUT.Clear();

        }
        private void LoadSEARCHCOURSE()
        {
            da = new SqlDataAdapter("select COID,CO_NAME from tbCOURSE", con);
            dt = new DataTable();
            da.Fill(dt);
            comboBoxSEARCHBYCOURSE.DataSource = null;
            comboBoxSEARCHBYCOURSE.Items.Clear();
            comboBoxSEARCHBYCOURSE.DataSource = dt;
            comboBoxSEARCHBYCOURSE.DisplayMember = "CO_NAME";
            comboBoxSEARCHBYCOURSE.ValueMember = "COID";
        }
        private void LoadClass()
        {
            da = new SqlDataAdapter("Select R_ID,CL_ROOM from tbCLASSROOM", con);
            dt = new DataTable();
            da.Fill(dt);
            comboBoxClassroom.DataSource = null;
            comboBoxClassroom.Items.Clear();
            comboBoxClassroom.DataSource = dt;
            comboBoxClassroom.DisplayMember = "CL_ROOM";
            comboBoxClassroom.ValueMember = "R_ID";
        }
        private void LoadGRADE()
        {
            da = new SqlDataAdapter("select G_ID,GRADE from tbGRADE", con);
            dt = new DataTable();
            da.Fill(dt);
            comboBoxGrade.DataSource = null;
            comboBoxGrade.Items.Clear();
            comboBoxGrade.DataSource = dt;
            comboBoxGrade.DisplayMember = "GRADE";
            comboBoxGrade.ValueMember = "G_ID";
        }
        private void LoadStudyShift()
        {
            da = new SqlDataAdapter("select ID,SHIFTT from tbSTUDY_SHIFT", con);
            dt = new DataTable();
            da.Fill(dt);
            comboBoxShift.DataSource = null;
            comboBoxShift.Items.Clear();
            comboBoxShift.DataSource = dt;
            comboBoxShift.DisplayMember = "SHIFTT";
            comboBoxShift.ValueMember = "ID";
        }
        private void LoadUser()
        {
            da = new SqlDataAdapter("Select User_ID,User_Name from User_Table", con);
            dt = new DataTable();
            da.Fill(dt);
            cmbReciever.DataSource = null;
            cmbReciever.Items.Clear();
            cmbReciever.DataSource = dt;
            cmbReciever.DisplayMember = "User_Name";
            cmbReciever.ValueMember = "User_ID";
        }
        public void DisplayStudent_Reg()
        {
            string query = "SELECT * FROM VIEW_REGISTER_STUDENT";
            STUDENT_REGISTER.DisplayData(query, DVG_RegisterStudent);
        }

        private void txtListStudent_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtListStudent.Text.Trim()))
            {
                txtListStudent.ForeColor = Color.Gray;
                txtListStudent.Text = "ស្វែងរកឈ្មោះសិស្ស";
            }
        }

        private void txtListStudent_Enter(object sender, EventArgs e)
        {
            if (txtListStudent.Text == "ស្វែងរកឈ្មោះសិស្ស")
            {
                txtListStudent.Text = null;
                txtListStudent.ForeColor = Color.Black;
            }
        }
        private void txtListStudent_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select * from VIEW_REGISTER_STUDENT where ST_EN_Name like '%"+txtListStudent.Text+"%' OR ST_KH_Name LIKE N'%"+ txtListStudent .Text+ "%'";
            STUDENT_REGISTER.DisplayData(sql, DVG_RegisterStudent);
        }
        private void comboBoxGrade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (cmbGrade.SelectedIndex != -1)
            //{
            //    string sql = @"select * from VIEW_REGISTER_STUDENT where GRADE like N'%" + cmbGrade.SelectedIndex + "%' ";
            //    STUDENT_REGISTER.DisplayData(sql, DVG_RegisterStudent);
            //}
            //else
            //{
            //    string sql = @"select * from VIEW_REGISTER_STUDENT ";
            //    STUDENT_REGISTER.DisplayData(sql, DVG_RegisterStudent);
            //}
        }

        private void comboBoxClassroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxClassroom.SelectedIndex != -1)
            //{
            //    string sql = @"select * from VIEW_REGISTER_STUDENT where CL_ROOM LIKE '%" + comboBoxClassroom.SelectedIndex + "%'";
            //    STUDENT_REGISTER.DisplayData(sql, DVG_RegisterStudent);
            //}
        }
        public void DisplayingStudentPAID()
        {
            string sql = @"select * from View_Payment";
            STUDENT_REGISTER.DisplayData(sql, DVG_PAYMENT);
        }
        public void DisplayingStudentNOTpay()
        {
            string sql = @"select * from View_Student_NotPay";
            STUDENT_REGISTER.DisplayData(sql, DVG_StudentNotYetPay);
        }
        private void DVG_RegisterStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DVG_RegisterStudent.Rows[e.RowIndex];
                txtReg_No.Text = row.Cells[0].Value.ToString();
                txtReg_StudentID1.Text = row.Cells[1].Value.ToString();
                 txtReg_Kname.Text = row.Cells[2].Value.ToString();
                 txtReg_Ename.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.ToString() == "M")
                {
                    rdMale_Reg.Checked = rdMale_Reg.Checked = true;
                }
                else
                {
                    rdFemale_Reg.Checked = rdFemale_Reg.Checked = true;
                }
               // dateTimePickerReg_DOB.Text = row.Cells[5].Value.ToString();
                cmbCourse.Text = row.Cells[6].Value.ToString();
                txtCoursePrice.Text = row.Cells[7].Value.ToString();
                cmbGrade.Text = row.Cells[8].Value.ToString();
                cmbClassroom.Text = row.Cells[9].Value.ToString();
                cmbStudy_Shift.Text = row.Cells[15].Value.ToString();
                txtIN.Text = row.Cells[16].Value.ToString();
                txtOUT.Text = row.Cells[17].Value.ToString();
            }
        }
        public int No;
        public DateTime datepay;
        public string des;
        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReg_No.Text))
            {
                MessageBox.Show("Please Input Register No...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please Input Your Description...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(dtDatePay.Value.ToString()))
            {
                MessageBox.Show("Please Select Date For Pay...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            No = int.Parse(txtReg_No.Text);
            datepay = DateTime.Parse(dtDatePay.Value.ToString());
            des = txtDescription.Text;
            Student_NotYetPaying st = new Student_NotYetPaying(datepay,No,des);
            Student_NotYetPaying.InsertStudentInformation(st);
            ClearText();
            DisplayingStudentNOTpay();
            AutoNotPay_No();
        }

        private void txtSearchforstudentNotYetpay_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select * from View_Student_NotPay where ST_EN_Name like N'%"+ txtSearchforstudentNotYetpay.Text+ "%' OR GRADE LIKE N'%"+ txtSearchforstudentNotYetpay.Text+ "%' ";
            STUDENT_REGISTER.DisplayData(sql, DVG_StudentNotYetPay);
        }

        private void DVG_StudentNotYetPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DVG_StudentNotYetPay.Rows[e.RowIndex];
                txtNotYetPay.Text= txtIDNotYetPay.Text = row.Cells[15].Value.ToString();
                txtStudentID_Reg.Text= txtReg_StudentID1.Text = row.Cells[1].Value.ToString();
                txtStudentKname.Text= txtReg_Kname.Text = row.Cells[2].Value.ToString();
                txtStudentEname.Text= txtReg_Ename.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.ToString() == "M")
                {
                    radioButtonMales.Checked= rdFemale_Reg.Checked = true;
                }
                else
                {
                    radioButtonFemales.Checked=rdMale_Reg.Checked = true;
                }
                 dateTimePicker2StudentDOB.Text= dtDatePay.Text = row.Cells[0].Value.ToString();
                comboBoxSchoolCours.Text= cmbCourse.Text = row.Cells[7].Value.ToString();
                comboBoxStudentGrade.Text= cmbGrade.Text = row.Cells[9].Value.ToString();
                comboBoxStudentRoom.Text=cmbClassroom.Text = row.Cells[10].Value.ToString();
                comboBoxStudentShift.Text= cmbStudy_Shift.Text = row.Cells[11].Value.ToString();
                textBoxCost.Text= txtCoursePrice.Text = row.Cells[8].Value.ToString();
                textBoxRegisterNo.Text= txtReg_No.Text = row.Cells[16].Value.ToString();
                txtIN.Text= row.Cells[12].Value.ToString();
                txtOUT.Text= row.Cells[13].Value.ToString();
            }         
        }
        public void ClearTextBoxPayment()
        {
            comboBoxStudentRoom.Text = null;
            comboBoxSchoolCours.Text = null;
            comboBoxStudentGrade.Text = null;
            comboBoxStudentShift.Text = null;
            cmbReciever.Text = null;
            txtNotYetPay.Clear();
            txtStudentID_Reg.Clear();
            txtStudentEname.Clear();
            txtStudentKname.Clear();
            textBoxCost.Clear();
            radioButtonMales.Checked = false;
            radioButtonFemales.Checked = false;
            dateTimePicker2StudentDOB.Value = DateTime.Today;
            dateTimePickerEndStop.Value = DateTime.Today;
            textBoxQTY.Clear();
            textBoxDiscount.Clear();
            txtTotal.Clear();
            txtReceive.Clear();
            txtReturn.Clear();
        }
        SqlDataReader dr;
        SqlCommand cmd;
        public void AutoNotPay_No()
        {
            SqlConnection con = DBCONNECTION.GetConnection();
            cmd = new SqlCommand("Select Max(N_ID)+1 from tbNOTPAY", con);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    txtIDNotYetPay.Text = dr[0].ToString();
                    if (txtIDNotYetPay.Text == "")
                    {
                        txtIDNotYetPay.Text = "1";

                    }
                }
            }
            else
            {
                txtIDNotYetPay.Text = "1";
                return;
            }
            con.Close();
        }
        public void AutoInvoice_No()
        {
            SqlConnection con = DBCONNECTION.GetConnection();
            cmd = new SqlCommand("Select Max(P_ID)+1 from tbPAYMENT", con);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    txtInvoiceNo.Text = dr[0].ToString();
                    if (txtInvoiceNo.Text == "")
                    {
                        txtInvoiceNo.Text = "1";

                    }
                }
            }
            else
            {
                txtInvoiceNo.Text = "1";
                return;
            }
            con.Close();
        }
        private void btnPaymentAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxQTY.Text))
            {
                MessageBox.Show("បញ្ចូលចំនួនខែ(រយៈពេល)...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textBoxDiscount.Text))
            {
                MessageBox.Show("សូមបញ្ចូលចំនួននៃការបញ្ចុះតម្លៃ បើមាន​ តែបើគ្មានទេសូមបញ្ចូលលេខ ០...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
              
            else
            {
                int np_id = int.Parse(txtNotYetPay.Text);
                int st_reg = int.Parse(textBoxRegisterNo.Text);
                int user = int.Parse(cmbReciever.SelectedValue.ToString());
                DateTime en_date = DateTime.Parse(dateTimePickerEndStop.Text);
                int qty = int.Parse(textBoxQTY.Text);
                decimal dis = decimal.Parse(textBoxDiscount.Text);
                decimal total = decimal.Parse(txtTotal.Text);
                decimal receive = decimal.Parse(txtReceive.Text);
                decimal bal = decimal.Parse(txtReturn.Text);
                string des = txtDescription.Text;
                PAYMENT_INFOMATION pay = new PAYMENT_INFOMATION(np_id,st_reg,user,en_date,qty,dis,total,receive,bal,des);
                PAYMENT_INFOMATION.InsertPaymentInfo(pay);
                //**********************************************
                frmPrinIvoice inv = new frmPrinIvoice();
                inv.GET_ID = int.Parse(txtInvoiceNo.Text);
                inv.ShowDialog();
                //***********************************************
                string sql = @"UPDATE tbNOTPAY SET PayDate=@date WHERE N_ID=@id";
                SqlConnection con = DBCONNECTION.GetConnection();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Parse(dateTimePickerEndStop.Value.ToString());
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(txtNotYetPay.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            ClearTextBoxPayment();
            DisplayingStudentPAID();
            DisplayingStudentNOTpay();           
            AutoInvoice_No();

        }

        private void textBoxQTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            Decimal X;
            char ch = e.KeyChar;
            if (ch == (char)8)
            {
                e.Handled = false;
            }
            else if(!char.IsDigit(ch) && ch!='.' || !Decimal.TryParse(textBoxQTY.Text+ch,out X))
            {
                e.Handled = true ;
            }
        }

        private void txtReceive_Leave(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtReceive.Text) || !string.IsNullOrWhiteSpace(txtReceive.Text))
            //{
            //    // txtReceive.Text = string.Format("{0:KH}", Decimal.Parse(txtReceive.Text));
            //    txtReceive.Text = string.Format(new CultureInfo("km-KH"), "{0:C}", Decimal.Parse(txtReceive.Text));
            //}
        }
        private void txtReceive_Enter(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtReceive.Text) || 
            //    !string.IsNullOrWhiteSpace(txtReceive.Text))
            //{
            //    var s = decimal.Parse(txtReceive.Text,NumberStyles.Currency);
            //    txtReceive.Text = s.ToString();
            //}
        }

        private void txtReceive_KeyPress(object sender, KeyPressEventArgs e)
        {
            Decimal X;
            char ch = e.KeyChar;
            if (ch == (char)8)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' && ch!=',' || !Decimal.TryParse(txtReceive.Text + ch, out X))
            {
                e.Handled = true;
            }
        }

        private void textBoxDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Decimal y;
            char ch = e.KeyChar;
            if (ch == (char)8)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(textBoxDiscount.Text + ch, out y))
            {
                e.Handled = true;
            }
        }
        public void Multiply()
        {
            decimal b;
            int a;
            DateTime datepay = DateTime.Parse(dateTimePicker2StudentDOB.Value.ToString());
            bool isAValid = int.TryParse(textBoxQTY.Text, out a);
            bool isBValid = decimal.TryParse(textBoxCost.Text, out b);

            if (!(isAValid && isBValid))
                txtTotal.Text = "Invalid input";
            else
            {
                txtTotal.Text = (a * b).ToString();
                dateTimePickerEndStop.Text = datepay.AddMonths(a).ToString("d");
            }
        }
        public void Discount()
        {
            decimal a, b,c;
            decimal total;
            bool isAValid = decimal.TryParse(textBoxDiscount.Text, out a);
            bool isBValid = decimal.TryParse(textBoxCost.Text, out b);
            bool isCValid = decimal.TryParse(textBoxQTY.Text, out c);
            if (!(isAValid && isBValid&&isCValid))
                txtTotal.Text = (b*c).ToString();
            else
            {
                total = (b - (b * a) / 100)*c;
                txtTotal.Text = total.ToString();
            }           
        }
        private void textBoxQTY_TextChanged(object sender, EventArgs e)
        {
            Multiply();
        }

        private void textBoxCost_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCost.Text) || !string.IsNullOrWhiteSpace(textBoxCost.Text))
            {
                textBoxCost.Text = string.Format(new CultureInfo("km-KH"), "{0:C}", Decimal.Parse(textBoxCost.Text));
            }
        }

        private void textBoxCost_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCost.Text) ||
                !string.IsNullOrWhiteSpace(textBoxCost.Text))
            {
                var s = decimal.Parse(textBoxCost.Text, NumberStyles.Currency);
                textBoxCost.Text = s.ToString();
            }
        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotal.Text) || !string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                txtTotal.Text = string.Format(new CultureInfo("km-KH"), "{0:C}", Decimal.Parse(txtTotal.Text));
            }
        }

        private void txtTotal_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotal.Text) ||
               !string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                var s = decimal.Parse(txtTotal.Text, NumberStyles.Currency);
                txtTotal.Text = s.ToString();
            }
        }

        private void textBoxCost_TextChanged(object sender, EventArgs e)
        {
            Multiply();
        }

        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            Discount();
        }
        public void Substract()
        {
            decimal a, b;

            bool isAValid = decimal.TryParse(txtTotal.Text, out a);
            bool isBValid = decimal.TryParse(txtReceive.Text, out b);

            if (!(isAValid && isBValid))
            {              
                   txtReturn.Text = "ទឹកប្រាក់មិនគ្រប់គ្រាន់";
            }
            else if (b < a) { txtReturn.Text = "ទឹកប្រាក់មិនគ្រប់គ្រាន់"; }
            else
                txtReturn.Text = ( b-a).ToString();
        }
        private void txtReceive_TextChanged(object sender, EventArgs e)
        {
            Substract();
        }

        private void DVG_StudentNotYetPay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex !=-1)
            {
                if (MessageBox.Show("តើអ្នកពិតជាត្រូវការលុបទិន្នន័យនេះមែនឬទេ?", "Warrning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Student_NotYetPaying.DeleteStudentNotpay(int.Parse(DVG_StudentNotYetPay.Rows[e.RowIndex].Cells[15].Value.ToString()));
                    DisplayingStudentNOTpay();
                }
                return;
            }
        }

        private void DVG_StudentNotYetPay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            AutoInvoice_No();
          
        }

        private void buttonEditNotpay_Click(object sender, EventArgs e)
        {
            int nid = int.Parse(txtIDNotYetPay.Text);
            No = int.Parse(txtReg_No.Text);
            datepay = DateTime.Parse(dtDatePay.Value.ToString());
            des = txtDescription.Text;
            if (string.IsNullOrEmpty(txtIDNotYetPay.Text))
            {
                MessageBox.Show("Input some fields...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Student_NotYetPaying not = new Student_NotYetPaying(datepay, No, des);
            Student_NotYetPaying.UpdateStudentNotpay(not,nid);
            ClearText();
            DisplayingStudentNOTpay();
        }

        private void DVG_PAYMENT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                if (MessageBox.Show("តើអ្នកពិតជាត្រូវការលុបទិន្នន័យនេះមែនឬទេ?", "Warrning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    PAYMENT_INFOMATION.DELETPaymentInfo(int.Parse(DVG_PAYMENT.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    DisplayingStudentPAID();
                }
                return;
            }
        }

        private void comboBoxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
           // //if (cmbCourse.SelectedIndex == -1)
           // //{
           // //   // txtCourseGrade.Text = "";
           // //}
           // //else
           // //{
           //     SqlConnection con = DBCONNECTION.GetConnection();
           //     cmd = new SqlCommand("SELECT CL_ROOM FROM tbCLASSROOM INNER JOIN tbGRADE ON tbCLASSROOM.G_ID=tbGRADE.G_ID WHERE GRADE='"+ comboBoxGrade.Text + "' ", con);
           //     try
           //     {
           //         dr = cmd.ExecuteReader();
           //         while (dr.Read())
           //         {
           //             string cid = dr["CL_ROOM"].ToString();
           //             comboBoxClassroom.Text = cid;
           //         }
           //     }
           //     catch (Exception ex)
           //     {
           //         MessageBox.Show(ex.Message);
           //     }
           //     con.Close();
           //// }
        }

        private void comboBoxGrade_ValueMemberChanged(object sender, EventArgs e)
        {
            //if (comboBoxGrade.SelectedIndex != -1)
            //{
            //    string sql = @"select * from VIEW_REGISTER_STUDENT where GRADE ='" + comboBoxGrade.SelectedIndex + "'";
            //    STUDENT_REGISTER.DisplayData(sql, DVG_RegisterStudent);
            //}
        }
    } 
  }

