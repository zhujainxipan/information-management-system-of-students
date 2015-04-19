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
    public partial class modifymimaForm : Form
    {
        public modifymimaForm()
        {
            InitializeComponent();
        }

        private void modifymimaForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = loginForm.getStudent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passwd = textBox2.Text;
            string quepasswd = textBox3.Text;
             SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            if (passwd == "" || quepasswd == "")
            {
                MessageBox.Show("请将信息填写完整!");
            }
            else
            {
                if (quepasswd != passwd)
                {
                    MessageBox.Show("两次输入的密码不一致!");
                }
                else
                {
                   
                    if(loginForm.getRole()=="学生")
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        string sql = "update student set stupasswd ='"+ passwd+"' where stuxuehao = '"+textBox1.Text+"'";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改密码成功！");

                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        string sql = "update manager set manpasswd ='"+ passwd+"' where manname = '"+textBox1.Text+"'";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改密码成功！");

                    }
                    
                       
                    }
                    conn.Close();
                }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        }
    }

