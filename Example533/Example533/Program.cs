using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example533
{
    internal class Program
    {
        static void DriveACar(IDrive car)
        {
            car.Drive();
        }
        static void MaintainACar(IMecanical car)
        {
            car.Maintain();
        }
        static void Main(string[] args)
        {
            Car car = new Car();
            DriveACar(car);
            MaintainACar(car);
        }
    }
}
