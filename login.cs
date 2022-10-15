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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            string uname = textusername.Text.Replace(" ", "");//去掉所有空格
            string pass = textpass.Text.Replace(" ", "");
            教师组 s = new 教师组();
            s.leadIn();
            int i = 0;
            if (string.IsNullOrEmpty(uname) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("请将内容填写完整！");
                return;
            }

            for ( i = 0; i < s.maxNum; i++)
            {
                if (uname == s.tea[i].name && pass == s.tea[i].Id)
                {
                    Main fm = new Main();
                    fm.ShowDialog();
                    this.Close();
                }
            }
            if (i == s.maxNum)
            {
                MessageBox.Show("用户名或密码填写错误。");
                return;
            }
        }
    }
}
