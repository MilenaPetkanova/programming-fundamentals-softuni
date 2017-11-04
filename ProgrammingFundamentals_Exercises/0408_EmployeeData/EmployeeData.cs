using System;

namespace _0408_EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = null;
            byte age;
            char gender;
            string personalID = null;
            int employeeNumber;

            firstName = "Amanda";
            lastName = "Jonson";
            age = 27;
            gender = 'f';
            personalID = "8306112507";
            employeeNumber = 27563571;

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalID}");
            Console.WriteLine($"Unique Employee number: {employeeNumber}");           
        }
    }
}
