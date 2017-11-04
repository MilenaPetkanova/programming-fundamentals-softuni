using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Root
{
    public string RootName { get; set; }
    public SortedDictionary<string, long> FilesSizes { get; set; }
}

class Files
{
    static void Main()
    {
        var allRoots = new SortedDictionary<string, Root>();

        int countFiles = int.Parse(Console.ReadLine());
        for (int i = 0; i < countFiles; i++)
        {
            string newPath = Console.ReadLine();
            string pattern = @"(?<root>.*?)\\((.*)\\)?(?<file>.*);(?<size>\d+)";

            var matchPath = Regex.Match(newPath, pattern);

            string rootName = matchPath.Groups["root"].ToString();
            string file = matchPath.Groups["file"].ToString();
            long size = long.Parse(matchPath.Groups["size"].ToString());

            Root root = new Root()
            {
                RootName = rootName,
                FilesSizes = new SortedDictionary<string, long>()
            };

            if (!allRoots.ContainsKey(rootName))
            {
                allRoots.Add(rootName, root);
                root.FilesSizes.Add(file, size);
            }
            else
            {
                if (!allRoots[rootName].FilesSizes.ContainsKey(file))
                {
                    allRoots[rootName].FilesSizes.Add(file, size);
                }
                else
                {
                    allRoots[rootName].FilesSizes[file] = size;
                }
            }

        }

        string[] query = Console.ReadLine().Split(' ').ToArray();
        string queryExtension = query[0];
        string queryRoot = query[2];

        bool containsFileInRoot = false;

        foreach (var root in allRoots.Keys.Where(x => x == queryRoot))
        {
            foreach (var fileInRoot in allRoots[root].FilesSizes.OrderByDescending(x => x.Value))
            {
                string filePattern = @"(.*)\.([\w]+)";
                Match fileMatch = Regex.Match(fileInRoot.Key, filePattern);

                string fileName = fileMatch.Groups[1].ToString();
                string fileExtension = fileMatch.Groups[2].ToString();

                if (fileExtension == queryExtension)
                {
                    Console.WriteLine("{0} - {1} KB",fileInRoot.Key, fileInRoot.Value);
                    containsFileInRoot = true;
                }
            }
        }

        if (containsFileInRoot == false)
        {
            Console.WriteLine("No");
        }

    }
}
