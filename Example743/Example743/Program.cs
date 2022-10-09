using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example743
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ss = new string[5];
            for (int i= 0; i<ss.Length; i++)
            {
                Console.Write("input({0}): ", i);
                ss[i] = Console.ReadLine();
            }
            foreach (string s in ss)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

        }
    }
}
