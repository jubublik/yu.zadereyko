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
            
            if (numerator < 0)
            {
                throw new ArgumentOutOfRangeException("Числитель должен быть не отрицательным.");
            }

            if (denominator < 0)
            {
                throw new ArgumentOutOfRangeException("Знаменатель должен быть положительным.");
            }
            
            Numerator = numerator;
            Denominator = denominator;
        }

        public static int GreatestCommonDivisor(int x, int y)
        {
            while (y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }
            return x;
        }

        public static SimpleFraction Reduction(SimpleFraction simple)
        {
            int num = 0;
            int den = 0;

            int gcd = GreatestCommonDivisor(simple.Numerator, simple.Denominator);

            if (gcd != 0)
            {
                num = simple.Numerator / gcd;
                den = simple.Denominator / gcd;
            }
            else
            {
                throw new DivideByZeroException();
            }

            return new SimpleFraction(num, den);
        }

        public static SimpleFraction OperationBase(SimpleFraction left, SimpleFraction right, bool oper)
        {
            int Num = 0;
            int Den = 0;

            if (oper == true)
            {
                Num = left.Numerator * right.Denominator + right.Numerator * left.Denominator;
            }
            else
            {
                Num = left.Numerator * right.Denominator - right.Numerator * left.Denominator;
            }

            Den = left.Denominator * right.Denominator;

            return Reduction(new SimpleFraction(Num, Den));
        }

        public static SimpleFraction Add(SimpleFraction left, SimpleFraction right)
        {
            return Reduction(OperationBase(left, right, true));
        }

        public static SimpleFraction Subtract(SimpleFraction left, SimpleFraction right)
        {
            return Reduction(OperationBase(left, right, false));
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

            return Reduction(new SimpleFraction(multyNum, multyDen));
        }

        public static SimpleFraction Divisive(SimpleFraction left, SimpleFraction right)
        {
            int divNum = 0;
            int divDen = 0;

            if (right.Numerator == 0)
            {
                throw new DivideByZeroException();
            }

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
            return Reduction(new SimpleFraction(divNum, divDen));
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
