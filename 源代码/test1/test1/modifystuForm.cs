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
    public partial class modifystuForm : Form
    {
        public modifystuForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void modifystuForm_Load(object sender, EventArgs e)
        {
            this.getRusult();
        }


        private void getRusult()
        {
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            //textBox1.Text.Trim()  textBox2.Text.Trim()
            string sql = "select stuid as 用户id,stuname as 真实姓名,stuxuehao as 学号,stupasswd as 密码,stugrade as 年级,stumajor as 专业,stusex as 性别,stuborn as 出生日期,stuhometown as 籍贯 from student";
            SqlDataAdapter adp1 = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp1.Fill(ds);
            //载入基本信息
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }

        private void mos_click(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxborn.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            comboBoxgrade.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBoxhometown.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            comboBoxmajor.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBoxpasswd.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBoxpname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string gender = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
           
            if (gender == "男")
            {
                radioButton1.Select();
            }
            else
            {
                radioButton2.Select();
            }
        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            string gender = radioButton1.Checked ? "男" : "女";
            int id = 0;
            int.TryParse(textBoxid.Text, out id);
            //this.comboBoxrole.SelectedItem.ToString()
            string major = comboBoxmajor.SelectedItem.ToString();
            string grade = comboBoxgrade.SelectedItem.ToString();
            string sql = "update student set stuname = '"+textBoxname.Text+"',stuborn = '"+textBoxborn.Text+"' ,stugrade = '"+grade+"' ,stuhometown = '"+textBoxhometown.Text+"' ,stumajor = '"+major+"',stupasswd = '"+textBoxpasswd.Text+"',stuxuehao = '"+textBoxpname.Text+"',stusex = '"+gender+"' where stuid = "+id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("更改成功！");
                this.getRusult();
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            int id = 0;
            int.TryParse(textBoxid.Text, out id);
            string sql = "delete from  student  where  stuid = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("删除成功！");
                this.getRusult();
            }

            conn.Close();
        }
    }
}

  