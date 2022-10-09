using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example713
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());
            double sum = a + b + c;
            double avg = sum / 3.0;
            Console.WriteLine("合計値: {0}, 平均値: {1}", sum, avg);
        }
    }
}
