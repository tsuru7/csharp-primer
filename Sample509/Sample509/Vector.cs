using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample509
{
    internal class Vector : VectorBase
    {
        private double x = 0.0;
        private double y = 0.0;
        public override double X
        {
            get { return x; }
            set { x = value; }
        }
        public override double Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
