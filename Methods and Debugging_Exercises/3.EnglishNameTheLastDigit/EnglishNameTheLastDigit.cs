using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EnglishNameTheLastDigit
{
    class EnglishNameTheLastDigit
    {
        static void Main(string[] args)
        {
            var number = Math.Abs(long.Parse(Console.ReadLine()));
         //for (int i = 0; (long)number / number != 1; i++)
         //{
         //    number = number * 10;
         //}
         Console.WriteLine(ReturnName((long)number));
        }
        static string ReturnName(long number)
        {
            string lastdigitString = "";
            long lastdigitInt = (long)number%10;
            switch (lastdigitInt)
            {
                case 0:
                    lastdigitString = "zero";
                    break;
            
            
               case 1:
                   lastdigitString = "one";
               break;
            
            
               case 2:
                   lastdigitString = "two";
               break;
            
            
               case 3:
                   lastdigitString = "three";
               break;
            
            
               case 4:
                   lastdigitString = "four";
               break;
            
            
               case 5:
                   lastdigitString = "five";
               break;
            
            
                case 6:
                    lastdigitString = "six";
                break;
                case 7:
                    lastdigitString = "seven";
                break;

                case 8:
                    lastdigitString = "eight";
                break;

                case 9:
                    lastdigitString = "nine";
                break;
            }
            return lastdigitString;
        }

    }
}
