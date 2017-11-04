    namespace _0208_SumOfOddNumbers
    {
        using System;
        class SumOfOddNumbers
        {
            static void Main(string[] args)
            {
                var n = int.Parse(Console.ReadLine());
                int sum = 0;

                for (int i = 1; i < n*2; i += 2)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
