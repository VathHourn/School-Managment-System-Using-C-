using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFL_SMS.PAL.User_Control
{
    public partial class UserControlDashboard : UserControl
    {
        private string sql = @"Data Source=LAPTOP-R76U6T47\SQLEXPRESS;Initial Catalog=bfl_sms; Integrated Security=True;";
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            Count();
        }
        public void Count()
        {
            labelClass.Text = Attendance.Attendance.Count("SELECT COUNT(*) FROM Class_Table", sql).ToString() +
                                       Attendance.Attendance.Count("SELECT COUNT(*) FROM Class_Table", sql).ToString(" នាក់");

            labelStudent.Text = Attendance.Attendance.Count("SELECT COUNT(*) FROM Student_Table", sql).ToString() +
                                      Attendance.Attendance.Count("SELECT COUNT(*) FROM Student_Table", sql).ToString("នាក់");
        }
    }
}
