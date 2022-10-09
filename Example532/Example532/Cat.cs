using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example532
{
   
    internal class Cat : Mammals
    {
        public Cat()
        {
            name = "猫";
        }
        public override void Bark()
        {
            Console.WriteLine("ニャーニャー");
        }
    }
}
