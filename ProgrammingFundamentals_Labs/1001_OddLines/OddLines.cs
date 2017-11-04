using System;
using System.IO;
using System.Linq;

class OddLines
{
    static void Main()
    {
        string[] allLines = File.ReadAllLines("Input.txt");
        var oddLines = allLines.Where((line, index) => index % 2 == 1);
        File.WriteAllLines("odd-lines.txt", oddLines);

        //Same result:
        //string[] allLines = File.ReadAllLines("Input.txt");
        //for (int i = 0; i < allLines.Length; i++)
        //{
        //    if (i % 2 == 1)
        //    {
        //        File.AppendAllText("output.txt", 
        //            $"{allLines[i]}" + Environment.NewLine);
        //    } 
        //}

    }
}
