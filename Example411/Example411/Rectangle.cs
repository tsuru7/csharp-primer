using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example411
{
    internal class Rectangle
    {
        public double width = 0.0;
        public double height = 0.0;
        public double GetArea()
        {
            return width * height;
        }
        public double GetPerimeter()
        {
            return (width + height) * 2.0;
        }
    }
}
