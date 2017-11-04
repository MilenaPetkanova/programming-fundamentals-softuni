using System;

namespace _0414_IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int decimalInput = int.Parse(Console.ReadLine());

            string hexValue = decimalInput.ToString("X");
            string binaryValue = Convert.ToString(decimalInput, 2);

            Console.WriteLine(hexValue);
            Console.WriteLine(binaryValue);
        }
    }
}
