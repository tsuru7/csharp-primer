using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example533
{
    internal class Car : IDrive, IMecanical
    {
        public void Drive()
        {
            Console.WriteLine("運転する");
        }
        public void Maintain()
        {
            Console.WriteLine("メンテナンスする");
        }
    }
}
