using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example737
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 8;
            string[] blocks = { "■", "□" };
            for (int row = 0; row < SIZE; row++)
            {
                for (int col = 0; col < SIZE; col++)
                {
                    Console.Write(blocks[(row + col) % 2]);
                }
                Console.WriteLine();
            }
        }
    }
}
