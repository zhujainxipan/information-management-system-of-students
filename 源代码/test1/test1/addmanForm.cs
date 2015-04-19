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
    public partial class addmanForm : Form
    {
        public addmanForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim()== "")
            {
                MessageBox.Show("请将信息填写完整!");
            }
            else
            {
                if (textBox2.Text.Trim() != textBox3.Text.Trim())
                {
                    MessageBox.Show("两次输入的密码不一致!");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(loginForm.connectionString);
                    conn.Open();
                    string sql = "select * from manager where manname = '"+textBox1.Text+"'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("已经存在的用户名称！");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        sql = "insert into manager (manname,manpasswd) values ('"
                            + textBox1.Text.Trim() + "','" +textBox2.Text.Trim()+"')";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("添加用户成功！");
                    }
                    conn.Close();
                }

            }
        
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addmanForm_Load(object sender, EventArgs e)
        {

        }
    }
}
