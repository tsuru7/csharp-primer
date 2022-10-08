using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example421
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("幅(cm): ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("高さ(cm): ");
            double height = double.Parse(Console.ReadLine());
            Rectangle r = new Rectangle();
            r.Width = width;
            r.Height = height;
            Console.WriteLine("面積: {0}", r.GetArea());
            Console.WriteLine("周の長さ: {0}", r.GetPerimeter());
        }
    }
}
