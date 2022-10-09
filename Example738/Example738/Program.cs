using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example738
{
    internal class Program
    {
        static Boolean isPrime(int n)
        {
            Boolean ans = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    ans = false;
                    break;
                }
            }
            return ans;
        }
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                if (isPrime(i))
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
