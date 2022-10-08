using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample405
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person2 p = new Person2();
            p.SetAgeAndName("山田太郎", 19);
            p.Age = 32;
            //p.Name = "佐藤花子";
            Console.WriteLine("名前: {0} 年齢: {1}", p.Name, p.Age);
        }
    }
}
