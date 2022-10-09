using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example512
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("角度を入力: ");
            double ang = double.Parse(Console.ReadLine());
            double rad = ang / 180.0 * Math.PI;
            Console.WriteLine("sin{0}°= {1}", ang, Math.Sin(rad));
            Console.WriteLine("cos{0}°= {1}", ang, Math.Cos(rad));
            Console.WriteLine("tan{0}°= {1}", ang, Math.Tan(rad));
        }
    }
}
