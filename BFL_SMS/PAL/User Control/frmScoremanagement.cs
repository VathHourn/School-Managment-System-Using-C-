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
    public partial class frmScoremanagement : UserControl
    {
        SqlConnection con = DBCONNECTION.GetConnection();
        SqlDataAdapter da;
        DataTable dt;
        public string TID, MON, RESULT="", MENTION="";
        public int STR, SP, LIS, WR, PA, DIC;
        public decimal TOTAL, AVG;
        public frmScoremanagement()
        {
            InitializeComponent();
        }
        public void PopulateCourse()
        {
            da = new SqlDataAdapter("select COID,CO_NAME from tbCOURSE", con);
            dt = new DataTable();
            da.Fill(dt);
            COMBOXCOURSE.DataSource = null;
            COMBOXCOURSE.Items.Clear();
            COMBOXCOURSE.DataSource = dt;
            COMBOXCOURSE.DisplayMember = "CO_NAME";
            COMBOXCOURSE.ValueMember = "COID";
        }
        public void LoadGRADE()
        {
            da = new SqlDataAdapter("select G_ID,GRADE from tbGRADE", con);
            dt = new DataTable();
            da.Fill(dt);
            COMBOXGRADE.DataSource = null;
            COMBOXGRADE.Items.Clear();
            COMBOXGRADE.DataSource = dt;
            COMBOXGRADE.DisplayMember = "GRADE";
            COMBOXGRADE.ValueMember = "G_ID";
        }
        public void LoadSTUDENT()
        {
            da = new SqlDataAdapter("select STR_ID,ST_KH_Name from VIEW_REGISTER_STUDENT", con);
            dt = new DataTable();
            da.Fill(dt);
            COMBOXSTUDENT.DataSource = null;
            COMBOXSTUDENT.Items.Clear();
            COMBOXSTUDENT.DataSource = dt;
            COMBOXSTUDENT.DisplayMember = "ST_KH_Name";
            COMBOXSTUDENT.ValueMember = "STR_ID";
        }
        public void LoadTEACHER()
        {
            da = new SqlDataAdapter("SELECT T_ID,T_Name FROM tbTEACHER", con);
            dt = new DataTable();
            da.Fill(dt);
            COMBOXTEACHER.DataSource = null;
            COMBOXTEACHER.Items.Clear();
            COMBOXTEACHER.DataSource = dt;
            COMBOXTEACHER.DisplayMember = "T_Name";
            COMBOXTEACHER.ValueMember = "T_ID";
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmScoremanagement_Load(object sender, EventArgs e)
        {
            PopulateCourse();
            LoadSTUDENT();
            LoadTEACHER();
            COMBOXCOURSE.Text = null;
            COMBOXSTUDENT.Text = null;
            COMBOXTEACHER.Text = null;
            GROUPFULLTIME.Enabled = false;
            GROUPPARTTIME.Enabled = false;
            COMBOXMONTH.Text = "...សូមជ្រើសរើសយកខែ...";
            btUpdateData.Text = "កែប្រែពិន្ទុ";
            SHOWFULLTIMESCORE();
        }
        public void CLEARTEXT()
        {
            COMBOXSTUDENT.Text = null;
            txtSpeaking.Clear();
            txtLisent.Clear();
            txtWritting.Clear();
            txtPainting.Clear();
            txtMorality.Clear();
            txtDictation.Clear();
            txtTotalScore.Clear();
            txtAVG.Clear();
            txtResult.Clear();
            txtMention.Clear();
            COMBOXTEACHER.Text = null;
        }
        public void SHOWFULLTIMESCORE()
        {
            string sql = @"SELECT * FROM View_FULLTIME_SCORE";
            FULLTIME_SCORE.DisplayData(sql, DVG_FULLTIMESCORE);
        }
        private void COMBOXCOURSE_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = @"SELECT G_ID,GRADE FROM tbGRADE 
                                INNER JOIN tbCOURSE ON tbGRADE.COID=tbCOURSE.COID 
                                WHERE tbCOURSE.CO_NAME=N'" + COMBOXCOURSE.Text + "'";
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            COMBOXGRADE.DataSource = null;
            COMBOXGRADE.Items.Clear();
            COMBOXGRADE.DataSource = dt;
            COMBOXGRADE.DisplayMember = "GRADE";
            COMBOXGRADE.ValueMember = "G_ID";
            COMBOXGRADE.Text = null;          
        }

        private void COMBOXGRADE_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = @"select STR_ID,ST_KH_Name from VIEW_REGISTER_STUDENT​ where GRADE='"+COMBOXGRADE.Text+"' ";
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            COMBOXSTUDENT.DataSource = null;
            COMBOXSTUDENT.Items.Clear();
            COMBOXSTUDENT.DataSource = dt;
            COMBOXSTUDENT.DisplayMember = "ST_KH_Name";
            COMBOXSTUDENT.ValueMember = "STR_ID";
            COMBOXSTUDENT.Text = null;
        }

        private void txtSpeaking_KeyPress(object sender, KeyPressEventArgs e)
        {
            Decimal X;
            char ch = e.KeyChar;
            if (ch == (char)8)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtSpeaking.Text + ch, out X))
            {
                e.Handled = true;
            }
        }

        private void txtLisent_KeyPress(object sender, KeyPressEventArgs e)
        {
            Decimal X;
            char ch = e.KeyChar;
            if (ch == (char)8)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtLisent.Text + ch, out X))
            {
                e.Handled = true;
            }
        }

        private void txtWritting_KeyPress(object sender, KeyPressEventArgs e)
        {
            Decimal X;
            char ch = e.KeyChar;
            if (ch == (char)8)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtWritting.Text + ch, out X))
            {
                e.Handled = true;
            }
        }
        int MOR;
        public void showresultandmention()
        {
            decimal av;
            bool isAVValid = decimal.TryParse(txtAVG.Text,out av);
            if (!isAVValid)
            {
                txtResult.Text = "";
                txtMention.Text = "";
            }
            else
            {
                if (av >= 90 && av <= 100)
                {
                    RESULT = "A";
                    MENTION = "ល្អប្រសើរ";
                }
                else if (av >= 80 && av <= 89)
                {
                    RESULT = "B";
                    MENTION = "ល្អណាស់";
                }
                else if (av >= 70 && av <= 79)
                {
                    RESULT = "C";
                    MENTION = "ល្អបង្គួរ";
                }
                else if (av >= 60 && av <= 69)
                {
                    RESULT = "D";
                    MENTION = "ល្អ";
                }
                else if (av >= 50 && av <= 59)
                {
                    RESULT = "E";
                    MENTION = "មធ្យម";
                }
                else
                {
                    RESULT = "F";
                    MENTION = "ធ្លាក់";
                }
                txtResult.Text = RESULT;
                txtMention.Text = MENTION;
            }
        }
        public void Total_sum()
        {
            int b;
            int a,c,d,e,f;
            bool isAValid = int.TryParse(txtDictation.Text, out a);
            bool isBValid = int.TryParse(txtSpeaking.Text, out b);
            bool isCValid = int.TryParse(txtLisent.Text, out c);
            bool isDValid = int.TryParse(txtWritting.Text, out d);
            bool isEValid = int.TryParse(txtPainting.Text, out e);
            bool isFValid = int.TryParse(txtMorality.Text, out f);
            if (!(isAValid && isBValid && isCValid && isDValid && isEValid && isFValid))
            {
                txtTotalScore.Text = "Invalid Input";
                txtAVG.Text = "បញ្ចូលពិន្ទុមិនទាន់គ្រប់";
            }
            else
            {
                txtTotalScore.Text = (a+b+c+d+e+f).ToString();
                txtAVG.Text = ((a + b + c + d + e + f)/6).ToString();
            }
        }
        private void txtDictation_TextChanged(object sender, EventArgs e)
        {
            Total_sum();
        }

        private void txtMorality_TextChanged(object sender, EventArgs e)
        {
            Total_sum();
        }

        private void txtPainting_TextChanged(object sender, EventArgs e)
        {
            Total_sum();
        }

        private void txtWritting_TextChanged(object sender, EventArgs e)
        {
            Total_sum();
        }

        private void txtLisent_TextChanged(object sender, EventArgs e)
        {
            Total_sum();
        }

        private void txtSpeaking_TextChanged(object sender, EventArgs e)
        {
            Total_sum();
        }

        private void txtAVG_TextChanged(object sender, EventArgs e)
        {
            showresultandmention();
        }

        private void DVG_FULLTIMESCORE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DVG_FULLTIMESCORE.Rows[e.RowIndex];
                id = int.Parse(row.Cells[0].Value.ToString());
                COMBOXSTUDENT.Text =row.Cells[1].Value.ToString();
                COMBOXTEACHER.Text = row.Cells[4].Value.ToString();
                COMBOXMONTH.Text = row.Cells[5].Value.ToString();
                txtSpeaking.Text = row.Cells[6].Value.ToString();
                txtLisent.Text = row.Cells[7].Value.ToString();
                txtWritting.Text = row.Cells[8].Value.ToString();
                txtPainting.Text = row.Cells[9].Value.ToString();
                txtMorality.Text = row.Cells[10].Value.ToString();
                txtDictation.Text = row.Cells[11].Value.ToString();
                txtTotalScore.Text = row.Cells[12].Value.ToString();
                txtAVG.Text = row.Cells[13].Value.ToString();
                txtResult.Text = row.Cells[14].Value.ToString();
                txtMention.Text = row.Cells[15].Value.ToString();
                STR = int.Parse(row.Cells[17].Value.ToString());
            }
            btUpdateData.Text = "កែប្រែពិន្ទុ";
            btnEnter.Enabled = false;
            GROUPFULLTIME.Enabled = true;
            GROUPPARTTIME.Enabled = false;
        }
        int id;
        private void btUpdateData_Click(object sender, EventArgs e)
        {
            if (btUpdateData.Text == "កែប្រែពិន្ទុ")
            {
              // STR = int.Parse(COMBOXSTUDENT.SelectedValue.ToString());
                TID = COMBOXTEACHER.SelectedValue.ToString();
                MON = COMBOXMONTH.Text;
                SP = int.Parse(txtSpeaking.Text);
                LIS = int.Parse(txtLisent.Text);
                WR = int.Parse(txtWritting.Text);
                PA = int.Parse(txtPainting.Text);
                MOR = int.Parse(txtMorality.Text);
                DIC = int.Parse(txtDictation.Text);
                TOTAL = SP + LIS + WR + PA + MOR + DIC;
                AVG = (SP + LIS + WR + PA + MOR + DIC) / 6;
                if (AVG >= 90 && AVG <= 100)
                {
                    RESULT = "A";
                    MENTION = "ល្អប្រសើរ";
                }
                else if (AVG >= 80 && AVG <= 89)
                {
                    RESULT = "B";
                    MENTION = "ល្អណាស់";
                }
                else if (AVG >= 70 && AVG <= 79)
                {
                    RESULT = "C";
                    MENTION = "ល្អបង្គួរ";
                }
                else if (AVG >= 60 && AVG <= 69)
                {
                    RESULT = "D";
                    MENTION = "ល្អ";
                }
                else if (AVG >= 50 && AVG <= 59)
                {
                    RESULT = "E";
                    MENTION = "មធ្យម";
                }
                else
                {
                    RESULT = "F";
                    MENTION = "ធ្លាក់";
                }
                FULLTIME_SCORE SC = new FULLTIME_SCORE(STR, TID, MON, SP, LIS, WR, PA, MOR, DIC, TOTAL, AVG, RESULT, MENTION);
                FULLTIME_SCORE.UPDATEFULL_SCORE(SC, id);
                SHOWFULLTIMESCORE();
                CLEARTEXT();
                btnEnter.Enabled = true;
            }
        }

        private void DVG_FULLTIMESCORE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                if (MessageBox.Show("តើអ្នកពិតជាត្រូវការលុបទិន្នន័យនេះមែនឬទេ?", "Warrning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    FULLTIME_SCORE.DeleteSCORE_FULLTIME(int.Parse(DVG_FULLTIMESCORE.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    SHOWFULLTIMESCORE();
                }
                return;
            }
        }

        private void txtPainting_KeyPress(object sender, KeyPressEventArgs e)
        {
            Decimal X;
            char ch = e.KeyChar;
            if (ch == (char)8)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtPainting.Text + ch, out X))
            {
                e.Handled = true;
            }
        }

        private void txtMorality_KeyPress(object sender, KeyPressEventArgs e)
        {
            Decimal X;
            char ch = e.KeyChar;
            if (ch == (char)8)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtMorality.Text + ch, out X))
            {
                e.Handled = true;
            }
        }

        private void txtDictation_KeyPress(object sender, KeyPressEventArgs e)
        {
            Decimal X;
            char ch = e.KeyChar;
            if (ch == (char)8)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtDictation.Text + ch, out X))
            {
                e.Handled = true;
            }
        }

        private void txtExam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Decimal X;
            char ch = e.KeyChar;
            if (ch == (char)8)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtExam1.Text + ch, out X))
            {
                e.Handled = true;
            }
        }

        private void txtExam2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Decimal X;
            char ch = e.KeyChar;
            if (ch == (char)8)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtExam2.Text + ch, out X))
            {
                e.Handled = true;
            }
        }

        private void txtMoral_KeyPress(object sender, KeyPressEventArgs e)
        {
            Decimal X;
            char ch = e.KeyChar;
            if (ch == (char)8)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtMoral.Text + ch, out X))
            {
                e.Handled = true;
            }
        }

        private void COMBOXCOURSE_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (COMBOXCOURSE.SelectedIndex != 2 && COMBOXCOURSE.SelectedIndex !=5 && COMBOXCOURSE.SelectedIndex !=6)
            {
                GROUPFULLTIME.Enabled = true;
                GROUPPARTTIME.Enabled = false;
            }
            else
            {
                GROUPPARTTIME.Enabled = true;
                GROUPFULLTIME.Enabled = false;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(COMBOXMONTH.Text))
            {
                MessageBox.Show("Please SELECT YOUR MONTH...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(COMBOXCOURSE.Text))
            {
                MessageBox.Show("Please SELECT YOUR COURSE...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(COMBOXGRADE.Text))
            {
                MessageBox.Show("Please SELECT YOUR GRADE LEVEL...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(COMBOXSTUDENT.Text))
            {
                MessageBox.Show("Please SELECT YOUR STUDENT...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            STR = int.Parse(COMBOXSTUDENT.SelectedValue.ToString());
            TID = COMBOXTEACHER.SelectedValue.ToString();
            MON = COMBOXMONTH.Text;
            SP = int.Parse(txtSpeaking.Text);
            LIS = int.Parse(txtLisent.Text);
            WR = int.Parse(txtWritting.Text);
            PA = int.Parse(txtPainting.Text);
           MOR = int.Parse(txtMorality.Text);
            DIC = int.Parse(txtDictation.Text);
            TOTAL =SP + LIS + WR + PA + MOR + DIC;
            AVG = (SP + LIS + WR + PA + MOR + DIC) / 6;
            if (AVG >= 90 && AVG <= 100)
            {
                RESULT = "A";
                MENTION = "ល្អប្រសើរ";
            }
            else if (AVG >= 80 && AVG <= 89)
            {
                RESULT = "B";
                MENTION = "ល្អណាស់";
            }
            else if (AVG >= 70 && AVG <= 79)
            {
                RESULT = "C";
                MENTION = "ល្អបង្គួរ";
            }
            else if (AVG >= 60 && AVG <= 69)
            {
                RESULT = "D";
                MENTION = "ល្អ";
            }
            else if (AVG >= 50 && AVG <= 59)
            {
                RESULT = "E";
                MENTION = "មធ្យម";
            }
            else
            {
                RESULT = "F";
                MENTION = "ធ្លាក់";
            }
            FULLTIME_SCORE SC = new FULLTIME_SCORE(STR,TID,MON,SP,LIS,WR,PA,MOR,DIC,TOTAL,AVG,RESULT,MENTION);
            FULLTIME_SCORE.ADDFULL_SCORE(SC);
            SHOWFULLTIMESCORE();
            CLEARTEXT();
        }
    }
}
