using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class FixEmails
{
    static void Main()
    {
        var emailList = new Dictionary<string, string>();

        string[] inputLines = File.ReadAllLines(@"test files\InputTest1.txt");

        for (int i = 0; i < inputLines.Length - 1; i += 2)
        {
            string name = inputLines[i];
            string email = inputLines[i + 1];
            if (emailList.ContainsKey(name) == false)
            {
                emailList.Add(name, email);
            }
        }

        var itemsToRemove = emailList
            .Where(f => f.Value.Contains(".us") || f.Value.Contains(".uk"))
            .ToArray();
        foreach (var item in itemsToRemove)
        {
            emailList.Remove(item.Key);
        }

        string path = @"test files\OutputTest1.txt";
        File.Delete(path);
        foreach (var contact in emailList)
        {
            string newLine = $"{contact.Key} -> {contact.Value}" + Environment.NewLine;
            File.AppendAllText(path, newLine);
        }
    }
}
