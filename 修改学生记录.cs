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
    public partial class 修改学生记录 : Form
    {
        public 修改学生记录()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            学生组 s = new 学生组();
            s.leadIn();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < s.maxNum; i++)
            {
                int index = this.dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = s.stu[i].id;
                dataGridView1.Rows[index].Cells[1].Value = s.stu[i].name;
                dataGridView1.Rows[index].Cells[2].Value = s.stu[i].sex;
                dataGridView1.Rows[index].Cells[3].Value = s.stu[i].age;
                dataGridView1.Rows[index].Cells[4].Value = s.stu[i].classroom;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textid.Text;
            string name = textname.Text;
            string sex = cbxsex.Text;
            string age = textage.Text;
            string classroom = textclassroom.Text;
            学生组 s = new 学生组();
            s.leadIn();
            int m = 0;
            int k = 0;
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(sex) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(classroom))
            {
                MessageBox.Show("请将内容填写完整！");
                return;
            }
            for (int i = 0; i < s.maxNum; i++)
            {
                if (s.stu[i].id == textBox1.Text)
                {
                    s.stu[i].id = id;
                    for (int o = 0; o < s.maxNum; o++)
                    {
                        if (s.stu[o].id == s.stu[i].id&&s.stu[o].id!=textBox1.Text)
                        {
                            k++;
                        }

                    }
                    if (k > 1)
                    {
                        MessageBox.Show("学生学号冲突！学号修改失败。");
                        s.stu[i].id = textBox1.Text;
                        return;
                    }
                    s.stu[i].name = name;
                    s.stu[i].sex = sex;
                    s.stu[i].age = age;
                    s.stu[i].classroom = classroom;
                    s.写入();
                    m++;
                }
            }
            if (m == 0)
            {
                MessageBox.Show("写入失败！");
            }
            this.Close();
        }
    }
}
