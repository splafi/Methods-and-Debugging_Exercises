using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FibonachiNumbers
{
    class ibonachiNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetNumber(n));

        }
        static int GetNumber(int n)
        {
            var firstNum = 0;
            var secondNum = 0;
            var currentNum = 1;
            for (int i = 0; i < n; i++)
            {
                firstNum = secondNum;
                secondNum = currentNum;
                currentNum = firstNum + secondNum;
            }
            return currentNum;
        }
    }
}
