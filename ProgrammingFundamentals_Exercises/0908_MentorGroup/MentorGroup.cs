using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Student
{
    public List<DateTime> Dates { get; set; }
    public List<string> Comments { get; set; }
}

class MentorGroup
{
    static void Main()
    {
        var allStudents = new Dictionary<string, Student>();

        string inputStudentDates = Console.ReadLine();
        while (inputStudentDates != "end of dates")
        {
            string[] studentDatesArgs = inputStudentDates
                .Split(' ', ',').ToArray();

            if (studentDatesArgs.Length == 1)
            {
                allStudents.Add(studentDatesArgs[0], new Student());
                allStudents[studentDatesArgs[0]].Comments = new List<string>();
                inputStudentDates = Console.ReadLine();
                continue;
            }

            string studentName = studentDatesArgs[0];
            string[] studentDates = studentDatesArgs
                .Skip(1).ToArray();

            List<DateTime> datesAttended = new List<DateTime>();
            foreach (var date in studentDates)
            {
                DateTime currentDate = DateTime.ParseExact(date, "dd/MM/yyyy",
                    CultureInfo.InvariantCulture);
                datesAttended.Add(currentDate);
            }

            var currentStudent = new Student();

            if (!allStudents.ContainsKey(studentName))
            {
                currentStudent.Dates = new List<DateTime>();
                currentStudent.Comments = new List<string>();
                currentStudent.Dates.AddRange(datesAttended);
                allStudents.Add(studentName, currentStudent);
            }
            else
            {
                allStudents[studentName].Dates.AddRange(datesAttended);
            }

            inputStudentDates = Console.ReadLine();
        }

        string inputStudentComments = Console.ReadLine();
        while (inputStudentComments != "end of comments")
        {
            string[] studentCommentsArgs = inputStudentComments.Split('-').ToArray();

            if (studentCommentsArgs.Length == 1)
            {
                inputStudentComments = Console.ReadLine();
                continue;
            }

            string studentName = studentCommentsArgs[0];
            string comment = studentCommentsArgs[1];

            if (allStudents.ContainsKey(studentName))
            {
                allStudents[studentName].Comments.Add(comment);
            }

            inputStudentComments = Console.ReadLine();
        }

        foreach (var student in allStudents.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{student.Key}");

            try
            {
                Console.WriteLine("Comments:");
                foreach (var comment in student.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
            }
            catch (Exception)
            {
                Console.Write("");
            }

            try
            {
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Value.Dates.OrderBy(x => x.Date))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
            catch (Exception)
            {
                Console.Write("");
            }
        }
    }
}
