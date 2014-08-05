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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The area is: " + Rectangle.CalculateArea(5, 4));
            Console.ReadKey();

        }
    }
}
