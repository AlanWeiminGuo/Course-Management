namespace first_try
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tooltime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生缺勤记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询缺勤记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示并编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑与修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除学生记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tooltime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 622);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(425, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabel1.Text = "欢迎使用本系统！";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(273, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // tooltime
            // 
            this.tooltime.Name = "tooltime";
            this.tooltime.Size = new System.Drawing.Size(33, 17);
            this.tooltime.Text = "time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.添加ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.其他工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加学生信息ToolStripMenuItem,
            this.添加学生缺勤记录ToolStripMenuItem});
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.添加ToolStripMenuItem.Text = "添加";
            // 
            // 添加学生信息ToolStripMenuItem
            // 
            this.添加学生信息ToolStripMenuItem.Name = "添加学生信息ToolStripMenuItem";
            this.添加学生信息ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.添加学生信息ToolStripMenuItem.Text = "添加学生信息";
            this.添加学生信息ToolStripMenuItem.Click += new System.EventHandler(this.添加学生信息ToolStripMenuItem_Click);
            // 
            // 添加学生缺勤记录ToolStripMenuItem
            // 
            this.添加学生缺勤记录ToolStripMenuItem.Name = "添加学生缺勤记录ToolStripMenuItem";
            this.添加学生缺勤记录ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.添加学生缺勤记录ToolStripMenuItem.Text = "添加学生缺勤记录";
            this.添加学生缺勤记录ToolStripMenuItem.Click += new System.EventHandler(this.添加学生缺勤记录ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询学生信息ToolStripMenuItem,
            this.查询缺勤记录ToolStripMenuItem});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // 查询学生信息ToolStripMenuItem
            // 
            this.查询学生信息ToolStripMenuItem.Name = "查询学生信息ToolStripMenuItem";
            this.查询学生信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查询学生信息ToolStripMenuItem.Text = "查询学生信息";
            this.查询学生信息ToolStripMenuItem.Click += new System.EventHandler(this.查询学生信息ToolStripMenuItem_Click);
            // 
            // 查询缺勤记录ToolStripMenuItem
            // 
            this.查询缺勤记录ToolStripMenuItem.Name = "查询缺勤记录ToolStripMenuItem";
            this.查询缺勤记录ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查询缺勤记录ToolStripMenuItem.Text = "查询缺勤记录";
            this.查询缺勤记录ToolStripMenuItem.Click += new System.EventHandler(this.查询缺勤记录ToolStripMenuItem_Click);
            // 
            // 其他工具ToolStripMenuItem
            // 
            this.其他工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示并编辑ToolStripMenuItem,
            this.编辑与修改ToolStripMenuItem,
            this.删除学生记录ToolStripMenuItem});
            this.其他工具ToolStripMenuItem.Name = "其他工具ToolStripMenuItem";
            this.其他工具ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.其他工具ToolStripMenuItem.Text = "其他工具";
            // 
            // 显示并编辑ToolStripMenuItem
            // 
            this.显示并编辑ToolStripMenuItem.Name = "显示并编辑ToolStripMenuItem";
            this.显示并编辑ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.显示并编辑ToolStripMenuItem.Text = "显示";
            this.显示并编辑ToolStripMenuItem.Click += new System.EventHandler(this.显示并编辑ToolStripMenuItem_Click);
            // 
            // 编辑与修改ToolStripMenuItem
            // 
            this.编辑与修改ToolStripMenuItem.Name = "编辑与修改ToolStripMenuItem";
            this.编辑与修改ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.编辑与修改ToolStripMenuItem.Text = "编辑与修改";
            this.编辑与修改ToolStripMenuItem.Click += new System.EventHandler(this.编辑与修改ToolStripMenuItem_Click);
            // 
            // 删除学生记录ToolStripMenuItem
            // 
            this.删除学生记录ToolStripMenuItem.Name = "删除学生记录ToolStripMenuItem";
            this.删除学生记录ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除学生记录ToolStripMenuItem.Text = "删除学生记录";
            this.删除学生记录ToolStripMenuItem.Click += new System.EventHandler(this.删除学生记录ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(425, 644);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息管理系统 v1.0";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tooltime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学生缺勤记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询缺勤记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示并编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除学生记录ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 编辑与修改ToolStripMenuItem;
    }
}