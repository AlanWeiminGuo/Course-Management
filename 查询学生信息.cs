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
    public partial class 查询学生信息 : Form
    {
        public 查询学生信息()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            学生组 s = new 学生组();
            s.leadIn();
            string k = comboBox1.Text;
            string n = textBox1.Text;
            if (k == "学号")
            {
                dataGridView1.Rows.Clear();
                int i = 0;
                int t = 0;
                for (i = 0; i < s.maxNum; i++)
                {
                    if (n == s.stu[i].id)
                    {
                        int index = this.dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells[0].Value = s.stu[i].id;
                        dataGridView1.Rows[index].Cells[1].Value = s.stu[i].name;
                        dataGridView1.Rows[index].Cells[2].Value = s.stu[i].sex;
                        dataGridView1.Rows[index].Cells[3].Value = s.stu[i].age;
                        dataGridView1.Rows[index].Cells[4].Value = s.stu[i].classroom;
                        t++;
                    }
                }
                if (t == 0)
                {
                    MessageBox.Show("未找到该学生的信息。");
                }
            }
            if (k == "姓名")
            {
                dataGridView1.Rows.Clear();
                int i = 0;
                int t = 0;
                for (i = 0; i < s.maxNum; i++)
                {
                    if (n == s.stu[i].name)
                    {
                        int index = this.dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells[0].Value = s.stu[i].id;
                        dataGridView1.Rows[index].Cells[1].Value = s.stu[i].name;
                        dataGridView1.Rows[index].Cells[2].Value = s.stu[i].sex;
                        dataGridView1.Rows[index].Cells[3].Value = s.stu[i].age;
                        dataGridView1.Rows[index].Cells[4].Value = s.stu[i].classroom;
                        t++;
                    }
                }
                if (t == 0)
                {
                    MessageBox.Show("未找到该学生的信息。");
                }
            }
            if (k == "性别")
            {
                dataGridView1.Rows.Clear();
                int i = 0;
                int t = 0;
                for (i = 0; i < s.maxNum; i++)
                {
                    if (n == s.stu[i].sex)
                    {
                        int index = this.dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells[0].Value = s.stu[i].id;
                        dataGridView1.Rows[index].Cells[1].Value = s.stu[i].name;
                        dataGridView1.Rows[index].Cells[2].Value = s.stu[i].sex;
                        dataGridView1.Rows[index].Cells[3].Value = s.stu[i].age;
                        dataGridView1.Rows[index].Cells[4].Value = s.stu[i].classroom;
                        t++;
                    }
                }
                if (t == 0)
                {
                    MessageBox.Show("未找到学生的信息。");
                }
            }
            if (k == "年龄")
            {
                dataGridView1.Rows.Clear();
                int i = 0;
                int t = 0;
                for (i = 0; i < s.maxNum; i++)
                {
                    if (n == s.stu[i].age)
                    {
                        int index = this.dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells[0].Value = s.stu[i].id;
                        dataGridView1.Rows[index].Cells[1].Value = s.stu[i].name;
                        dataGridView1.Rows[index].Cells[2].Value = s.stu[i].sex;
                        dataGridView1.Rows[index].Cells[3].Value = s.stu[i].age;
                        dataGridView1.Rows[index].Cells[4].Value = s.stu[i].classroom;
                        t++;
                    }
                }
                if (t == 0)
                {
                    MessageBox.Show("未找到学生的信息。");
                }
            }
            if (k == "班级")
            {
                dataGridView1.Rows.Clear();
                int i = 0;
                int t = 0;
                for (i = 0; i < s.maxNum; i++)
                {
                    if (n == s.stu[i].classroom)
                    {
                        int index = this.dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells[0].Value = s.stu[i].id;
                        dataGridView1.Rows[index].Cells[1].Value = s.stu[i].name;
                        dataGridView1.Rows[index].Cells[2].Value = s.stu[i].sex;
                        dataGridView1.Rows[index].Cells[3].Value = s.stu[i].age;
                        dataGridView1.Rows[index].Cells[4].Value = s.stu[i].classroom;
                        t++;
                    }
                }
                if (t == 0)
                {
                    MessageBox.Show("未找到学生的信息。");
                }
            }
        }
    }
}
