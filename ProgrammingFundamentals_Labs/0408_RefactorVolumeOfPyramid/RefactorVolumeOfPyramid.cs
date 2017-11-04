using System;

class RefactorVolumeOfPyramid
{
    static void Main()
    {
        Console.Write("Length: ");
        decimal length = decimal.Parse(Console.ReadLine());

        Console.Write("Width: ");
        decimal width = decimal.Parse(Console.ReadLine());

        Console.Write("Height: ");
        decimal height = decimal.Parse(Console.ReadLine());

        decimal pyramidVolume = (length * width * height) / 3;
        Console.WriteLine("Pyramid Volume: {0:F2}", pyramidVolume);
    }
}
