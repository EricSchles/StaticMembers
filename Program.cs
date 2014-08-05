using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    public static class Rectangle
    {
        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }
    }

    public static class Circle
    {
        public static double CalculateArea(float radius)
        {
            return Math.PI * Math.Pow(radius, 2.0);
        }
    }

    public static class Triangle
    {
        public static double CalculateArea(double Height, double Base)
        {
            return (Height * Base) / 2.0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The area is: " + Rectangle.CalculateArea(5, 4));
            Console.ReadKey();

        }
    }
}
