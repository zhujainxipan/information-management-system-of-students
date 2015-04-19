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
    public partial class searchclassForm : Form
    {
        public searchclassForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.DataSource = null;
            }
            if (comboBoxterm.Text == "" && textBoxclass.Text == "")
            {
                MessageBox.Show("请输入查询信息！");
            }
            else if (comboBoxterm.Text != "" && textBoxclass.Text == "")
            {
                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                string sql = "select claid as 课程id,claname as 课程名,term as 学期,teacher as 老师 from class where term = '" + comboBoxterm.SelectedItem.ToString() + "'";
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                conn.Close();
            }
            else if (textBoxclass.Text != "" && comboBoxterm.Text == "")
            {
                
                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                //textBox1.Text.Trim()  textBox2.Text.Trim()
                string sql = "select claid as 课程id,claname as 课程名,term as 学期,teacher as 老师 from class  where claname = '" + textBoxclass.Text + "'";
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                conn.Close();


            }
            else if (textBoxclass.Text != "" && comboBoxterm.Text != "")
            {
               
                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                //textBox1.Text.Trim()  textBox2.Text.Trim()
                string sql = "select claid as 课程id,claname as 课程名,term as 学期,teacher as 老师 from class  where claname = '" + textBoxclass.Text + "'and term ='" + comboBoxterm.SelectedItem.ToString() + "'";
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                conn.Close();

            }



        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                string claid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                //textBox1.Text.Trim()  textBox2.Text.Trim()
                string sql = "select sctime as 上课时间,location as 上课地点 from sctime where claid="+claid;
                SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adp1.Fill(ds);
                //载入基本信息
                dataGridView2.DataSource = ds.Tables[0].DefaultView;
                conn.Close();
            }
        }
    }
}
