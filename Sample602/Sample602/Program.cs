using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample602
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> a = new List<string>();
            a.Add("Taro");
            a.Add("Hanako");
            a.Add("Jiro");
            a.Add("Kaoru");
            a.Remove("Taro");
            a.RemoveAt(1);
            foreach (string s in a)
            {
                Console.WriteLine(s);
            }
        }
    }
}
