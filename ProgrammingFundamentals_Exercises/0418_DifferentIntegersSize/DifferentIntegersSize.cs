using System;
using System.Numerics;

namespace _0418_DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());

            sbyte sbyteMaxValue = sbyte.MaxValue;
            sbyte sbyteMinValue = sbyte.MinValue;
            byte byteMaxValue = byte.MaxValue;
            byte byteMinValue = byte.MinValue;
            short shortMaxValue = short.MaxValue;
            short shortMinValue = short.MinValue;
            ushort ushortMaxValue = ushort.MaxValue;
            ushort ushortMinValue = ushort.MinValue;
            int intMaxValue = int.MaxValue;
            int intMinValue = int.MinValue;
            uint uintMaxValue = uint.MaxValue;
            uint uintMinValue = uint.MinValue;
            long longMaxValue = long.MaxValue;
            long longMinValue = long.MinValue;

            if (input >= longMinValue && input <= longMaxValue)
            {
                Console.WriteLine($"{input} can fit in:");
                if (input >= sbyteMinValue && input <= sbyteMaxValue)
                {
                    Console.WriteLine($"* sbyte");
                }
                if (input >= byteMinValue && input <= byteMaxValue)
                {
                    Console.WriteLine($"* byte");
                }
                if (input >= shortMinValue && input <= shortMaxValue)
                {
                    Console.WriteLine($"* short");
                }
                if (input >= ushortMinValue && input <= ushortMaxValue)
                {
                    Console.WriteLine($"* ushort");
                }
                if (input >= intMinValue && input <= intMaxValue)
                {
                    Console.WriteLine($"* int");
                }
                if (input >= uintMinValue && input <= uintMaxValue)
                {
                    Console.WriteLine($"* uint");
                }
                if (input >= longMinValue && input <= longMaxValue)
                {
                    Console.WriteLine($"* long");
                }
            }
            else
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
