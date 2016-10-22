using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var name = Console.ReadLine();
            double face = 0;
            double space = 0;
            double volume = 0;
            double area = 0;
            if (name == "face")
            {
                face = GetFace(a);
                Console.WriteLine("{0:f2}", face);
            }
            else if (name == "space")
            {
                space = GetSpace(a);
                Console.WriteLine("{0:f2}", space);
            }
            else if (name == "volume")
            {
                volume = GetVolume(a);
                Console.WriteLine("{0:f2}", volume);
            }
            else if (name == "area")
            {
                area = GetArea(a);
                Console.WriteLine("{0:f2}", area);
            }

        }
        static double GetFace(double a)
        {
            var face = Math.Sqrt(2 * a * a);
            return face;
        }
        static double GetSpace(double a)
        {
            var space = Math.Sqrt(3 * a * a);
            return space;
        }
        static double GetVolume(double a)
        {
            var volume = a * a * a;
            return volume;
        }
        static double GetArea(double a)
        {
            var area = 6 * a * a;
            return area;
        }
    }
}
