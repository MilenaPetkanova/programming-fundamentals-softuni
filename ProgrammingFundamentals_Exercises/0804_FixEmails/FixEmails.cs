using System;
using System.Collections.Generic;
using System.Linq;

class FixEmails
{
    static void Main()
    {
        var emailList = new Dictionary<string, string>();

        string name = Console.ReadLine();
        while (name != "stop")
        {
            var email = Console.ReadLine();

            if (emailList.ContainsKey(name) == false)
            {
                emailList.Add(name, email);
            }

            name = Console.ReadLine();
        }

        var itemsToRemove = emailList
            .Where(f => f.Value.Contains(".us") || f.Value.Contains(".uk"))
            .ToArray();
        foreach (var item in itemsToRemove)
        {
            emailList.Remove(item.Key);
        }
        
        foreach (var contact in emailList)
        {
            Console.WriteLine("{0} -> {1}", contact.Key, contact.Value);
        }
    }
}
