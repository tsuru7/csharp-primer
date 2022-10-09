using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example736
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("input string: ");
                string s = Console.ReadLine();
                if (s == "")
                {
                    break;
                }
                Console.WriteLine(s);
            }
        }
    }
}
