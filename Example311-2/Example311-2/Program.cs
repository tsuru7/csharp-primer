using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example311_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("★の数を入力: ");
            int star = int.Parse(Console.ReadLine());
            while (star > 0)
            {
                Console.Write("★");
                star--;
            }
            Console.WriteLine();
        }
    }
}
