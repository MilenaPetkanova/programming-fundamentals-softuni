using System;

class Greeteing
{
    static void Main(string[] args)
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        string greeting = $"Hello, {firstName} {lastName}. You are {age} years old.";
        Console.WriteLine(greeting);
    }
}
