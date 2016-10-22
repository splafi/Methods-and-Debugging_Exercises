using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            var figureType = Console.ReadLine().ToLower();
            if (figureType == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                PrintTriangleArea(a, h);
            }
            else if (figureType == "square")
            {
                var a = double.Parse(Console.ReadLine());
                PrintSquareArea(a);
            }
            else if (figureType == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                PrintRectangleArea(a, b);
            }
            else if (figureType == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                PrintCircleArea(r);
            }
        }
        static void PrintTriangleArea(double a, double h)
        {
            var area = a * h / 2;
            Console.WriteLine("{0:f2}", area);
        }
        static void PrintSquareArea(double a)
        {
            var area = a * a;
            Console.WriteLine("{0:f2}", area);
        }
        static void PrintRectangleArea(double a, double h)
        {
            var area = a * h;
            Console.WriteLine("{0:f2}", area);
        }
        static void PrintCircleArea(double r)
        {
            var area = Math.PI * r * r;
            Console.WriteLine("{0:f2}", area);
        }
    }
}
