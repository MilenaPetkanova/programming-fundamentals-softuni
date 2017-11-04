using System;
using System.Linq;

class LettersChangeNumbers
{
    static void Main()
    {
        var inputArgs = Console.ReadLine()
            .Split(new char[] { ' ', '\r', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        double totalSum = 0;

        foreach (string arg in inputArgs)
        {
            char firstLetter = arg.First();
            char secondLetter = arg.Last();

            double number = double.Parse(arg.Substring(1, arg.Length - 2));

            totalSum += CalculateNumberByLetters(number, firstLetter, secondLetter);
        }

        Console.WriteLine("{0:f2}", totalSum);
    }

    private static double CalculateNumberByLetters(double number, char firstLetter, char secondLetter)
    {
        if (char.IsUpper(firstLetter))
        {
            int position = firstLetter - 64;
            number /= position;
        }
        else
        {
            int position = firstLetter - 96;
            number *= position;
        }

        if (char.IsUpper(secondLetter))
        {
            int position = secondLetter - 64;
            number -= position;
        }
        else 
        {
            int position = secondLetter - 96;
            number += position;
        }

        return number;
    }

}
