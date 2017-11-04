using System;
using System.Collections.Generic;

class HornetComm
{
    static void Main(string[] args)
    {
        List<string> messages = new List<string>();
        List<string> broadcast = new List<string>();

        string input = Console.ReadLine();

        while (input != "Hornet is Green")
        {
            var tokens = input.Split(new string[] { " <-> " }, StringSplitOptions.None);

            if (tokens.Length != 2)
            {
                input = Console.ReadLine();
                continue;
            }
            char[] firstQuery = tokens[0].ToCharArray();
            char[] secondQuery = tokens[1].ToCharArray();

            bool isPrivateMessage = true;
            bool isBroadcast = false;

            for (int i = 0; i < firstQuery.Length; i++)
            {
                bool isDigit = Char.IsDigit(firstQuery[i]);
                if (isDigit == false)
                {
                    isPrivateMessage = false;
                    break;
                }
            }

            for (int i = 0; i < firstQuery.Length; i++)
            {
                bool isDigit = Char.IsDigit(firstQuery[i]);
                if (isDigit == true)
                {
                    isBroadcast = false;
                    break;
                }
                else
                {
                    isBroadcast = true;
                }
            }

            for (int i = 0; i < secondQuery.Length; i++)
            {
                bool isDigitOrLetter = Char.IsLetterOrDigit(secondQuery[i]);
                if (isDigitOrLetter == false)
                {
                    isBroadcast = false;
                    isPrivateMessage = false;
                    break;
                }
            }

            if (isPrivateMessage == true)
            {
                Array.Reverse(firstQuery);
                string firstQueryStr = new string(firstQuery);
                string secondQueryStr = new string(secondQuery);
                string messageStr = firstQueryStr + " -> " + secondQueryStr;
                messages.Add(messageStr);
            }

            if (isBroadcast == true)
            {
                for (int i = 0; i < secondQuery.Length; i++)
                {
                    bool isLetter = char.IsLetter(secondQuery[i]);
                    bool isUpper = char.IsUpper(secondQuery[i]);
                    bool isLower = char.IsLower(secondQuery[i]);
                    if (isLetter && isUpper)
                    {
                        secondQuery[i] = char.ToLower(secondQuery[i]);
                    }
                    else if (isLetter && isLower)
                    {
                        secondQuery[i] = char.ToUpper(secondQuery[i]);
                    }
                }
                string firstQueryStr = new string(firstQuery);
                string secondQueryStr = new string(secondQuery);
                string broadcastStr = secondQueryStr + " -> " + firstQueryStr;
                broadcast.Add(broadcastStr);
            }

            input = Console.ReadLine();
        }

        Console.WriteLine("Broadcasts:");
        if (broadcast.Count != 0)
        {
            foreach (string line in broadcast)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("None");
        }

        Console.WriteLine("Messages:");
        if (messages.Count != 0)
        {
            foreach (string line in messages)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("None");
        }
    }
}
