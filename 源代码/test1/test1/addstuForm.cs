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
    public partial class addstuForm : Form
    {
        public addstuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             SqlConnection conn = new SqlConnection(loginForm.connectionString);
                    conn.Open();
                    string sql = "select * from student where stuxuehao='" + textBoxpname.Text.Trim() + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("已经存在的学生学号！");
                    }

                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        string gender = radioButton1.Checked ? "男" : "女";
                        sql = "insert into student(stuname,stuxuehao ,stupasswd,stugrade ,stumajor,stusex,stuborn,stuhometown)values('" + textBoxname.Text.Trim() + "','" + textBoxpname.Text.Trim() + "','" + textBoxpasswd.Text.Trim() + "','" + comboBoxgrade.SelectedItem.ToString() + "','" + comboBoxmajor.SelectedItem.ToString() + "','" + gender + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + textBoxhometown.Text.Trim() + "')";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("添加用户成功！");
                    }
                    conn.Close();
                }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxgrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

