using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv7
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { 1, 3, 5, 7, 9 };
            string[] strings = { "a", "abc", "hello" };
            Circle[] circles = { new Circle(1), new Circle(5), new Circle(2), };
            Rectangle[] rectangles = { new Rectangle(1, 1), new Rectangle(2, 1), new Rectangle(1, 3), };
            Square[] squares = { new Square(1), new Square(10), new Square(2), };
            Ellipse[] ellipses = { new Ellipse(1, 2), new Ellipse(1, 5), new Ellipse(10, 2), };
            Triangle[] triangles = { new Triangle(1, 1, 1), new Triangle(1, 2, 3), new Triangle(5, 6, 2) };
            Object2D[] objects2D = { new Triangle(1, 2, 3), new Circle(5), new Square(2) };

            Console.WriteLine("Largest integer: {0}", Extremes.Largest<int>(integers).ToString());
        }
    }
}
