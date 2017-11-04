using System;

namespace _0413_VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            int ascciInput = (int)input;
            
            if (ascciInput >= 48 && ascciInput <= 57)
            {
                Console.WriteLine("digit");
            }
            else if (ascciInput == 97 || ascciInput == 101 ||
                ascciInput == 105 || ascciInput == 111 || ascciInput == 117)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
