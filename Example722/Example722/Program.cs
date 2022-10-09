using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example722
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input integer number: ");
            int i = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                Console.WriteLine("This is 0.");
            }
            else
            {
                Console.WriteLine("This is not 0.");
            }
        }
    }
}
