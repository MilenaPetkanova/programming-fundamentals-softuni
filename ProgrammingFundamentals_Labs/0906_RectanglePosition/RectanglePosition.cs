using System;
using System.Collections.Generic;
using System.Linq;

class Rectangle
{
    public int Left { get; set; }
    public int Top { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Right { get; set; }
    public int Bottom { get; set; }
}

class RectanglePosition
{
    static void Main()
    {
        Rectangle first = ReadRectangle();
        Rectangle second = ReadRectangle();

        bool isInside = IsFirstInideSecond(first, second);
        PrintInsideOrNot(isInside);
    }

    private static void PrintInsideOrNot(bool isInside)
    {
        if (isInside)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Not inside");
        }
    }

    private static bool IsFirstInideSecond(Rectangle first, Rectangle second)
    {
        if (first.Left >= second.Left && first.Right <= second.Right
            && first.Top >= second.Top && first.Bottom <= second.Bottom)
        {
            return true;
        }
        return false;
    }

    private static Rectangle ReadRectangle()
    {
        var sides = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Rectangle rectangle = new Rectangle();
        rectangle.Left = sides[0];
        rectangle.Top = sides[1];
        rectangle.Width = sides[2];
        rectangle.Height = sides[3];

        rectangle.Right = rectangle.Left + rectangle.Width;
        rectangle.Bottom = rectangle.Top + rectangle.Height;

        return rectangle;
    }
}
