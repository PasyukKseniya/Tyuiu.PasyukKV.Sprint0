﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PasyukKV.Sprint0.Task5.V0.Lib;
namespace Tyuiu.PasyukKV.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(10, 5));
            Console.WriteLine("A - B = " + DataService.Substract(10, 5));
            Console.WriteLine("A * B = " + DataService.Mplicate(10, 5));
            Console.WriteLine("A / B = " + DataService.Division(10, 0));
            Console.ReadKey();
        }
    }
}
