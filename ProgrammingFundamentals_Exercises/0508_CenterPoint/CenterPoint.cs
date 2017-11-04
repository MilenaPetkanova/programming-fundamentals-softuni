using System;

namespace _0508_CenterPodouble
{
    class CenterPodouble
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestPoints(x1, y1, x2, y2);
        }

        static void PrintClosestPoints(double x1, double y1, double x2, double y2)
        {
            double diagonalX1Y1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double diagonalX2Y2 = Math.Sqrt(x2 * x2 + y2 * y2);
            if (diagonalX1Y1 <= diagonalX2Y2)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }
    }
}
