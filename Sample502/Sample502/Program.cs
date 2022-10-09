using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sample502
{
    internal class Program
    {
        private static int snum = 100;
        public int inum = 200;
        public static void Foo()
        {
            Console.WriteLine("Fooメソッド(staticメソッド)");
        }
        public void Bar()
        {
            Console.WriteLine("Barメソッド(インスタンスメソッド)");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("pのインスタンスフィールド: inum={0}", p.inum);
            Console.WriteLine("Programのクラスフィールド: snum={0}", snum);
            Foo();
            p.Bar();

        }
    }
}
