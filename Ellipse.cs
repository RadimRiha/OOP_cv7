using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv7
{
    public class Ellipse : Object2D
    {
        public double RadiusA { get; private set; }
        public double RadiusB { get; private set; }
        public Ellipse(double radiusA, double radiusB)
        {
            if (radiusA < 0 || radiusB < 0) throw new Exception("Cannot create object with negative dimensions");
            RadiusA = radiusA;
            RadiusB = radiusB;
        }
        public override double Area()
        {
            return Math.PI * RadiusA * RadiusB;
        }
        public override string ToString()
        {
            return String.Format("Ellipse (ra = {0}, rb = {1})", RadiusA, RadiusB);
        }
    }
}
