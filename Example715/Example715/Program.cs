using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example715
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Last name: ");
            string name = Console.ReadLine();
            Console.Write("Family name: ");
            string family = Console.ReadLine();
            Console.WriteLine("{0} {1}", family, name);
        }
    }
}
