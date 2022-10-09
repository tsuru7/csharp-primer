using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example723
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your point: ");
            int p = int.Parse(Console.ReadLine());
            if (0 <= p && p < 60)
            {
                Console.WriteLine("You are not passed");
            }
            else if (60 <= p && p < 70)
            {
                Console.WriteLine("You are passed.");
            }
            else if (70 <= p && p < 80)
            {
                Console.WriteLine("You are good.");
            }
            else if (80 <= p && p <= 100)
            {
                Console.WriteLine("You are excelent.");
            }
            else
            {
                Console.WriteLine("Invalid point");
            }

        }
    }
}
