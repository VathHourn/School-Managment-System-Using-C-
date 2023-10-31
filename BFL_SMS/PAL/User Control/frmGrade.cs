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
namespace BFL_SMS.PAL.User_Control
{
    public partial class frmGrade : UserControl
    {
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = DBCONNECTION.GetConnection();
        public frmGrade()
        {
            InitializeComponent();         
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           // txtGrade_ID.Clear();
           // txtGrade.Clear();
           //// cmbCourse.Text = null;
           // txtCourseGrade.Clear();
           // AutoGradeID();
           // txtGrade.Focus();
        }
        public void GradeShow()
        {
            string sql = @"SELECT tbGRADE.G_ID, tbGRADE.GRADE,tbCOURSE.CO_NAME,tbGRADE.COID from tbGRADE inner join
                             tbCOURSE on tbGRADE.COID = tbCOURSE.COID";
            Grade_Infomation.DisplayData(sql, DVG_GradeShow);
        }

        public void ClassroomShow()
        {
            string sql = @"SELECT tbCLASSROOM.R_ID,tbCLASSROOM.CL_ROOM, tbGRADE.GRADE,tbGRADE.G_ID from tbCLASSROOM inner join
                             tbGRADE on tbCLASSROOM.G_ID = tbGRADE.G_ID";
            CLASSROOM_INFOMATION.DisplayData(sql, DVG_ClassRoomShow);
        }
        public void SHIFTShow()
        {
            string sql = @"SELECT * FROM tbSTUDY_SHIFT";
            SHIFT_INFOMATION.DisplayData(sql, DVG_SHIFTSHOW);
        }
        private void frmGrade_Load(object sender, EventArgs e)
        {
            GradeShow();
            ClassroomShow();
            SHIFTShow();
            PopulateCourse();
            cmbCourse.Text = null;           
            AutoGradeID();
            LoadGRADE();
            cmbGrade.Text = null;
        }
        public void AutoGradeID()
        {
            SqlConnection con = DBCONNECTION.GetConnection();
            cmd = new SqlCommand("Select Max(G_ID)+1 from tbGRADE", con);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    txtGrade_ID.Text = dr[0].ToString();
                    if (txtGrade_ID.Text == "")
                    {
                        txtGrade_ID.Text = "1";

                    }
                }
            }
            else
            {
                txtGrade_ID.Text = "1";
                return;
            }
            con.Close();
        }
        public void LoadGRADE()
        {
            da = new SqlDataAdapter("select G_ID,GRADE from tbGRADE", con);
            dt = new DataTable();
            da.Fill(dt);
            cmbGrade.DataSource = null;
            cmbGrade.Items.Clear();
            cmbGrade.DataSource = dt;
            cmbGrade.DisplayMember = "GRADE";
            cmbGrade.ValueMember = "G_ID";
        }
        public void PopulateCourse()
        {
            da = new SqlDataAdapter("select COID,CO_NAME from tbCOURSE", con);
            dt = new DataTable();
            da.Fill(dt);
            cmbCourse.DataSource = null;
            cmbCourse.Items.Clear();
            cmbCourse.DataSource = dt;
            cmbCourse.DisplayMember = "CO_NAME";
            cmbCourse.ValueMember = "COID";
        }
        private void btnGradeAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGrade.Text))
            {
                MessageBox.Show("Please input Grade...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(cmbCourse.Text))
            {
                MessageBox.Show("Please input course Name...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //int.Parse(txtGrade_ID.Text),
                Grade_Infomation g = new Grade_Infomation(txtGrade.Text, cmbCourse.SelectedValue.ToString());
                Grade_Infomation.ADDGrade(g);
            }
            txtGrade_ID.Clear();
            txtGrade.Clear();
            cmbCourse.Text = null;
            txtCourseGrade.Clear();
            AutoGradeID();
            GradeShow();
            txtGrade.Focus();
            LoadGRADE();
            frmStudent_Control st = new frmStudent_Control();
            st.LoadGRADE();
        }

        private void DVG_GradeShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                if (MessageBox.Show("តើអ្នកពិតជាត្រូវការលុបទិន្នន័យនេះមែនឬទេ?", "Warrning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Grade_Infomation.DeleteGrade(int.Parse(DVG_GradeShow.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    GradeShow();
                }
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGrade.Text))
            {
                MessageBox.Show("Please input Grade...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(cmbCourse.Text))
            {
                MessageBox.Show("Please input course Name...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
               // int id= int.Parse(txtGrade_ID.Text),
                Grade_Infomation g = new Grade_Infomation(txtGrade.Text, txtCourseGrade.Text);
                Grade_Infomation.UpdateGrade(g, int.Parse(txtGrade_ID.Text));
            }
            txtGrade_ID.Clear();
            txtGrade.Clear();
            cmbCourse.Text = null;
            txtCourseGrade.Clear();
            AutoGradeID();
            GradeShow();
            txtGrade.Focus();
        }

        private void DVG_GradeShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DVG_GradeShow.Rows[e.RowIndex];
                txtGrade_ID.Text = row.Cells[0].Value.ToString();
                txtGrade.Text = row.Cells[1].Value.ToString();
                cmbCourse.Text = row.Cells[2].Value.ToString();
                txtCourseGrade.Text = row.Cells[3].Value.ToString();
                return;
            }
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbCourse.SelectedIndex == -1)
            //{
            //    txtCourseGrade.Text = "";
            //}
            //else
            //{
            //    SqlConnection con = DBCONNECTION.GetConnection();
            //    cmd = new SqlCommand("Select COID From tbCOURSE Where CO_NAME=N'" + cmbCourse.Text + "'", con);
            //    try
            //    {
            //        dr = cmd.ExecuteReader();
            //        while (dr.Read())
            //        {
            //            string cid = dr["COID"].ToString();
            //            txtCourseGrade.Text = cid;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    con.Close();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtGrade_ID.Clear();
            txtGrade.Clear();
            cmbCourse.Text = null;
            txtCourseGrade.Clear();
            AutoGradeID();
            txtGrade.Focus();
        }

        private void DVG_ClassRoomShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DVG_ClassRoomShow.Rows[e.RowIndex];
                txtClassroomID.Text = row.Cells[0].Value.ToString();
                txtClassroom.Text = row.Cells[1].Value.ToString();
                cmbGrade.Text = row.Cells[2].Value.ToString();
                txtCourseGrade.Text = row.Cells[3].Value.ToString();
                return;
            }
        }

        private void DVG_ClassRoomShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                if (MessageBox.Show("តើអ្នកពិតជាត្រូវការលុបទិន្នន័យនេះមែនឬទេ?", "Warrning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CLASSROOM_INFOMATION.DeleteRoom(int.Parse(DVG_ClassRoomShow.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    ClassroomShow();
                }
                return;
            }
        }

        private void btnEditClassroom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClassroom.Text))
            {
                MessageBox.Show("Please input Grade...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(cmbGrade.Text))
            {
                MessageBox.Show("Please input course Name...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                CLASSROOM_INFOMATION cl = new CLASSROOM_INFOMATION(txtClassroom.Text, int.Parse(cmbGrade.SelectedValue.ToString()));
                CLASSROOM_INFOMATION.UpdateRoom(cl, int.Parse(txtClassroomID.Text));
            }
            txtClassroom.Clear();
            txtClassroomID.Clear();
            cmbGrade.Text = null;                     
            ClassroomShow();
            txtClassroom.Focus();
        }

        private void btnAddClassroom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClassroom.Text))
            {
                MessageBox.Show("Please input Grade...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(cmbGrade.Text))
            {
                MessageBox.Show("Please input course Name...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                CLASSROOM_INFOMATION cl = new CLASSROOM_INFOMATION(txtClassroom.Text, int.Parse(cmbGrade.SelectedValue.ToString()));
                CLASSROOM_INFOMATION.AddRoom(cl);
            }
            txtClassroom.Clear();
            txtClassroomID.Clear();
            cmbGrade.Text = null;
            ClassroomShow();
            txtClassroom.Focus();
            LoadGRADE();
            frmStudent_Control st = new frmStudent_Control();
            st.LoadClass();
        }

        private void btnClearShift_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtShiftStudy.Clear();
            dtSart.Text =string.Empty;
            dtEnds.Text = string.Empty;
        }

        private void DVG_SHIFTSHOW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DVG_SHIFTSHOW.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtShiftStudy.Text = row.Cells[1].Value.ToString();
                dtSart.Text = row.Cells[2].Value.ToString();
                dtEnds.Text = row.Cells[3].Value.ToString();
                return;
            }
        }

        private void DVG_SHIFTSHOW_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                if (MessageBox.Show("តើអ្នកពិតជាត្រូវការលុបទិន្នន័យនេះមែនឬទេ?", "Warrning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SHIFT_INFOMATION.DeleteSHIFT(int.Parse(DVG_SHIFTSHOW.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    SHIFTShow();
                }
                return;
            }
        }        
        private void btnShiftEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please input ID...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SHIFT_INFOMATION shift = new SHIFT_INFOMATION(txtShiftStudy.Text, TimeSpan.Parse(dtSart.Text),TimeSpan.Parse(dtEnds.Text));
                SHIFT_INFOMATION.UPDATESHIFT(shift, int.Parse(txtID.Text));
                SHIFTShow();
                txtID.Clear();
                txtShiftStudy.Clear();
                dtSart.Text = string.Empty;
                dtEnds.Text = string.Empty;
            }
        }

        private void btnShiftAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtShiftStudy.Text))
            {
                MessageBox.Show("Please input Shift...", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SHIFT_INFOMATION shift = new SHIFT_INFOMATION(txtShiftStudy.Text, TimeSpan.Parse(dtSart.Text), TimeSpan.Parse(dtEnds.Text));
                SHIFT_INFOMATION.ADDSHIFT(shift);
                SHIFTShow();
                txtID.Clear();
                txtShiftStudy.Clear();
                dtSart.Text = string.Empty;
                dtEnds.Text = string.Empty;
                txtShiftStudy.Focus();
            }
        }
    }
}
