﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample508
{
    internal class Crow : Bird
    {
        public Crow() : base("カラス")
        {

        }
        public override void Sing()
        {
            Console.WriteLine("カーカー");

        }
    }
}
