using System.IO;

class FolderSize
{
    static void Main()
    {
        string[] filesInDir = Directory.GetFiles("TestFolder");

        double totalSize = 0;

        foreach (var file in filesInDir)
        {
            var fileInfo = new FileInfo(file);
            totalSize += fileInfo.Length;
        }

        totalSize = totalSize / 1024 / 1024;

        File.WriteAllText("output.txt", totalSize.ToString());
    }
}
