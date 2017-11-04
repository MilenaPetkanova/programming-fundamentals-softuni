﻿using System;

namespace _0507_MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

        private static double RaiseToPower(double number, double power)
        {
            double result = 1;
            for (double i = 0; i < power; i++)
            {
                result = result * number;
            }
            return result;
        }
    }
}
