using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample404
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Access a = new Access();
            //a.Data1 = 1;
            a.ShowDatas();
            Console.WriteLine("a.data1={0}", a.Data1);
            //Console.WriteLine("a.data2={1}", a.Data2);

        }
    }
}
