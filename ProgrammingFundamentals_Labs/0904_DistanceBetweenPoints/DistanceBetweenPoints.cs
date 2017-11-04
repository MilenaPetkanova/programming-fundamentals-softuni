using System;
using System.Collections.Generic;
using System.Linq;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

class DistanceBetweenPoints
{
    static void Main()
    {
        Point p1 = ReadPoint();
        Point p2 = ReadPoint();

        double distance = GetDistBtwnTwoPoints(p1, p2);

        Console.WriteLine("{0:f3}", distance);
    }

    static Point ReadPoint()
    {
        var pointInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Point point = new Point();
        point.X = pointInfo[0];
        point.Y = pointInfo[1];
        return point;
    }

    static double GetDistBtwnTwoPoints(Point p1, Point p2)
    {
        double sideA = p1.X - p2.X;
        double sideB = p1.Y - p2.Y;
        double sideC = Math.Sqrt(sideA * sideA + sideB * sideB);
        return sideC;
    }
}



