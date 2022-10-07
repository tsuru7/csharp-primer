using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example325
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] num = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    num[i, j] = 0;
                }
            }
            int count = 0;
            while (count < 25)
            {
                int r = rnd.Next(25);
                int row = r / 5;
                int col = r % 5;
                if (num[row, col] == 0)
                {
                    num[row, col] = count+1;
                    count++;
                }
            }
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write("{0, 2:d}|", num[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
