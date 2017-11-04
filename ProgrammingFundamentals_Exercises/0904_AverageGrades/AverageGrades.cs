using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public double[] Grades { get; set; }
    public double Average => Grades.Average();
    //Same result:
   // public double Average { get { return Grades.Average(); } }
}

class AverageGrades
{
    static void Main()
    {
        var allStudents = new List<Student>();

        int studentsCount = int.Parse(Console.ReadLine());

        //Same result:
        //while (n-- > 0) { ... }
        for (int i = 0; i < studentsCount; i++)
        {
            string[] studentInfo = Console.ReadLine().Split(' ').ToArray();
            string studentName = studentInfo[0];
            double[] studentGrades = studentInfo.Skip(1)
                .Select(double.Parse).ToArray();

            var newStudent = new Student
            {
                Name = studentName,
                Grades = studentGrades
            };

            allStudents.Add(newStudent);
        }

        var studentsBestGrades = allStudents
            .Where(a => a.Average >= 5.00)
            .OrderBy(n => n.Name)
            .ThenByDescending(g => g.Average)
            .ToList();

        foreach (var student in studentsBestGrades)
        {
            Console.WriteLine($"{student.Name} -> {student.Average:f2}");
        }
            
    }
}

