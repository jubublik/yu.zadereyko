﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleFraction simple1 = new SimpleFraction(0, 15);
            SimpleFraction simple2 = new SimpleFraction(50, 15);

            SimpleFraction simple3 = SimpleFraction.Add(simple1,simple2);
            SimpleFraction simple4 = SimpleFraction.Subtract(simple1, simple2);
            SimpleFraction simple5 = SimpleFraction.Multiply(simple1, simple2);
            SimpleFraction simple6 = SimpleFraction.Divisive(simple1, simple2);

            Console.WriteLine($"{simple1} + {simple2} = {simple3}");
            Console.WriteLine($"{simple1} - {simple2} = {simple4}");
            Console.WriteLine($"{simple1} * {simple2} = {simple5}");
            Console.WriteLine($"{simple1} : {simple2} = {simple6}");


            SimpleFraction[] compare = new SimpleFraction[5];
            for (int i = 0; i < compare.Length; i++)
            {
                compare[i] = new SimpleFraction(1, i+1);
            }
            Array.Sort(compare);

            for (int i = 0; i < compare.Length; i++)
            {
                Console.WriteLine(compare[i]);
            }

            Console.ReadLine();

        }
    }
}
