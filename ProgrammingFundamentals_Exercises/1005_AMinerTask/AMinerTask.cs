using System;
using System.Collections.Generic;
using System.IO;

class AMinerTask
{
    static void Main()
    {
        var allRecources = new Dictionary<string, int>();

        string[] inputLines = File.ReadAllLines(@"test files\InputTest1.txt");

        for (int i = 0; i < inputLines.Length - 1; i+=2)
        {
            string resource = inputLines[i];
            int quantity = int.Parse(inputLines[i + 1]);

            if (!allRecources.ContainsKey(resource))
            {
                allRecources.Add(resource, quantity);
            }
            else
            {
                allRecources[resource] += quantity;
            }
        }

        string path = @"test files\OutputTest1.txt";
        File.Delete(path);
        foreach (var resource in allRecources)
        {
            string newLine = $"{resource.Key} -> {resource.Value}" + Environment.NewLine;
            File.AppendAllText(path, newLine);
        }
    }
}
