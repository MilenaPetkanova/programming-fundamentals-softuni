using System;

namespace _0409_ReverseCharacters
{
    class ReverseCharacters
    {
        static void Main(string[] args)
        {
            char[] charArray = new char[3];

            charArray[0] = char.Parse(Console.ReadLine());
            charArray[1] = char.Parse(Console.ReadLine());
            charArray[2] = char.Parse(Console.ReadLine());
         
            Console.WriteLine("{0}{1}{2}", charArray[2], charArray[1], charArray[0]);
        }
    }
}
