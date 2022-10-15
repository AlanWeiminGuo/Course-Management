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
    public partial class 添加学生缺勤记录 : Form
    {
        public 添加学生缺勤记录()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            缺课类 q = new 缺课类();
            q.leadIn();
            string data = dateTime.Value.ToString("yyyy.MM.dd");
            string num = textnum.Text;
            string name = textname.Text;
            string stdname = textstdname.Text;
            string type = cbxtype.Text;
            System.IO.File.WriteAllText(@"C:\Users\874934555\Desktop\考勤信息.txt", string.Empty);
            int i = q.maxNum;
            q.att[i].absentDate = data;
            q.att[i].classNum = num;
            q.att[i].courseName = name;
            q.att[i].stuName = stdname;
            q.att[i].absentType = type;
            q.maxNum++;
            q.写入();
            this.Close();

        }
    }
}
