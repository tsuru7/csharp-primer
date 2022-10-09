using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example744
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] month = new string[] { "January", "Febrary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Console.Write("月(1-12)を入力してください: ");
            int m = int.Parse(Console.ReadLine());
            if (1 <= m && m <= 12)
            {
                Console.WriteLine("{0}月の英語は{1}です。", m, month[m - 1]);
            }
            else
            {
                Console.WriteLine("適切な値を入力してください");
            }
        }
    }
}
