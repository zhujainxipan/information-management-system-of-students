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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
           
        }

        private void panelclass_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxstudent.Text = listBox2.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {//清空所有项
                listBox1.Items.Clear();
            }
            if (textBoxclass.Text != ""||textBoxstudent.Text!="")
            {
                textBoxclass.Text = "";
                textBoxstudent.Text = "";
            }
            string term = comboBox1.SelectedItem.ToString();
            Console.WriteLine(term);
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            string sql = "select claname  from class where term='" + term + "'";
            SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            //载入基本信息
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listBox1.Items.Add(row[0].ToString());
            }
            //dataGridView1.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }
        private void class_click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {//清空所有项
                listBox2.Items.Clear();
            }
            textBoxstudent.Text = "";
            string classname = listBox1.SelectedItem.ToString();
            textBoxclass.Text = classname;
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            string sql = "select student.stuxuehao from student,class,sc where student.stuid=sc.stuid and class.claid=sc.claid and class.claname='" + classname+"'";
            SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listBox2.Items.Add(row[0].ToString());
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //根据学生的学号得到学生的id
            string stuxuehao = textBoxstudent.Text;
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            string sql = "select stuid from student where stuxuehao = '" + stuxuehao + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            String id1 = cmd.ExecuteScalar().ToString();
            int stuid = 0;
            int.TryParse(id1, out stuid);
            //根据课程名得到课程的id
            string claname = textBoxclass.Text;
            sql = "select claid from class where claname='"+claname+"'";
            cmd.CommandText = sql;
            String id2 = cmd.ExecuteScalar().ToString();
            int claid = 0;
            int.TryParse(id2, out claid);
            //得到相应的学生id，课程id，以及输入的成绩，将他们更新到sc表中，即更新成绩
            int grade = 0;
            int.TryParse(textBoxgrade.Text, out grade);
            //开始插入选课信息表中
            sql = "update  sc set grades = "+grade+" where claid  = "+claid+" and stuid = "+stuid;
            cmd.CommandText = sql;
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("输入成绩成功！");
                textBoxgrade.Text = "";
                textBoxclass.Text = "";
                textBoxstudent.Text = "";
            }
            conn.Close();   
            

            

        }

        private void textBoxstudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
