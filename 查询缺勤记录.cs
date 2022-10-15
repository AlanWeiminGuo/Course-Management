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
    public partial class 查询缺勤记录 : Form
    {
        public 查询缺勤记录()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            缺课类 s = new 缺课类();
            s.leadIn();
            dataGridView1.Rows.Clear();
            int m = 0;
            if (comboBox1.Text == "学生姓名")
            {
                s.pp();
                for (int i = 0; i < s.maxNum; i++)
                {
                    if (s.att[i].stuName == textBox1.Text)
                    {
                        int index = this.dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells[0].Value = s.att[i].absentDate;
                        dataGridView1.Rows[index].Cells[1].Value = s.att[i].classNum;
                        dataGridView1.Rows[index].Cells[2].Value = s.att[i].courseName;
                        dataGridView1.Rows[index].Cells[3].Value = s.att[i].stuName;
                        dataGridView1.Rows[index].Cells[4].Value = s.att[i].absentType;
                        m++;
                    }
                }
                if (m == 0)
                {
                    MessageBox.Show("未找到该学生缺勤记录。");
                }
            }
            if (comboBox1.Text == "课程名称")
            {
                s.pp();
                for (int i = 0; i < s.maxNum; i++)
                {
                    if (s.att[i].courseName == textBox1.Text)
                    {
                        int index = this.dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells[0].Value = s.att[i].absentDate;
                        dataGridView1.Rows[index].Cells[1].Value = s.att[i].classNum;
                        dataGridView1.Rows[index].Cells[2].Value = s.att[i].courseName;
                        dataGridView1.Rows[index].Cells[3].Value = s.att[i].stuName;
                        dataGridView1.Rows[index].Cells[4].Value = s.att[i].absentType;
                        m++;
                    }
                }
                if (m == 0)
                {
                    MessageBox.Show("未找到该课程缺勤记录。");
                }
            }
        }
    }
}
