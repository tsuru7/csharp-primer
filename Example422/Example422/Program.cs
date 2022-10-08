using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example422
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列を入力してください: ");
            string s = Console.ReadLine();
            Console.WriteLine("文字列の長さ: {0}", s.Length);
        }
    }
}
