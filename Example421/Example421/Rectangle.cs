using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example421
{
    internal class Rectangle
    {
        private double width = 0.0;
        private double height = 0.0;
        public double GetArea()
        {
            return width * height;
        }
        public double GetPerimeter()
        {
            return (width + height) * 2.0;
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
    }
}
