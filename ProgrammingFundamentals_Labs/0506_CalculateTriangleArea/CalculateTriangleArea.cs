using System;

class CalculateTriangleArea
{
    static void Main()
    {
        double triangleBase = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = CalculateAreaTriangle(triangleBase, height);
        Console.WriteLine(area);
    }

    private static double CalculateAreaTriangle(double h, double b)
    {
        return (h * b) / 2;
    }
}
