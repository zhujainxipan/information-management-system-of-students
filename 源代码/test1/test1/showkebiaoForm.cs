using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace test1
{
    public partial class showkebiaoForm : Form
    {
        public showkebiaoForm()
        {
            InitializeComponent();
        }

        private void showkebiaoForm_Load(object sender, EventArgs e)
        {
            //首先得到用户的id
            string stuxuehao = loginForm.getStudent();
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            string sql = "select stuid from student where stuxuehao = '" + stuxuehao + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            String id1 = cmd.ExecuteScalar().ToString();
            int stuid = 0;
            int.TryParse(id1, out stuid);
            //用到两个数据库的连接操作

            sql = "select class.claid as 课程id,class.claname as 课程名称,class.teacher as 教师姓名,class.term as 学期,sctime.sctime as 上课时间,sctime.location as 上课地点 from sc,sctime,class where class.claid=sc.claid and sc.claid=sctime.claid and sc.stuid=" + stuid;
            SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            //载入基本信息
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
