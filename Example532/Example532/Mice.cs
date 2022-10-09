using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example532
{
    internal class Mice : Mammals
    {
        public Mice()
        {
            name = "ネズミ";
        }
        public override void Bark()
        {
            Console.WriteLine("チューチュー");
        }
    }
}
