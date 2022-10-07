using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example413
{
    internal class Bingo
    {
        public int size = 0;
        public int[,] card;
        public void Init(int size)
        {
            this.size = size;
            this.card = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    card[row, col] = 0;
                }
            }
            Random rnd = new Random();
            int num = 1;
            while (num <= size*size)
            {
                int r = rnd.Next(size * size);
                int row = r / size;
                int col = r % size;
                if (card[row, col] == 0)
                {
                    card[row, col] = num;
                    num++;
                }
            }
        }
        public void Show()
        {
            int keta = 0;
            int n = size*size;
            while (n > 0)
            {
                n /= 10;
                keta++;
            }
            string format = "{0," + keta + ":d}|";
            //Console.WriteLine(format);
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(format, card[row, col]);
                }
                Console.WriteLine();
                for (int col = 0; col < size; col++)
                {
                    for (int i = 0; i < keta+1; i++)
                    {
                        Console.Write("-");

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
