using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv7
{
    public class Square : Object2D
    {
        public double SideLength { get; private set; }
        public Square(double sideLength)
        {
            if (sideLength < 0) throw new Exception("Cannot create object with negative dimensions");
            SideLength = sideLength;
        }
        public override double Area()
        {
            return SideLength * SideLength;
        }
        public override string ToString()
        {
            return String.Format("Square ({0} x {0})", SideLength);
        }
    }
}
