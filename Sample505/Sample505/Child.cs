﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample505
{
    internal class Child : Parent
    {
        public override void Foo()
        {
            Console.WriteLine("子クラスのFooメソッド");

        }
    }
}
