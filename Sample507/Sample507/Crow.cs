using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample507
{
    internal class Crow
    {
        private string name = "カラス";
        public void Sing()
        {
            Console.WriteLine("カーカー");
        }
        public string Name
        {
            get { return name; }
        }
    }
}
