using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example731
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i=0; i < n; i++)
            {
                Console.WriteLine("Hello, C#!");
            }
        }
    }
}
