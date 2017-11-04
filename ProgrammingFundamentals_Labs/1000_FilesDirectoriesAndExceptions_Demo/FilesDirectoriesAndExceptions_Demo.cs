using System;
using System.IO;

class FilesDirectoriesAndExceptions_Demo
{
    static void Main()
    {
        //Reading Text Files
        string text = File.ReadAllText("file.txt");
        string[] lines = File.ReadAllLines("file.txt");

        //Writing Text Files
        File.WriteAllText("output.txt", "Files are fun :)");

        string[] names = { "peter", "irina", "george", "maria" };
        File.WriteAllLines("output.txt", names);

        File.AppendAllText("output.txt", "\nMore text\n");

        //Inspecting files
        var info = new FileInfo("output.txt");
        Console.WriteLine("File size: {0} bytes", info.Length);
        Console.WriteLine("Created at: {0}", info.CreationTime);
        Console.WriteLine("Path + name: {0}", info.FullName);
        Console.WriteLine("File extension: {0}", info.Extension);

        //Basic Directory Operations
        Directory.CreateDirectory("TestFolder");
        Directory.Delete("TestFolder", true);
        Directory.Move("Test", "New Folder");

        //Listing Directory Contents
        string[] filesInDir = Directory.GetFiles("TestFolder");
        string[] subDirs = Directory.GetDirectories("TestFolder");

    }
}
