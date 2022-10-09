using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example611
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            int i;
            Console.Write("正の整数を入力: ");
            i = int.Parse(Console.ReadLine());
            while (i > 0)
            {
                l.Add(i);
                Console.Write("正の整数を入力: ");
                i = int.Parse(Console.ReadLine());
            }
            int sum = l.Sum();
            //double avg = (double)sum / l.Count;
            double avg = l.Average();
            int max = l.Max();
            int min = l.Min();
            Console.WriteLine("合計値: {0}", sum);
            Console.WriteLine("平均値: {0}", avg);
            Console.WriteLine("最大値: {0}", max);
            Console.WriteLine("最小値: {0}", min);

        }
    }
}
