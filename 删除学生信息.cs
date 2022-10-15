using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace first_try
{
    public partial class 删除学生信息 : Form
    {
        public 删除学生信息()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            学生组 s = new 学生组();
            s.leadIn();
            int t = 0;
            for (int i = 0; i < s.maxNum; i++)
            {
                if (s.stu[i].id == id)
                {
                    t++;
                    for (int j = i; j < s.maxNum-1; j++)
                    {
                        int k = j + 1;
                        s.stu[j].id = s.stu[k].id;
                        s.stu[j].name = s.stu[k].name;
                        s.stu[j].sex = s.stu[k].sex;
                        s.stu[j].age = s.stu[k].age;
                        s.stu[j].classroom = s.stu[k].classroom;
                    }
                }
            }
            if (t == 0)
            {
                MessageBox.Show("记录为空。");
                return;
            }
            s.maxNum--;
            s.写入();
            MessageBox.Show("删除成功。");
            this.Close();
        }
    }
}
