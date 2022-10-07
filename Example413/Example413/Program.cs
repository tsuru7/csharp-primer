using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example413
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ビンゴの縦・横のサイズを入力: ");
            int size = int.Parse(Console.ReadLine());
            Bingo bingo = new Bingo();
            bingo.Init(size);
            bingo.Show();
        }
    }
}
