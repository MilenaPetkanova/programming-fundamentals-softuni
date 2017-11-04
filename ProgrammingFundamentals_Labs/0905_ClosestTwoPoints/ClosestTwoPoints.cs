using System;
using System.Linq;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

class ClosestTwoPoints
{
    static void Main()
    {
        Point[] points = ReadPoints();
        Point[] closestPoints = FindClosestPoints(points);

        PrintDistAndClosestPoints(closestPoints);
    }

    private static void PrintDistAndClosestPoints(Point[] closestPoints)
    {
        double minDistance = GetDistBtwnTwoPoints(closestPoints[0], closestPoints[1]);
        Console.WriteLine("{0:f3}", minDistance);

        foreach (var point in closestPoints)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }
    }

    private static Point[] ReadPoints()
    {
        int n = int.Parse(Console.ReadLine());

        Point[] points = new Point[n];
        for (int i = 0; i < n; i++)
        {
            points[i] = ReadPoint();
        }
        return points;
    }

    static Point ReadPoint()
    {
        var pointInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Point point = new Point();
        point.X = pointInfo[0];
        point.Y = pointInfo[1];
        return point;
    }

    private static Point[] FindClosestPoints(Point[] points)
    {
        double minDistance = double.MaxValue;
        Point[] closestPoints = new Point[2];
        for (int p1 = 0; p1 < points.Length; p1++)
        {
            for (int p2 = p1 + 1; p2 < points.Length; p2++)
            {
                double distance = GetDistBtwnTwoPoints(points[p1], points[p2]);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestPoints = new Point[] { points[p1], points[p2] };
                }
            }
        }
        return closestPoints;
    }

    static double GetDistBtwnTwoPoints(Point p1, Point p2)
    {
        double sideA = p1.X - p2.X;
        double sideB = p1.Y - p2.Y;
        double sideC = Math.Sqrt(sideA * sideA + sideB * sideB);
        return sideC;
    }
}


