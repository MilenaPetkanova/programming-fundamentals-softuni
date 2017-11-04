using System;

class MultiplyEvensByOdds
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        input = Math.Abs(input);

        int result = GetEvensByOdds(input);
        Console.WriteLine(result);
    }

    static int GetEvensByOdds(int input)
    {
        int sumEvens = GetsumEvens(input);
        int sumOdds = GetSumOdds(input);
        return sumEvens * sumOdds;
    }

    private static int GetsumEvens(int input)
    {
        int sumEvens = 0;
        while (input > 0)
        {
            int evensChecker = input % 10;
            if (evensChecker % 2 == 0)
            {
                sumEvens += evensChecker;
            }
            input = input / 10;
        }
        return sumEvens;
    }

    private static int GetSumOdds(int input)
    {
        int sumOdds = 0;
        while (input > 0)
        {
            int oddsChecker = input % 10;
            if (oddsChecker % 2 == 1)
            {
                sumOdds += oddsChecker;
            }
            input = input / 10;
        }
        return sumOdds;
    }
}
