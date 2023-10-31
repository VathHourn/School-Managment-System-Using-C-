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
    class PARTTIME_SCORE
    {
        public int STR_ID { get; set; }
        public string TEACHERID { get; set; }
        public string MONTH { get; set; }
        public int EXAM1 { get; set; }
        public int EXAM2 { get; set; }
        public Decimal TOTAL { get; set; }
        public Decimal AVERAGE { get; set; }
        public string RESULT { get; set; }
        public string MENTION { get; set; }
        public int RANK { get; set; }
    }
}
