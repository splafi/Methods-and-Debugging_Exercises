using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            var n = Math.Abs(long.Parse(Console.ReadLine()));
            bool isPrime = IsTrue(n);
            Console.WriteLine(isPrime);
        }
        static bool IsTrue(long n)
        {
            bool isTrue = true;
            if (n == 0 || n == 1)
            {
                isTrue = false;
            }
            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isTrue = false;
                }
            }
            return isTrue;
        }
    }
}
