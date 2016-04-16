using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            #region Задание 1

            ////Ввести с консоли N чисел. Вывести сумму, максимальное, минимальное значения, количество четных чисел, произведение нечетных чисел.
            //int Num;
            //int Sum = 0;
            //int Max = 0;
            //int Min = 0;
            //int Even = 0;
            //int unEven = 0;
            //Console.WriteLine("Введите число N:");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Введите число:");
            //    Num = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("-----");
            //    Sum += Num;

            //    if (Num > Max)
            //    {
            //        Max = Num;
            //    }
            //    if (i == 1)
            //    {
            //        Min = Num;
            //    }
            //    else if (Num < Min)
            //    {
            //        Min = Num;
            //    }

            //    if (Num % 2 == 0)
            //    {
            //        Even++;
            //    }
            //    else
            //    {
            //        if (i == 1)
            //        {
            //            unEven = Num;
            //        }
            //        else
            //        {
            //            unEven = unEven * Num;
            //        }
            //    }
            //}
            //Console.WriteLine("Сумма:");
            //Console.WriteLine(Sum);
            //Console.WriteLine("Макс");
            //Console.WriteLine(Max);
            //Console.WriteLine("Мин");
            //Console.WriteLine(Min);
            //Console.WriteLine("Кол-во четных");
            //Console.WriteLine(Even);
            //Console.WriteLine("Произведение нечетных");
            //Console.WriteLine(unEven);
            #endregion
            #region Задание 2

            //Заполнить с консоли массив из N элементов. Отсортировать. Вывести результат. N - задается с консоли
            //Console.WriteLine("Введите N - число элементов в массиве");
            //n = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine(n);
            //int[] numbers = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Введите число");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //Array.Sort(numbers);
            //for (int j = 0; j < n; j++)
            //{
            //    Console.WriteLine(numbers[j]);
            //}

            //Заполнить 2 матрицы размерности NxN случайными числами. Вывести на консоль. Сложить 2 матрицы. Вывести результат.

            //int[,] matrix_1 = new int[n, n];
            //int[,] matrix_2 = new int[n, n];
            //int[,] matrix_3 = new int[n, n];

            //Random rand = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        matrix_1[i, j] = rand.Next(10);
            //        matrix_2[i, j] = rand.Next(10);
            //    }
            //}


            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(matrix_1[i, j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("+");

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(matrix_2[i, j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        matrix_3[i, j] = matrix_1[i, j] + matrix_2[i, j];
            //    }
            //}
            //Console.WriteLine("-------");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(matrix_3[i, j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Домашнее задание
            //Заполнить массив длиной N случайными числами. Ввести с консоли число A. Вывести Yes, если число A есть в массиве, No - в противном случае.
            //Console.WriteLine("Введите N - число элементов в массиве");
            //n = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[n];

            //Random rand = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    numbers[i] = rand.Next(10);
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(numbers[i]);
            //    Console.Write(" ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Введите число A");
            //int A = Convert.ToInt32(Console.ReadLine());
            //bool Yes=false;
            //Console.WriteLine("---");
            //for (int i = 0; i < n; i++)
            //{
            //    if (A == numbers[i])
            //    {
            //        Yes = true;
            //    }
            //}

            //if (Yes)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}


            //Заполнить матрицу NxM случайными числами.Из каждой строки выбрать минимальный элемент, занести его в массив.Отсортировать полученный массив и вывести его значения в обратном порядке.

            //Console.WriteLine("Введите N ");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите M");
            //m = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[n];
            //int[,] matrix = new int[n, m];
            //int Min = 0;

            //Random rand = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        matrix[i, j] = rand.Next(10);
            //    }
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(matrix[i, j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    Min = matrix[i, 0];
            //    for (int j = 0; j < m; j++)
            //    {

            //        if (matrix[i, j] < Min) {
            //            Min = matrix[i, j];
            //        }
            //    }
            //    numbers[i] = Min;
            //    Console.WriteLine();
            //}
            //Array.Sort(numbers);
            //for (int i = n - 1; i > 0; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            //Калькулятор.С консоли вводится левый операнд, операция, правый операнд. Выводится результат операции над операндами.Реализовать как минимум 4 операции, обработку ошибок (деление на 0 и др).
            string Oper;
            while (true)
            {
                Console.WriteLine("Введите лeвый операнд:");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите операцию:");
                Oper = Console.ReadLine();
                Console.WriteLine("Введите правый операнд:");
                m = Convert.ToInt32(Console.ReadLine());

                if (Oper == "+")
                {
                    Console.WriteLine("Результат:");
                    Console.WriteLine(n + m);
                }
                else if (Oper == "-")
                {
                    Console.WriteLine("Результат:");
                    Console.WriteLine(n - m);
                }
                else if (Oper == "*")
                {
                    Console.WriteLine("Результат:");
                    Console.WriteLine(n * m);
                }
                else if (Oper == "/")
                {
                    Console.WriteLine("Результат:");
                    if (m == 0)
                    {
                        Console.WriteLine("Делить на 0 нельзя");
                    }
                    else
                    {
                        Console.WriteLine(n / m);
                    }
                }
                else
                {
                    Console.WriteLine("Введена недопустимая операция, используйте -, +, *, /");
                }
            }
            #endregion
            Console.ReadLine();
        }
    }
}

