using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace first_try
{
    struct 教师
    {
        public string Id;
        public string name;
        public string professional;
    }
    class 教师组
    {
        public 教师[] tea = new 教师[10];
        public int maxNum;
        public 教师组()
        {
            leadIn();
        }
        public void leadIn()
        {
            int i = 0;
            int j = 0;
            maxNum = 5;
            string[] context = File.ReadAllLines(@"C:\Users\874934555\Desktop\teacher.txt");
            教师[] teacher = new 教师[10];
            for (i = 0; i < maxNum; i++)
            {
                teacher[i].Id = context[j];
                j++;
                teacher[i].name = context[j];
                j++;
                teacher[i].professional = context[j];
                j++;
            }
            for (i = 0; i < maxNum; i++)
            {
                tea[i] = teacher[i];
            }
        }
    }
    struct 学生
    {
        public string id;
        public string name;
        public string sex;
        public string age;
        public string classroom;

    }
    class 学生组
    {
        public 学生[] stu = new 学生[10];
        public int maxNum = 8;
        public void max()
        {
            maxNum++;
        }
        public 学生组()
        {
            leadIn();
        }
        public void 写入()
        {
            string[] context = new string[100];
            int i = 0;
            int j = 0;
            for (i = 0; i < maxNum; i++)
            {
                context[j] = stu[i].id;
                j++;
                context[j] = stu[i].name;
                j++;
                context[j] = stu[i].sex;
                j++;
                context[j] = stu[i].age;
                j++;
                context[j] = stu[i].classroom;
                j++;
            }
            context[j] = "#";
            System.IO.File.WriteAllLines(@"C:\Users\874934555\Desktop\1.txt", context);
        }

        public void leadIn()
        {
            int i = 0;
            int j = 0;
            string[] context = File.ReadAllLines(@"C:\Users\874934555\Desktop\1.txt");
            学生[] student = new 学生[10];
            for (i = 0; context[j] != "#"; i++)
            {
                student[i].id = context[j];
                j++;
                student[i].name = context[j];
                j++;
                student[i].sex = context[j];
                j++;
                student[i].age = context[j];
                j++;
                student[i].classroom = context[j];
                j++;
            }
            maxNum = j / 5;
            for (i = 0; i < maxNum; i++)
            {
                stu[i] = student[i];
            }
        }
        public void pp()
        {
            string[] content = new string[10];
            for (int i = 0; i < maxNum; i++)
            {
                for (int j = i; j < maxNum; j++)
                {
                    long A = long.Parse(stu[i].id);
                    long B = long.Parse(stu[j].id);
                    if (B < A)
                    {
                        content[0] = stu[i].id;
                        content[1] = stu[i].name;
                        content[2] = stu[i].sex;
                        content[3] = stu[i].age;
                        content[4] = stu[i].classroom;
                        stu[i] = stu[j];
                        stu[j].id = content[0];
                        stu[j].name = content[1];
                        stu[j].sex = content[2];
                        stu[j].age = content[3];
                        stu[j].classroom = content[4];
                    }
                }
            }
        }
    }

    struct 考勤
    {
        public string absentDate;
        public string classNum;
        public string courseName;
        public string stuName;
        public string absentType;
    }
    class 缺课类
    {
        public 考勤[] att = new 考勤[15];
        public int maxNum = 1;
        public 缺课类()
        {
            leadIn();
        }
        public void 写入()
        {
            string[] context = new string[100];
            int i = 0;
            int j = 0;
            for (i = 0; i < maxNum; i++)
            {
                context[j] = att[i].absentDate;
                j++;
                context[j] = att[i].classNum;
                j++;
                context[j] = att[i].courseName;
                j++;
                context[j] = att[i].stuName;
                j++;
                context[j] = att[i].absentType;
                j++;
            }
            context[j] = "#";
            System.IO.File.WriteAllLines(@"C:\Users\874934555\Desktop\考勤信息.txt", context);
        }
        public void leadIn()
        {
            int i = 0;
            int j = 0;
            string[] context = File.ReadAllLines(@"C:\Users\874934555\Desktop\考勤信息.txt");
            考勤[] attention = new 考勤[10];
            for (i = 0; context[j] != "#"; i++)
            {
                attention[i].absentDate = context[j];
                j++;
                attention[i].classNum = context[j];
                j++;
                attention[i].courseName = context[j];
                j++;
                attention[i].stuName = context[j];
                j++;
                attention[i].absentType = context[j];
                j++;
            }
            maxNum = j / 5;
            for (i = 0; i < maxNum; i++)
            {
                att[i] = attention[i];
            }
        }
        public void pp()
        {
            string[] content = new string[10];
            for (int i = 0; i < maxNum; i++)
            {
                for (int j = i; j < maxNum; j++)
                {
                    string t = att[i].absentDate.Replace(".", "");
                    string k = att[j].absentDate.Replace(".", "");
                    long A = long.Parse(t);
                    long B = long.Parse(k);
                    if (B < A)
                    {
                        content[0] = att[i].absentDate;
                        content[1] = att[i].classNum;
                        content[2] = att[i].courseName;
                        content[3] = att[i].stuName;
                        content[4] = att[i].absentType;
                        att[i] = att[j];
                        att[j].absentDate = content[0];
                        att[j].classNum = content[1];
                        att[j].courseName = content[2];
                        att[j].stuName = content[3];
                        att[j].absentType = content[4];
                    }
                }
            }
        }
    }



    class Program
    {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
            //Application.Run(new Main());
            //Main fm = new Main();
           // fm.ShowDialog();
        }
    }
}
 

