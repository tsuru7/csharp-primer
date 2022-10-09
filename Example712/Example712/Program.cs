using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example712
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("円の半径: ");
            double r = double.Parse(Console.ReadLine());
            double area = r * r * 3.14;
            double dist = 2.0 * 3.14 * r;
            Console.WriteLine("円の面積: {0}", area);
            Console.WriteLine("円周: {0}", dist);
        }
    }
}
