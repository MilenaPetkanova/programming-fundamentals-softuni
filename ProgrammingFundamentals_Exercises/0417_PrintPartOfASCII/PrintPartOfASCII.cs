using System;

namespace _0417_PrintPartOfASCII
{
    class PrintPartOfASCII
    {
        static void Main(string[] args)
        {
            short startIndex = short.Parse(Console.ReadLine());
            short lastIndex = short.Parse(Console.ReadLine());

            for (short i = startIndex; i <= lastIndex; i++)
            {
                char currChar = (char)i;
                Console.Write($"{currChar} ");
            }
            Console.WriteLine();
        }
    }
}
