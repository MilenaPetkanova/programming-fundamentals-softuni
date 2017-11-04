using System;
using System.Collections.Generic;
using System.Linq;

class PhonebookUppgrade
{
    static void Main()
    {
        var phonebook = new SortedDictionary<string, string>();

        var command = Console.ReadLine().Split(' ').ToArray();
        while (command[0] != "END")
        {
            if (command[0] == "A")
            {
                string name = command[1];
                string phone = command[2];
                if (phonebook.ContainsKey(name) == false)
                {
                    phonebook.Add(name, phone);
                }
                else
                {
                    phonebook[name] = phone;
                }
            }

            else if (command[0] == "S")
            {
                string name = command[1];

                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", name);
                }
            }

            else if (command[0] == "ListAll")
            {
                foreach (var contact in phonebook)
                {
                    Console.WriteLine("{0} -> {1}", contact.Key, contact.Value);
                }
            }
            
            command = Console.ReadLine().Split(' ').ToArray();
        }
    }
}

