using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example412
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("英文を入力してください: ");
            string sentence = Console.ReadLine();
            int count = sentence.Length;
            string lower = sentence.ToLower();
            string upper = sentence.ToUpper();
            Console.WriteLine("文字数: {0}", count);
            Console.WriteLine("大文字: {0}", upper);
            Console.WriteLine("小文字: {0}", lower);
        }
    }
}
