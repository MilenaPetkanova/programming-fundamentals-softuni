using System;
using System.Collections.Generic;

class MinerTask
{
    static void Main()
    {
        var allResources = new Dictionary<string, int>();

        string resource = Console.ReadLine();
        while (resource != "stop")
        {
            int quantity = int.Parse(Console.ReadLine());

            if (allResources.ContainsKey(resource))
            {
                allResources[resource] += quantity;
            }
            else
            {
                allResources.Add(resource, quantity);
            }

            resource = Console.ReadLine();
        }

        foreach (var rsrc in allResources)
        {
            Console.WriteLine("{0} -> {1}", rsrc.Key, rsrc.Value);
        }

    }
}
