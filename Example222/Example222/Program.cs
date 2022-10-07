using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string HELLO = "Hello";
            Console.Write("Helloと入力してください: ");
            string h = Console.ReadLine();
            if (h.Equals(HELLO, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(HELLO + "が入力されました");
            }
            else
            {
                Console.WriteLine(HELLO + "と入力してください");
            }
        }
    }
}
