using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example734
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input number: ");
            int n = int.Parse(Console.ReadLine());
            foreach (int b in new int[]{ 2, 3, 5})
            {
                Console.WriteLine("{0}の倍数", b);
                int i = b;
                while (i <= n)
                {
                    Console.Write("{0} ", i);
                    i += b;
                }
                Console.WriteLine();
            }
        }
    }
}
