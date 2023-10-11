﻿using System;

namespace _08._FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            long first = long.Parse(Console.ReadLine());
            long second = long.Parse(Console.ReadLine());

            Console.WriteLine($"{(Factorial(first) / Factorial(second)):f2}");
        }

        private static double Factorial(long number)
        {
            double result = number;

            for (long i = number - 1; i >= 1; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
    
