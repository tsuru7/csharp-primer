using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample407
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] a = new string[10000];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new string('M', 10000);
            }
            Console.WriteLine("メモリ使用量(GC発動前): {0}", GC.GetTotalMemory(false));
            a = null;
            Console.WriteLine("メモリ使用量(参照解放後): {0}", GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine("メモリ使用量(GC発動後): {0}", GC.GetTotalMemory(false));

        }
    }
}
