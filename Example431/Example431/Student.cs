using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example431
{
    internal class Student
    {
        private string name;
        private int grade;
        private int age;
        public Student(): this("", 0, 0)
        {

        }
        public Student(string name, int grade, int age)
        {
            this.name = name;
            this.grade = grade;
            this.age = age;
        }

        public void SetInformation(string name, int grade, int age)
        {
            this.name = name;
            this.grade = grade;
            this.age = age;
        }
        public void ShowInformation()
        {
            Console.WriteLine("名前: {0}, 学年: {1}, 年齢: {2}", name, grade, age);
        }
    }
}
