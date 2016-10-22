using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NiumbersReserved
{
    class ReversedNums
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var reversed = GetReversed(n);
            Console.WriteLine(reversed);
        }
        static string GetReversed(string number)
        {
            string result = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                result += number[i];
            }
            return result;
        }
    }
}
