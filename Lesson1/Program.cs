using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            Console.WriteLine("Введите два числа:");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Их сумма:");
            Console.WriteLine(a + b);

            // Ввести с консоли 2 числа: n и i , вывести значение i-го бита числа n
            Console.WriteLine("Введите два числа:n и i");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("значение i-го бита числа n:");
            Console.WriteLine((a >> b) & 1);

            //Ввести с консоли число. Обнулить последний бит этого числа. Вывести на консоль
            Console.WriteLine("Введите число:");
            a = Convert.ToInt32(Console.ReadLine());
            b = a >> 1;
            c = b << 1;
            Console.WriteLine("После обнуления последнего бита:");
            Console.WriteLine(c);



            Console.ReadLine();

        }
    }
}
