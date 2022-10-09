using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example733
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i=n; i >= 0; i--)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
