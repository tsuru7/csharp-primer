using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample606
{
    internal class Program
    {
        delegate void Action(int a);
        static void Function1(int a)
        {
            Console.WriteLine("a={0}", a);
        }
        static void Function2(int a)
        {
            Console.WriteLine("a*2={0}", a * 2);
        }
        static void Function3(int a)
        {
            Console.WriteLine("a*3={0}", a * 3);
        }
        static void Main(string[] args)
        {
            Action a = new Action(Function1);
            a += new Action(Function2);
            a += new Action(Function3);
            a(3);
        }
    }
}
