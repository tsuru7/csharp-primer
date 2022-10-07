using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example321
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write("数値を入力してください: ");
                n[i] = int.Parse(Console.ReadLine());
                if (n[i] < min)
                {
                    min = n[i];
                }
                if (n[i] > max)
                {
                    max = n[i];
                }
            }
            foreach (int i in n)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("最大値: {0}, 最小値: {1}", max, min);
        }
    }
}
