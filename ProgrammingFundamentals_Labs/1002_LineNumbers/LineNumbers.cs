using System;
using System.IO;
using System.Linq;

class LineNumbers
{
    static void Main()
    {
        string[] allLines = File.ReadAllLines("input.txt");
        var numberedLines = allLines
            .Select((line, index) => $"{index + 1}. {line}");
        File.WriteAllLines("output.txt", numberedLines);

        //Same result:
        //string[] allLines = File.ReadAllLines("Input.txt");
        //for (int i = 0; i < allLines.Length; i++)
        //{
        //    File.AppendAllText("output.txt", 
        //        $"{i+1}. {allLines[i]}" + Environment.NewLine);
        //}
    }
}
