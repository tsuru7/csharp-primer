﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample504
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sub s1 = new Sub();
            s1.ShowParam();
            Sub s2 = new Sub(100);
            s2.ShowParam();
        }
    }
}
