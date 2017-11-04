using System;

namespace _0416_ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            double difference = 0;
            bool isEqual = false;

            if (b > a)
            {
                difference = b - a;
                if (difference < eps)
                {
                    isEqual = true;
                }
            }
            if (a > b)
            {
                difference = a - b;
                if (difference < eps)
                {
                    isEqual = true;
                }
            }
            Console.WriteLine(isEqual);
        }
    }
}
