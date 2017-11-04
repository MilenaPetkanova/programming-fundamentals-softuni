using System;

namespace _0502_MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int largest = GetMax(firstNumber, secondNumber);
            largest = GetMax(largest, thirdNumber);
            Console.WriteLine(largest);
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}
