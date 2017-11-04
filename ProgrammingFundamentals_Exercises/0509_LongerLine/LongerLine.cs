using System;

namespace _0509_LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double xx1 = double.Parse(Console.ReadLine());
            double xy1 = double.Parse(Console.ReadLine());
            double xx2 = double.Parse(Console.ReadLine());
            double xy2 = double.Parse(Console.ReadLine());
            double yx1 = double.Parse(Console.ReadLine());
            double yy1 = double.Parse(Console.ReadLine());
            double yx2 = double.Parse(Console.ReadLine());
            double yy2 = double.Parse(Console.ReadLine());

            double dX = GetDistBtwnTwoPoints(xx1, xx2, xy1, xy2);
            double dY = GetDistBtwnTwoPoints(yx1, yx2, yy1, yy2);

            if (dX >= dY)
            {
                PrintClosestPointsFirst(xx1, xy1, xx2, xy2);
            }
            else
            {
                PrintClosestPointsFirst(yx1, yy1, yx2, yy2);
            }
        }

        static double GetDistBtwnTwoPoints(double x1, double x2, double y1, double y2)
        {
            double dX = x1 - x2;
            double dY = y1 - y2;
            double dXY = Math.Sqrt(dX * dX + dY * dY);
            return dXY;
        }

        static void PrintClosestPointsFirst(double x1, double y1, double x2, double y2)
        {
            double diagonalX1Y1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double diagonalX2Y2 = Math.Sqrt(x2 * x2 + y2 * y2);
            if (diagonalX1Y1 <= diagonalX2Y2)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
            }
        }
    }
}
