using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example513
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("サイズ: ");
            int size = int.Parse(Console.ReadLine());
            Bingo bingo = new Bingo(size);
            bingo.Show();
        }
    }
}
