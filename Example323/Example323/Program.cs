using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example323
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rnd.Next(1, 101);
                Console.Write("{0} ", num[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = num.Length-1; j > i; j--)
                {
                    if (num[j-1] < num[j])
                    {
                        int tmp = num[j - 1];
                        num[j - 1] = num[j];
                        num[j] = tmp;
                    }
                }
            }
            foreach (int i in num)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
