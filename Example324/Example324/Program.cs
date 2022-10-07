using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rnd.Next(1, 100);
                Console.Write("{0} ", num[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}以上{1}未満: ", i*10, (i + 1) * 10);
                foreach (int j in num)
                {
                    if (i*10 <= j && j < (i+1)*10)
                    {
                        Console.Write("{0} ", j);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
