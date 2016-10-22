using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = long.Parse(Console.ReadLine());
            var n2 = long.Parse(Console.ReadLine());
            var n3 = long.Parse(Console.ReadLine());
            var max = GetMax(n1, n2, n3);
            Console.WriteLine(max);
        }
        static long GetMax(long n1, long n2, long n3)
        {
            long maxnum = 0;
            if (n1 > n2 && n1 > n3)
            {
                maxnum = n1;
            }
            else if (n2 > n1 && n2 > n3)
            {
                maxnum = n2;
            }
            else if (n3 > n2 && n3 > n1)
            {
                maxnum = n3;
            }
            else
            {
                maxnum = n2;
            }
            return maxnum;
        }
    }
}
