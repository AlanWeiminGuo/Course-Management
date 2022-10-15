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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void textname_Leave(object sender, EventArgs e)
        {
            //用户名检测，是否重复
        }

        private void textname_TextChanged(object sender, EventArgs e)
        {
            if (textname.Text.Length > 6)
            {
                MessageBox.Show("用户名最大长度为6！");
                textname.Text = textname.Text.Substring(0, 6);
            }
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            //string uname = textname.Text.Trim();//去掉空格(中间的空格不去掉，只去掉两边的)
            //string pass = textpass.Text.Trim();
            //string pass1 = textpass1.Text.Trim();

            string uname = textname.Text.Replace(" ","");//去掉所有空格
            string pass = textpass.Text.Replace(" ", "");
            string pass1 = textpass1.Text.Replace(" ", "");

            if (string.IsNullOrEmpty(uname) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(pass1))
            {
                MessageBox.Show("请将内容填写完整！");
                return;
            }

            if (pass != pass1)
            {
                MessageBox.Show("两次密码输入不一致,请重新输入。");
                textpass.Text = "";
                textpass1.Text = "";
                return;
            }
            //数据写入数据库
        }
    }
}
