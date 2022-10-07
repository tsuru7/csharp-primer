using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example313
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r = rnd.Next(1, 11);
            int count = 0;
            while (count < 3)
            {
                Console.Write("数を入力してください: ");
                int ans = int.Parse(Console.ReadLine());
                if (ans == r)
                {
                    Console.WriteLine("正解！");
                    break;
                }
                else if (ans < r)
                {
                    Console.WriteLine("小さすぎます");
                }
                else
                {
                    Console.WriteLine("大きすぎます");
                }
                count++;
            }
            if (count == 3)
            {
                Console.WriteLine("ゲームオーバー");
            }
        }
    }
}
