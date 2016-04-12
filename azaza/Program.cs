using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {


            // Ввести с консоли 2 числа, вывести их на консоль
            int a;
            int b;
            int c;

            // a = Convert.ToInt32(Console.ReadLine());
            // b = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(a + b);

            // Ввести с консоли 2 числа: n и i , вывести значение i-го бита числа n

            // a = Convert.ToInt32(Console.ReadLine());
            // b = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine((a >> b) & 1);

            // Ввести с консоли число. Обнулить последний бит этого числа. Вывести на консоль

              a = Convert.ToInt32(Console.ReadLine());
              b = a >> 1;
              c = b << 1;

              Console.WriteLine(c);

        }
    }
}
