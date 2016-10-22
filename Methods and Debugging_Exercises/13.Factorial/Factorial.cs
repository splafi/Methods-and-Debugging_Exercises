using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            var n = BigInteger.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
            for (int i = 1; i <= n; i++)
            {
                factoriel = i * factoriel;
            }
            Console.WriteLine(factoriel);
        }
    }
}
