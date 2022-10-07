using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} + {1} = {2}", 5, 2, 5 + 2);
            Console.WriteLine("{0} - {1} = {2}", 5, 2, 5 - 2);
            Console.WriteLine("{0} * {1} = {2}", 5, 2, 5 * 2);
            Console.WriteLine("{0} / {1} = {2} あまり {3}", 5, 2, 5 / 2, 5 % 2);
        }
    }
}
