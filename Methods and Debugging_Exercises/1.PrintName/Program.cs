﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.PrintName
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            PrintName(name);
        }
        static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!",name);
        }
    }
}
