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
    public partial class kaisheForm : Form
    {
        public kaisheForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string teacher = textBoxteacher.Text;
            string classes =   textBoxclass.Text;
            string term =  comboBoxterm.SelectedItem.ToString();
            string flags = "1";
            SqlConnection conn = new SqlConnection(loginForm.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //将开课信息插入到开课表里
            
            //MessageBox.Show("开设课程成功！");
            string sql = "";
            //得到上课的地点
            string didian = comboBoxdidian.SelectedItem.ToString();
            //checkedListBoxtime

            for (int i = 0; i < checkedListBoxtime.Items.Count; i++)
            {
                if (checkedListBoxtime.GetItemChecked(i))
                {
                    string time = checkedListBoxtime.GetItemText(checkedListBoxtime.Items[i]);
                    sql = "select * from sctime where sctime = '" + time + "'and location = '" + didian + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        flags = "2";
                        MessageBox.Show("该时间该教室已经有课！");
                        break;
                    }
                    else
                    {
                        flags = "1";
                        break; 
                    }
                }
            }

            if (flags == "1")
            {
                sql = "insert into class (claname,term,teacher) values ('" + classes + "','" + term + "','" + teacher + "')";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();



                for (int i = 0; i < checkedListBoxtime.Items.Count; i++)
                {
                    if (checkedListBoxtime.GetItemChecked(i))
                    {
                        string time = checkedListBoxtime.GetItemText(checkedListBoxtime.Items[i]);
                        //将开课表的id得到
                        sql = "select claid from class where claname = '" + classes + "' and term = '" + term + "' and teacher = '" + teacher + "'";
                        cmd.CommandText = sql;
                        String id1 = cmd.ExecuteScalar().ToString();
                        int id = 0;
                        int.TryParse(id1, out id);
                        sql = "insert into sctime values(" + id + ",'" + time + "','" + didian + "')";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("开设课程成功！");
            }
   
            conn.Close();
        }

        private void kaisheForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
