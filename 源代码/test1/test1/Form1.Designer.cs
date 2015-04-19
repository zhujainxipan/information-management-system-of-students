namespace test1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("添加管理员信息");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("修改管理员信息");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("管理员信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("退出系统");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("系统管理", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("开设课程");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("查询课程");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("课程管理", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("录入成绩");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("统计成绩");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("修改成绩");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("成绩管理", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("添加学生信息");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("修改学生信息");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("学生信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("修改密码");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("关于");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.LineColor = System.Drawing.Color.LightGray;
            this.treeView1.Location = new System.Drawing.Point(4, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "addMan";
            treeNode1.Text = "添加管理员信息";
            treeNode2.Name = "modifyMan";
            treeNode2.Text = "修改管理员信息";
            treeNode3.Name = "manMan";
            treeNode3.Text = "管理员信息管理";
            treeNode4.Name = "节点0";
            treeNode4.Text = "退出系统";
            treeNode5.Name = "userInfo";
            treeNode5.SelectedImageIndex = 2;
            treeNode5.Text = "系统管理";
            treeNode6.Name = "addCL";
            treeNode6.Text = "开设课程";
            treeNode7.Name = "searchCL";
            treeNode7.Text = "查询课程";
            treeNode8.Name = "classMan";
            treeNode8.Text = "课程管理";
            treeNode9.Checked = true;
            treeNode9.Name = "luruCJ";
            treeNode9.NodeFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode9.Text = "录入成绩";
            treeNode10.Name = "tongjiCJ";
            treeNode10.Text = "统计成绩";
            treeNode11.Name = "节点0";
            treeNode11.Text = "修改成绩";
            treeNode12.Name = "chengjiMan";
            treeNode12.Text = "成绩管理";
            treeNode13.Name = "addStu";
            treeNode13.Text = "添加学生信息";
            treeNode14.Name = "modifyStu";
            treeNode14.Text = "修改学生信息";
            treeNode15.Name = "studentMan";
            treeNode15.Text = "学生信息管理";
            treeNode16.Name = "节点0";
            treeNode16.Text = "修改密码";
            treeNode17.Name = "about";
            treeNode17.Text = "关于";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode12,
            treeNode15,
            treeNode16,
            treeNode17});
            this.treeView1.Size = new System.Drawing.Size(166, 519);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::test1.Properties.Resources._2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(186, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 519);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生综合教务系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_close);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel2;
    }
}

