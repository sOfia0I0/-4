using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тарасян_из_учебника_гл_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        interface IPerson
        {
            string Name { get; set; }
            int Age { get; set; }
            DateTime BirthDay { get; set; }
            void GetInformation();
        }
        class Student : IPerson
        {
            string name;
            int age;
            DateTime birth;
            public Student(string name, int age, DateTime birth)
            {
                Name = name;
             Age = age;
                BirthDay = birth;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Age
            {
                get { return age; }
                set { age = value; }
            }
            public DateTime BirthDay
            {
                get { return birth; }
                set { birth = value; }
            }
            public void GetInformation()
            { 
             MessageBox.Show("Имя: "+ Name + " Возраст: " + Age + " Дата рождения: " + BirthDay.Date);
             MessageBox.Show("Родился в " + BirthDay.DayOfWeek); 
            }
        }
    private void button1_Click(object sender, EventArgs e)
        {
            Student new_student;
            int age;
            age = Convert.ToInt32(DateTime.Now.Year -
            dateTimePicker1.Value.Year);
            new_student = new Student(textBox1.Text, age,
            dateTimePicker1.Value);
            new_student.GetInformation();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
