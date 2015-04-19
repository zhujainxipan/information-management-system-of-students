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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (this.treeView1.SelectedNode.Text)
            {
                
                case "我的成绩单":
                    searchgradeForm f1 = new searchgradeForm();
                    f1.TopLevel = false;
                    f1.FormBorderStyle = FormBorderStyle.None;
                    f1.WindowState = FormWindowState.Maximized;

                    panel1.Controls.Add(f1);
                    f1.Show();
                    break;
               
               
                case "选择课程":
                    chooseForm f4 = new chooseForm();
                    f4.TopLevel = false;
                    f4.FormBorderStyle = FormBorderStyle.None;
                    f4.WindowState = FormWindowState.Maximized;

                    panel1.Controls.Add(f4);
                    f4.Show();
                    break;
                case "查询课程":
                    searchclassForm f5 = new searchclassForm();
                    f5.TopLevel = false;
                    f5.FormBorderStyle = FormBorderStyle.None;
                    f5.WindowState = FormWindowState.Maximized;

                    panel1.Controls.Add(f5);
                    f5.Show();
                    break;
               
               
               
                case "关于":
                    aboutForm f12 = new aboutForm();
                    f12.TopLevel = false;
                    f12.FormBorderStyle = FormBorderStyle.None;
                    f12.WindowState = FormWindowState.Maximized;

                    panel1.Controls.Add(f12);
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
                    panel1.Controls.Add(f13);
                    f13.Show();
                    break;

                case "修改密码":
                    modifymimaForm f14 = new modifymimaForm();
                    f14.TopLevel = false;
                    f14.FormBorderStyle = FormBorderStyle.None;
                    f14.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(f14);
                    f14.Show();
                    break;
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
