using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmaple223
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("水の温度: ");
            double temp = double.Parse(Console.ReadLine());
            string state = "";
            if (temp <= 0)
            {
                state = "固体";
            }
            else if (temp < 100)
            {
                state = "液体";
            }
            else 
            {
                state = "気体";
            }
            Console.WriteLine(state);
        }
    }
}
