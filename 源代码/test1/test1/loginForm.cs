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
    public partial class loginForm : Form
    {
        public static string connectionString = "uid=sa;pwd=123456;initial catalog=student;data source=127.0.0.1;Connect Timeout=900";
        public static  string name;
        public static string role;
       
        public loginForm()
        {
            

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBoxname.Text.Trim();
            role = this.comboBoxrole.SelectedItem.ToString();
            if (name == "" || textBoxpasswd.Text.Trim() == "" || role == "")
            {
                MessageBox.Show("请将信息输入完整！");
            }
            else
            {
                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                if (role == "管理员")
                {
                    string sql = "select manname,manpasswd from manager where role='管理员'and manname='" + name +
                     "' and manpasswd='" + textBoxpasswd.Text.Trim() + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();
                        Form1 mainframe = new Form1();
                        mainframe.BringToFront();
                        mainframe.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("用户名或者密码错误！");
                    }
                }
                else if (role == "学生")
                {
                    string sql1 = "select stuxuehao,stupasswd from student where role='学生'and stuxuehao='" + name +
                     "' and stupasswd='" + textBoxpasswd.Text.Trim() + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //this.Close();
                        conn.Close();
                        Form3 mainframe = new Form3();
                        mainframe.BringToFront();
                        mainframe.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户名或者密码错误！");
                    }
                }
               
            }
          


        }






        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void loginForm_Load(object sender, EventArgs e)
        {
           
            
        }

        private void comboBoxrole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static  String getStudent()
        {
            String stuxuehao = "";
            stuxuehao = loginForm.name;
            return stuxuehao;
        }

        public static String getRole()
        {
            String role1 = "";
            role1 = role;
            return role1;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     

       

       


      

       
       


    }
}
