using System;
using System.Linq;

class Ladybugs
{
    static void Main()
    {

        int fieldSize = int.Parse(Console.ReadLine());
        int[] ladybugs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] field = new int[fieldSize];

        for (int i = 0; i < ladybugs.Length; i++)
        {
            if (ladybugs[i] >= 0 && ladybugs[i] < field.Length)
            {
                field[ladybugs[i]] = 1;
            } 
        }

        string commandLine = Console.ReadLine();

        while (commandLine != "end")
        {
            string[] command = commandLine.Split(' ').ToArray();

            long ladybugIndex = long.Parse(command[0]);
            string direction = command[1];
            int flyLength = int.Parse(command[2]);

            if (ladybugIndex >= 0 && ladybugIndex < field.Length)
            {
                if (field[ladybugIndex] == 1)
                {
                    field[ladybugIndex] = 0;
                    if (direction == "left")
                    {
                        field = FlyLeftField(field, ladybugIndex, flyLength);
                    }
                    else if (direction == "right")
                    {
                        field = FlyRightField(field, ladybugIndex, flyLength);
                    }
                }
            }

            commandLine = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", field));
    }

    private static int[] FlyLeftField(int[] field, long ladybugIndex, int flyLength)
    {
        long newPosition = ladybugIndex - flyLength;

        if (newPosition < 0 || newPosition > field.Length - 1)
        {
            return field;
        }
        else if (field[newPosition] == 1)
        {
            return FlyLeftField(field, newPosition, flyLength);
        }
        else
        {
            field[newPosition] = 1;
        }
        return field;

    }

    private static int[] FlyRightField(int[] field, long ladybugIndex, int flyLength)
    {
        long newPosition = ladybugIndex + flyLength;

        if (newPosition >= 0 && newPosition < field.Length)
        {
            if (field[newPosition] == 1)
            {
                return FlyRightField(field, newPosition, flyLength);
            }
            else
            {
                field[newPosition] = 1;
               
            }
        }

        return field;

    }
}
