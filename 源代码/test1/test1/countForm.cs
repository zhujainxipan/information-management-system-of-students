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
    public partial class countForm : Form
    {
        public countForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string term = comboBox1.SelectedItem.ToString();
            string claname = textBoxclass.Text;
            string g1 = textBox1.Text;
            int grade1 = 0;
            int.TryParse(g1, out grade1);
            string g2 = textBox2.Text;
            int grade2 = 0;
            int.TryParse(g2, out grade2);
            if (term == "" || claname == "")
            {
                MessageBox.Show("请将信息输入完整！");
            }
            else
            {


                if (g1 == "" || g2 == "")
                {
                    SqlConnection conn = new SqlConnection(loginForm.connectionString);
                    conn.Open();
                    //textBox1.Text.Trim()  textBox2.Text.Trim()
                    string sql = "select class.claname as 课程名称,student.stuxuehao as 学生学号,stuname as 学生姓名,sc.grades as 成绩,class.term as 开课学期,class.teacher as 开课教师 from student,sc,class where student.stuid = sc.stuid and sc.claid = class.claid and term = '"+term+"' and class.claname = '"+claname+"'";
                    SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adp1.Fill(ds);
                    //载入基本信息
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    //求的平均成绩并显示
                    sql = "select avg(grades) from sc,class where sc.claid = class.claid and class.claname ='" + claname + "'";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    String avg = cmd.ExecuteScalar().ToString();
                    textBoxav.Text = avg;
                    //求的最高成绩并显示
                    sql = "select max(grades) from sc,class where sc.claid = class.claid and class.claname ='" + claname + "'";
                    
                    cmd.CommandText = sql;
                    String max = cmd.ExecuteScalar().ToString();
                    textBoxmax.Text = max;
                    //求的最低成绩并显示
                    sql = "select min(grades) from sc,class where sc.claid = class.claid and class.claname ='" + claname + "'";
                    cmd.CommandText = sql;
                    String min = cmd.ExecuteScalar().ToString();
                    textBoxmin.Text = min;
                    conn.Close();
                }
                else
                {
                    SqlConnection conn = new SqlConnection(loginForm.connectionString);
                    conn.Open();
                    //textBox1.Text.Trim()  textBox2.Text.Trim()
                    string sql = "select class.claname as 课程名称,stuxuehao as 学生学号,student.stuname as 学生姓名,sc.grades as 成绩,class.term as 开课学期,class.teacher as 开课教师 from student,sc,class where student.stuid = sc.stuid and sc.claid = class.claid and term = '" + term + "' and class.claname = '" + claname + "'and grades between "+grade1+" and "+grade2;
                    SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adp1.Fill(ds);
                    //载入基本信息
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    conn.Close();
                }


            }
           
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void countForm_Load(object sender, EventArgs e)
        {

        }
    }
}
