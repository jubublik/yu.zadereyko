using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Реализовать неизменяемую структуру - простая дробь(x/y). Числитель и знаменатель - целые числа.
//Знаменатель - всегда положительный. Ноль - 0/x.Реализовать операции сложения, вычитания, умножения, деления.
//Реализовать интерфейс IComparable.Создать массив из N случайных дробей, отсортировать по возрастанию.
//Найти сумму всех дробей.
//*Сделать дробь не сокращаемой. Т.е. 2/4 -> 1/2, 50/15 -> 10/3, 0/7 -> 0/1 и т.д

namespace Lesson7
{
   struct SimpleFraction : IComparable<SimpleFraction>
    {
        public int Numerator { get; private set; }

        public int Denominator { get; private set; }

        public SimpleFraction(int numerator, int denominator)
        {
            Numerator = numerator;
            if (denominator > 0)
            {
                Denominator = denominator;
            }
            else
            {
                Console.WriteLine("Знаменатель должен быть положительным");
                Denominator = 0;
      
            }
        }

        public static SimpleFraction Reduction(SimpleFraction simple)
        {
            int mod;
            int num = 0;
            int den = 0;

            if (simple.Numerator > simple.Denominator)
            {
                mod = simple.Numerator % simple.Denominator;
            }
            else
            {
                mod = simple.Denominator % simple.Numerator;
            }
            if (mod != 0)
            {
                num = simple.Numerator / mod;
                den = simple.Denominator / mod;
            }

            return new SimpleFraction(num, den);
        }

        public static SimpleFraction Add(SimpleFraction left, SimpleFraction right)
        {
            int addNum = 0;
            int addDen = 0;

            if (left.Denominator == right.Denominator)
            {
                addNum = left.Numerator + right.Numerator;
                addDen = left.Denominator;
            }
            else
            {
                if (left.Numerator == 0)
                {
                    addNum = right.Numerator;
                    addDen = right.Denominator;
                }
                else if (right.Numerator == 0)
                {
                    addNum = left.Numerator;
                    addDen = left.Denominator;
                }
                else
                {
                    addNum = left.Numerator * right.Denominator + right.Numerator * left.Denominator;
                    addDen = left.Denominator * right.Denominator;
                }
            }
            return Reduction(new SimpleFraction(addNum, addDen));
        }

        public static SimpleFraction Subtract(SimpleFraction left, SimpleFraction right)
        {
            int subNum = 0;
            int subDen = 0;

            if (left.Denominator == right.Denominator)
            {
                subNum = left.Numerator - right.Numerator;
                subDen = left.Denominator;
            }
            else
            {
                if (left.Numerator == 0)
                {
                    subNum = - right.Numerator;
                    subDen = right.Denominator;
                }
                else if (right.Numerator == 0)
                {
                    subNum = left.Numerator;
                    subDen = left.Denominator;
                }
                else
                { 
                    subNum = left.Numerator * right.Denominator - right.Numerator * left.Denominator;
                    subDen = left.Denominator * right.Denominator;
                }
            }
            return new SimpleFraction(subNum, subDen);
        }

        public static SimpleFraction Multiply(SimpleFraction left, SimpleFraction right)
        {
            int multyNum = 0;
            int multyDen = 0;

            if (left.Numerator == 0 || right.Numerator == 0)
            {
                multyNum = 0;
                multyDen = left.Denominator * right.Denominator;
            }
            else
            { 
                multyNum = left.Numerator * right.Numerator;
                multyDen = left.Denominator * right.Denominator;
            }

            return new SimpleFraction(multyNum, multyDen);
        }

        public static SimpleFraction Divisive(SimpleFraction left, SimpleFraction right)
        {
            int divNum = 0;
            int divDen = 0;
            if (left.Numerator == 0)
            {
                divNum = 0;
                divDen = left.Denominator * right.Numerator;
            }
            else
            { 
                divNum = left.Numerator * right.Denominator;
                divDen = left.Denominator * right.Numerator;
            }
            return new SimpleFraction(divNum, divDen);
        }


        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public int CompareTo(SimpleFraction fraction)
        {
            int compareLeft = Numerator * fraction.Denominator;
            int compareRight = fraction.Numerator * Denominator;

            if (compareLeft > compareRight)
                return 1;
            if (compareLeft < compareRight)       
                return -1;
            return 0;
        }
    }
}
