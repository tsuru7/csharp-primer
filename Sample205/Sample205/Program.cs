using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            double d1, d2;
            Console.Write("str1=");
            str1 = Console.ReadLine();
            d1 = double.Parse(str1);
            Console.Write("str2=");
            str2 = Console.ReadLine();
            d2 = double.Parse(str2);
            Console.WriteLine("str1 + str2 = {0}", str1 + str2);
            Console.WriteLine("d1 + d2 = {0}", d1 + d2);
        }
    }
}
