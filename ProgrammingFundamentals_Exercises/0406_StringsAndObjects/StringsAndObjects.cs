using System;

namespace _0406_StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";

            object helloWorld = hello + " " + world;
            string output = (string)helloWorld;

            Console.WriteLine(output);

        }
    }
}
