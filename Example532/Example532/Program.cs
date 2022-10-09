using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example532
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Mice mice = new Mice();
            cat.Bark();
            cat.ShowName();
            mice.Bark();
            mice.ShowName();
        }
    }
}
