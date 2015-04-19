using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           switch (this.treeView1.SelectedNode.Text)
            {
              case"录入成绩":
                    Form2 f = new Form2();
                 f.TopLevel = false;
                 f.FormBorderStyle = FormBorderStyle.None;
                 f.WindowState = FormWindowState.Maximized;
                 panel2.Controls.Add(f);
                 f.Show();
                 break;
              case"我的成绩单":
                 searchgradeForm f1 = new searchgradeForm();
                 f1.TopLevel = false;
                 f1.FormBorderStyle = FormBorderStyle.None;
                 f1.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f1);
                 f1.Show();
                 break;
              case"统计成绩":
                 countForm f2 = new countForm();
                 f2.TopLevel = false;
                 f2.FormBorderStyle = FormBorderStyle.None;
                 f2.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f2);
                 f2.Show();
                 break;
              case"开设课程":
                 kaisheForm f3 = new kaisheForm();
                 f3.TopLevel = false;
                 f3.FormBorderStyle = FormBorderStyle.None;
                 f3.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f3);
                 f3.Show();
                 break;
              case"选择课程":
                 chooseForm f4 = new chooseForm();
                 f4.TopLevel = false;
                 f4.FormBorderStyle = FormBorderStyle.None;
                 f4.WindowState = FormWindowState.Maximized;
                 
                 panel2.Controls.Add(f4);
                 f4.Show();
                 break;
              case"查询课程":
                 searchclassForm f5 = new searchclassForm();
                 f5.TopLevel = false;
                 f5.FormBorderStyle = FormBorderStyle.None;
                 f5.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f5);
                 f5.Show();
                 break;
              case"添加管理员信息":
                 addmanForm f6 = new addmanForm();
                 f6.TopLevel = false;
                 f6.FormBorderStyle = FormBorderStyle.None;
                 f6.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f6);
                 f6.Show();
                 break;
              case"修改管理员信息":
                 modifymanForm f7 = new modifymanForm();
                 f7.TopLevel = false;
                 f7.FormBorderStyle = FormBorderStyle.None;
                 f7.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f7);
                 f7.Show();
                 break;
              case"添加教师信息":
                 addteacForm f8 = new addteacForm();
                 f8.TopLevel = false;
                 f8.FormBorderStyle = FormBorderStyle.None;
                 f8.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f8);
                 f8.Show();
                 break;
              case"修改教师信息":
                 modifyteacForm f9 = new modifyteacForm();
                 f9.TopLevel = false;
                 f9.FormBorderStyle = FormBorderStyle.None;
                 f9.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f9);
                 f9.Show();
                 break;
              case"添加学生信息":
                 addstuForm f10 = new addstuForm();
                 f10.TopLevel = false;
                 f10.FormBorderStyle = FormBorderStyle.None;
                 f10.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f10);
                 f10.Show();
                 break;
              case"修改学生信息":
                 modifystuForm f11 = new modifystuForm();
                 f11.TopLevel = false;
                 f11.FormBorderStyle = FormBorderStyle.None;
                 f11.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f11);
                 f11.Show();
                 break;
              case"关于":
                 aboutForm f12 = new aboutForm();
                 f12.TopLevel = false;
                 f12.FormBorderStyle = FormBorderStyle.None;
                 f12.WindowState = FormWindowState.Maximized;
                
                 panel2.Controls.Add(f12);
                 f12.Show();
                 break;
              case "退出系统":
                 Application.Exit();
                 break;
              case "显示课表":
                 showkebiaoForm f13 = new showkebiaoForm();
                 f13.TopLevel = false;
                 f13.FormBorderStyle = FormBorderStyle.None;
                 f13.WindowState = FormWindowState.Maximized;
                 panel2.Controls.Add(f13);
                 f13.Show();
                 break;

              case "修改密码":
                 modifymimaForm f14 = new modifymimaForm();
                 f14.TopLevel = false;
                 f14.FormBorderStyle = FormBorderStyle.None;
                 f14.WindowState = FormWindowState.Maximized;
                 panel2.Controls.Add(f14);
                 f14.Show();
                 break;
              case "修改成绩":
                 modifygradeFram f15 = new modifygradeFram();
                 f15.TopLevel = false;
                 f15.FormBorderStyle = FormBorderStyle.None;
                 f15.WindowState = FormWindowState.Maximized;
                 panel2.Controls.Add(f15);
                 f15.Show();
                 break;
             }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //loginForm login = new loginForm();
            //login.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
