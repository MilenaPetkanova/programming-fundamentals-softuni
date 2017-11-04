using System;
using System.Collections.Generic;
using System.Linq;

class StringsAndTextProcessing
{
    static void Main()
    {
        ////String are immutable
        //string str = "Hello, C#";
        //let ch = str[2]; // OK
        //str[2] = 'a'; // Error!

        ////String are UNICODE
        //string greeting = "îăşâţ"; 
        //Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Console.WriteLine(greeting);

        ////Converting a string from and to a char array:
        //string str = new String(new char[] { 's', 't', 'r' });
        //char[] charArr = str.ToCharArray(); // ['s', 't', 'r']
        //Console.WriteLine(str);

        ////Case-insensitive string comparison:
        //int result = string.Compare(str1, str2, true);
        // result == 0 if str1 equals str2
        // result < 0 if str1 is before str2
        // result > 0 if str1 is after str2

        ////Case-sensitive string comparison:
        //int result = string.Compare(str1, str2, false);

        //string email = "vasko@gmail.org";
        //int firstIndex = email.IndexOf("@"); // 5
        //int secondIndex = email.IndexOf("a", 2); // 8
        //int notFound = email.IndexOf("/"); // -1

        //string verse = "To be or not to be…";
        //int lastIndex = verse.LastIndexOf("be"); // 16

        //IndexOf
        const string value = "Your dog is cute.";
        if (value.IndexOf("dog") != -1)
        {
            Console.WriteLine("string contains dog!");
        }

        string s = "I have a cat";
        // Loop through all instances of the letter a.
        int counter = 0;
        int i = 0;
        while ((i = s.IndexOf('a', i)) != -1)
        {
            // Print out the substring.
            Console.WriteLine(s.Substring(i));

            // Increment the index.
            counter++;
            i++;
        }

    }
}
