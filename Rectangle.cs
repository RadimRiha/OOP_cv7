using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv7
{
    public class Rectangle : Object2D
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public Rectangle(double width, double height)
        {
            if (width < 0 || height < 0) throw new Exception("Cannot create object with negative dimensions");
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return String.Format("Rectangle ({0} x {1})", Width, Height);
        }
    }
}
