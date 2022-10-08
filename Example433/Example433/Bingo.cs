using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example433
{
    internal class Bingo
    {
        private int[,] data;
        private int size;
        public Bingo(): this(5)
        {

        }
        public Bingo(int size)
        {
            Init(size);
        }
        public void Init(int size)
        {
            this.size = size;
            data = new int[size, size];
            Clear();
            Shuffle();
        }
        public void Show()
        {
            int keta = 0;
            int x = size * size;
            while (x > 0)
            {
                keta++;
                x /= 10;
            }
            string format = "{0," + keta + ":d}|";
            //Console.WriteLine(format);
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(format, data[row, col]);
                }
                Console.WriteLine();
                for (int col = 0; col < size; col++)
                {
                    for (int k = 0; k < keta + 1; k++)
                    {
                        Console.Write("-");

                    }
                }
                Console.WriteLine();
            }

        }
        private void Clear()
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    data[row, col] = 0;
                }
            }
        }
        private void Shuffle()
        {
            Random rnd = new Random();
            int num = 1;
            while (num <= size * size)
            {
                int r = rnd.Next(size * size);
                int row = r / size;
                int col = r % size;
                if (data[row, col] == 0)
                {
                    data[row, col] = num;
                    num++;
                }
            }
        }
    }
}
