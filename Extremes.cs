using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv7
{
    public class Extremes
    {
        public static T Largest<T>(T[] objects) where T : IComparable
        {
            if (objects.Length == 0) throw new Exception("Cannot find greatest member in an empty array");

            T currentLargest = objects[0];
            for (int i = 0; i < objects.Length - 1; i++)
            {
                if (objects[i + 1].CompareTo(objects[i]) > 0) currentLargest = objects[i + 1];
            }

            return currentLargest;
        }
        public static T Smallest<T>(T[] objects) where T : IComparable
        {
            if (objects.Length == 0) throw new Exception("Cannot find greatest member in an empty array");

            T currentSmallest = objects[0];
            for (int i = 0; i < objects.Length - 1; i++)
            {
                if (objects[i + 1].CompareTo(objects[i]) < 0) currentSmallest = objects[i + 1];
            }

            return currentSmallest;
        }
    }
}
