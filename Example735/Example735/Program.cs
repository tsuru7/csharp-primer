using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example735
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] nums = new int[5];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(1, 101);
                Console.Write("{0} ", nums[i]);
            }
            Console.WriteLine();
            Console.WriteLine("最大値: {0}, 最小値: {1}", nums.Max(), nums.Min());
        }
    }
}
