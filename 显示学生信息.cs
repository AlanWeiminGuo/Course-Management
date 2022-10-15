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
    public partial class 显示学生信息 : Form
    {
        public 显示学生信息()
        {
            InitializeComponent();
        }

        private void 显示学生信息_Load(object sender, EventArgs e)
        {

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
            缺课类 s = new 缺课类();
            s.leadIn();
            dataGridView2.Rows.Clear();
            for (int i = 0; i < s.maxNum; i++)
            {
                int index = this.dataGridView2.Rows.Add();
                dataGridView2.Rows[index].Cells[0].Value = s.att[i].absentDate;
                dataGridView2.Rows[index].Cells[1].Value = s.att[i].classNum;
                dataGridView2.Rows[index].Cells[2].Value = s.att[i].courseName;
                dataGridView2.Rows[index].Cells[3].Value = s.att[i].stuName;
                dataGridView2.Rows[index].Cells[4].Value = s.att[i].absentType;
            }
        }
    }
}
