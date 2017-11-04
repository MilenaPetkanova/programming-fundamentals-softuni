using System;
using System.Collections.Generic;
using System.Linq;

class BombNumbers
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToList();

        int[] specialNums = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToArray();
        int bomb = specialNums[0];
        int power = specialNums[1];

        while (numbers.Contains(bomb))
        {
            int removeLeft = numbers.IndexOf(bomb) - power;
            int removeRight = numbers.IndexOf(bomb) + power;
            int bombIndex = numbers.IndexOf(bomb);

            if (removeRight > numbers.Count - 1 
                && removeLeft >= 0)
            {
                int removeCounter = 0;
                for (int i = bombIndex; i < numbers.Count; i++)
                {
                    removeCounter++;
                }
                numbers.RemoveRange(removeLeft, power + removeCounter);
            }

            else if (removeLeft < 0
                && removeRight <= numbers.Count - 1)
            {
                int removeCounter = 0;
                for (int i = 0; i <= bombIndex; i++)
                {
                    removeCounter++;
                }
                numbers.RemoveRange(0, removeCounter + power);
            }

            else if(removeRight > numbers.Count - 1 
                && removeLeft < 0)
            {
                numbers.Clear();
                Console.WriteLine("0");
                return;
            }

            else
            {
                numbers.RemoveRange(removeLeft, 2 * power + 1);
            }
        }

        Console.WriteLine(numbers.Sum());
    }
}
