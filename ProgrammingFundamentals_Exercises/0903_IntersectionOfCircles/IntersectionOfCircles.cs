using System;
using System.Linq;

class Circle
{
    public int[] Center { get; set; }
    public int Radius { get; set; }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

class IntersectionOfCircles
{
    static void Main()
    {

        var firstPointArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var firstPoint = new Point
        {
            X = firstPointArgs[0],
            Y = firstPointArgs[1]
        };
        var firstCircle = new Circle
        {
            Radius = firstPointArgs[2],
            Center = new int[] { firstPoint.X, firstPoint.Y }
        };

        var secondPointArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var secondPoint = new Point
        {
            X = secondPointArgs[0],
            Y = secondPointArgs[1]
        };
        var secondCircle = new Circle
        {
            Radius = secondPointArgs[2],
            Center = new int[] { secondPoint.X, secondPoint.Y }
        };

        bool intersect = Intersect(firstCircle, secondCircle);

        Console.WriteLine(intersect == true ? "Yes" : "No");

    }

    private static bool Intersect(Circle firstCircle, Circle secondCircle)
    {

        double distanceBetweenCenters = 
            GetDistBtwnTwoPoints(firstCircle, secondCircle);

        if (distanceBetweenCenters <= firstCircle.Radius + secondCircle.Radius)
        {
            return true;
        }
        return false;
    }

    static double GetDistBtwnTwoPoints(Circle firstCircle, Circle secondCircle)
    {
        double sideA = firstCircle.Center[0] - secondCircle.Center[0];
        double sideB = firstCircle.Center[1] - secondCircle.Center[1];
        double sideC = Math.Sqrt(sideA * sideA + sideB * sideB);
        return sideC;
    }

}
