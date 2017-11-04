using System;

namespace _0405_BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            bool inputBool = Convert.ToBoolean(Console.ReadLine());

            if (inputBool == true)
            {
                Console.WriteLine("Yes");
            }
            else 
            {
                Console.WriteLine("No");
            }
        }
    }
}
