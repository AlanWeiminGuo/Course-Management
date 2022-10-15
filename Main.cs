using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace first_try
{
  
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            tooltime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tooltime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }


        private void 添加学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            添加学生信息 k = new 添加学生信息();
            k.ShowDialog();
        }

        private void 添加学生缺勤记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            添加学生缺勤记录 p = new 添加学生缺勤记录();
            p.ShowDialog();
        }

        private void 查询学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            查询学生信息 t = new 查询学生信息();
            t.ShowDialog();
        }

        private void 查询缺勤记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            查询缺勤记录 o = new 查询缺勤记录();
            o.ShowDialog();
        }

        private void 显示并编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            显示学生信息 p = new 显示学生信息();
            p.ShowDialog();
        }

        private void 删除学生记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            删除学生信息 p = new 删除学生信息();
            p.ShowDialog();
        }

        private void 编辑与修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改学生记录 p = new 修改学生记录();
            p.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("保存成功。");
        }
    }
}
