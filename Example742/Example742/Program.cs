﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example742
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] d = new double[] { 0.01, -2.1, 3.7, 0.4 };
            for (int i = 0; i < d.Length; i++)
            {
                Console.Write("d[{0}]={1} ", i, d[i]);
            }
            Console.WriteLine();
        }
    }
}
