﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample210
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("さいころの目(1-6): ");
            int dice = int.Parse(Console.ReadLine());
            if (1 <= dice && dice <= 6)
            {
                if (dice == 2 || dice == 4 || dice == 6)
                {
                    Console.WriteLine("丁");
                }
                else
                {
                    Console.WriteLine("半");
                }
            }
            else
            {
                Console.WriteLine("範囲外の値です");
            }
        }
    }
}
