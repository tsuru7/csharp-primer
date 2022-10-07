using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int max_r = 0;
            int min_r = 101;
            for (int i = 0; i < 10; i++)
            {
                int r = rnd.Next(1, 101);
                Console.Write(r + " ");
                if (r > max_r)
                {
                    max_r = r;
                }
                if (r < min_r)
                {
                    min_r = r;
                }

            }
            Console.WriteLine();
            Console.WriteLine("最大値: {0}, 最小値: {1}", max_r, min_r);
        }
    }
}
