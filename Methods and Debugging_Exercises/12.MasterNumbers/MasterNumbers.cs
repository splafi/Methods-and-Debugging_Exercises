using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //IsPalindrome(n);
            //DivBySeven(n);
            OneEvenDigit(n);
        }
        static void IsPalindrome(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if ((i % 10) == (int)(i / 10) || n / 100 == (int)n % 100 || (int)n / 1000 == n % 1000 || (int)n / 10000 == n % 10000 || (int)n / 100000 == n % 100000 || (int)n / 1000000 == n % 1000000)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void DivBySeven(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void OneEvenDigit(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
