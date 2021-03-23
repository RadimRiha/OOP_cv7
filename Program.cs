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
            Triangle[] triangles = { new Triangle(1, 1, 1), new Triangle(2, 3, 2), new Triangle(5, 6, 2) };
            Object2D[] objects2D = { new Triangle(7, 5, 10), new Circle(2), new Square(2) };

            Console.WriteLine("Largest integer: {0}", Extremes.Largest<int>(integers).ToString());
            Console.WriteLine("Smallest integer: {0}", Extremes.Smallest<int>(integers).ToString());
            Console.WriteLine();
            Console.WriteLine("Largest string: {0}", Extremes.Largest<string>(strings).ToString());
            Console.WriteLine("Smallest string: {0}", Extremes.Smallest<string>(strings).ToString());
            Console.WriteLine();
            Console.WriteLine("Largest circle: {0}", Extremes.Largest<Object2D>(circles).ToString());
            Console.WriteLine("Smallest circle: {0}", Extremes.Smallest<Object2D>(circles).ToString());
            Console.WriteLine();
            Console.WriteLine("Largest rectangle: {0}", Extremes.Largest<Object2D>(rectangles).ToString());
            Console.WriteLine("Smallest rectangle: {0}", Extremes.Smallest<Object2D>(rectangles).ToString());
            Console.WriteLine();
            Console.WriteLine("Largest square: {0}", Extremes.Largest<Object2D>(squares).ToString());
            Console.WriteLine("Smallest square: {0}", Extremes.Smallest<Object2D>(squares).ToString());
            Console.WriteLine();
            Console.WriteLine("Largest ellipse: {0}", Extremes.Largest<Object2D>(ellipses).ToString());
            Console.WriteLine("Smallest ellipse: {0}", Extremes.Smallest<Object2D>(ellipses).ToString());
            Console.WriteLine();
            Console.WriteLine("Largest triangle: {0}", Extremes.Largest<Object2D>(triangles).ToString());
            Console.WriteLine("Smallest triangle: {0}", Extremes.Smallest<Object2D>(triangles).ToString());
            Console.WriteLine();
            Console.WriteLine("Largest 2D object: {0}", Extremes.Largest<Object2D>(objects2D).ToString());
            Console.WriteLine("Smallest 2D object: {0}", Extremes.Smallest<Object2D>(objects2D).ToString());
            Console.WriteLine();
            Console.WriteLine("Filtered integers using LINQ:");
            foreach(int i in integers.Where(c => c >= 4 && c <= 8)) Console.Write("{0} ", i);
            Console.WriteLine();
        }
    }
}
