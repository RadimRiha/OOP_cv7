using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv7
{
    public abstract class Object2D : I2D, IComparable
    {
        public abstract double Area();
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (!(obj is Object2D)) throw new ArgumentException("Object is not a 2D object");

            if (Area() == ((Object2D)obj).Area()) return 0;
            else if (Area() > ((Object2D)obj).Area()) return 1;
            else return -1;
        }
    }
}
