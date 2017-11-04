using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

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

        string[] inputTest1 = File.ReadAllLines(@"test files\InputTest1.txt");

        int studentsCount = int.Parse(inputTest1[0]);

        for (int i = 0; i < studentsCount; i++)
        {
            string[] studentInfo = inputTest1[i + 1].Split(' ').ToArray();

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

        File.Delete(@"test files\OutputTest1.txt");
        foreach (var student in studentsBestGrades)
        {
            string newLine = $"{student.Name} -> {student.Average:f2}" + Environment.NewLine;
            File.AppendAllText(@"test files\OutputTest1.txt", newLine);
        }
    }
}
