﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample305
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double one, two, three;
            double sum, avg;
            one = 1.2;
            two = 3.7;
            three = 4.1;
            Console.WriteLine(one + " " + two + " " + three);
            sum = one + two + three;
            avg = sum / 3.0;
            Console.WriteLine("合計値: " + sum);
            Console.WriteLine("平均値: " + avg);
        }
    }
}
