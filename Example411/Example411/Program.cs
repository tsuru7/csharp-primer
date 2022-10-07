using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example411
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("幅(cm): ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("高さ(cm): ");
            double height = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle();
            rectangle.width = width;
            rectangle.height = height;
            double area = rectangle.GetArea();
            double perimater = rectangle.GetPerimeter();
            Console.WriteLine("面積: {0} cm2", area);
            Console.WriteLine("周の長さ: {0} cm", perimater);
        }
    }
}
