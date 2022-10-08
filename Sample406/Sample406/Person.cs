﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample406
{
    internal class Person
    {
        private string name = "";
        private int age = 0;
        public Person() : this("名無し", 0)
        {
            Console.WriteLine("引数なしコンストラクタ");
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("引数ありコンストラクタ name: {0}, age: {1}", name, age);
        }   

        public void ShowAgeAndName()
        {
            Console.WriteLine("名前: {0}, 年齢: {1}", name, Age);
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
    }
}
