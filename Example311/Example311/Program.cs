﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example311
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("★の数を入力: ");
            int star = int.Parse(Console.ReadLine());
            for (int i = 0; i < star; i++)
            {
                Console.Write("★");
            }
            Console.WriteLine();
        }
    }
}
