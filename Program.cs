using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 181;
            int b = num >> 1;
            int x = num << 1;
            int num2 = x | b;
            int num3 = num|b;
            int num4 = num2 & num3;
            string BinaryCodeNum4= Convert.ToString(num4, 2);
            Console.WriteLine();
            Console.WriteLine("BinaryCode4= " + BinaryCodeNum4);
            Console.WriteLine("num4= " + num4);
        }

    }
}

/*Напишите функцию, которая принимает целое беззнаковое число, меняет в нем местами четные и нечетные биты и возвращает результат.
Например, двоичное число 10110101 = 181 должно превратиться в двоичное 01111010 = 122. */
