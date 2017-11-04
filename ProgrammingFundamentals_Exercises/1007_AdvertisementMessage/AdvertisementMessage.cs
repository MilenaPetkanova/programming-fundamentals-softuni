using System;
using System.Collections.Generic;
using System.IO;

class AdvertisementMessage
{
    static void Main()
    {
        string[] phrases = File.ReadAllLines(@"test files\Phrases.txt");
        string[] events = File.ReadAllLines(@"test files\Events.txt");
        string[] authors = File.ReadAllLines(@"test files\Author.txt");
        string[] cities = File.ReadAllLines(@"test files\Cities.txt");

        int nMessages = int.Parse(File.ReadAllText(@"test files\InputTest1.txt"));

        File.Delete(@"test files\OutputTest1.txt");

        Random rnd = new Random();

        for (int i = 0; i < nMessages; i++)
        {
            int phraseIndex = rnd.Next(0, phrases.Length);
            int eventIndex = rnd.Next(0, events.Length);
            int authorIndex = rnd.Next(0, authors.Length);
            int cityIndex = rnd.Next(0, cities.Length);

            string[] message = new string[4];
            message[0] = phrases[phraseIndex];
            message[1] = events[eventIndex];
            message[2] = authors[authorIndex];
            message[3] = cities[cityIndex];

            string newLine = $"{message[0]} {message[1]} {message[2]} - {message[3]}"
                + Environment.NewLine;
            File.AppendAllText(@"test files\OutputTest1.txt", newLine);
        }

    }
}
