using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    public static class PrintClass
    {
        public static void Print(int value)
        {
            Console.WriteLine("int value = " + value);
        }

        public static void Print(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Print(array[i]);
            }
        }
    }
}
