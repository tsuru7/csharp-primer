using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example714
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Depth: ");
            double depth = double.Parse(Console.ReadLine());
            Console.WriteLine("volume: {0}", width * height * depth);
        }
    }
}
