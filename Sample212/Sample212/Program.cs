using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("さいころの目(1-6): ");
            int dice = int.Parse(Console.ReadLine());
            switch (dice)
            {
                case 1:
                case 3:
                case 5:
                    Console.WriteLine("半");
                    break;
                case 2:
                case 4:
                case 6:
                    Console.WriteLine("丁");
                    break;
                default:
                    Console.WriteLine("不適切な値です");
                    break;
            }
        }
    }
}
