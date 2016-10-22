using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            var n = BigInteger.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
            BigInteger result = 0;
            for (int i = 1; i <= n; i++)
            {
                factoriel *= i ;
            }
            for (BigInteger i = 10; i < factoriel; i *= 10)
            {
                if ((factoriel % i) == 0)
                {
                    result += 1;
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine("{0}",  result);
        }
    }
}
