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
    public partial class 添加学生信息 : Form
    {
        public 添加学生信息()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textid.Text;
            string name = textname.Text;
            string sex = cbxsex.Text;
            string age = textage.Text;
            string classroom = textclassroom.Text;
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(sex) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(classroom))
            {
                MessageBox.Show("请将内容填写完整！");
                return;
            }
            学生组 s = new 学生组();
            s.leadIn();
            int m = 0;
            for (int k = 0; k < s.maxNum; k++)
            {
                if (s.stu[k].id == id)
                {
                    MessageBox.Show("学号要求唯一，请重新填写。");
                    textid.Text = "";
                    m++;
                }

            }
            if (m == 0)
            {

                System.IO.File.WriteAllText(@"C:\Users\874934555\Desktop\1.txt", string.Empty);
                int i = s.maxNum;
                s.stu[i].id = id;
                s.stu[i].name = name;
                s.stu[i].sex = sex;
                s.stu[i].age = age;
                s.stu[i].classroom = classroom;
                s.max();
                s.写入();
                this.Close();
            }
        }

        private void 添加学生信息_Load(object sender, EventArgs e)
        {

        }
    }
}
