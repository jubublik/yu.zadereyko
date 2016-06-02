using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Program
    {
        #region Задание 1

        //Сделать методы для считывания целых чисел, дробных чисел. 
        static void Main(string[] args)
        {
           // DuplicateNumbers();
            int[] newarr = new int[3];

            for (int i = 0; i < newarr.Length; i++)
            {
                newarr[i] = Convert.ToInt32(Console.ReadLine());
            }

            newarr.Print();

            Console.ReadLine();
        }

        private static int GetInt()
        {
            int value;
            if (int.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }

            return 0;
        }

        private static decimal GetDecimal()
        {
            decimal value;
            if (decimal.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }

            return 0;
        }

        //public static void Print(int value)
        //{
        //    Console.WriteLine("int value = " + value);
        //}

        //public void Print(decimal value)
        //{
        //    Console.WriteLine("decimal value = " + value);
        //}

        // Сделать методы для вывода на консоль этих типов данных, массивов целых и дробных чисел (можно доработать любое ДЗ).
        //public static void Print(this int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Print(array[i]);
        //    }
        //}



        //public void Print(decimal[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Print(array[i]);
        //    }
        //}
        #endregion

        #region Домашнее задание

        //Считать строку с консоли.Создать словарь, где ключом будет символ строки, а значением - количество данных символов в считанной строке.
        public static void CountSymbols()
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            string value = Console.ReadLine();

            for (int i = 0; i < value.Length; i++)
            {
                char currentSymbol = value[i];

                if (!dictionary.ContainsKey(currentSymbol))
                {
                    dictionary.Add(currentSymbol, 1);
                }
                else
                {
                    dictionary[currentSymbol] = dictionary[currentSymbol] + 1;
                }
            }
        }

        //Считывать с консоли числа, пока не будет введено число “-1”, среди введенных чисел вывести все дублирующиеся.
        public static void DuplicateNumbers()
        {
            List<int> numbers = new List<int>();
            List<int> duplicates = new List<int>();
            int number = 0;

            while(true)
            {
                number = GetInt();

                if (number == -1)
                {
                    break;
                }

                if (numbers.Contains(number))
                {
                    duplicates.Add(number);
                }

                numbers.Add(number);
            }
        
            for (int i = 0; i < duplicates.Count; i++)
            {
                Console.WriteLine(duplicates[i]);
            }
        }

        #endregion
    }
}