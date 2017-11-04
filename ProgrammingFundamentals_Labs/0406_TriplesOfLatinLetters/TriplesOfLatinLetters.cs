using System;

class TriplesOfLatinLetters
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        for (char i = (char)97; i < input + 97; i++)
        {
            for (char j = (char)97; j < input + 97; j++)
            {
                for (char z = (char)97; z < input + 97; z++)
                {
                    Console.WriteLine($"{i}{j}{z}");
                }
            }
        }
    }
}
