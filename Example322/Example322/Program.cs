using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] r = new int[10];
            for (int i = 0; i < 10; i++)
            {
                r[i] = rnd.Next(1, 101);
                Console.Write("{0} ", r[i]);
            }
            Console.WriteLine();
            Console.Write("偶数: ");
            foreach (int i in r)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
            Console.Write("奇数: ");
            foreach (int i in r)
            {
                if (i % 2 == 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
