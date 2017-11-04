using System;

class AdvertisementMessage
{
    static void Main()
    {
        string[] phrases = new string[] { "Excellent product.",
            "Such a great product.", "I always use that product.",
            "Best product of its category.", "Exceptional product.",
            "I can’t live without this product." };
        string[] events = new string[] { "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the messages!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.", "I feel great!" };
        string[] authors = new string[] { "Diana", "Petya",
            "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        string[] cities = new string[] { "Burgas", "Sofia",
            "Plovdiv", "Varna", "Ruse" };

        int nMessages = int.Parse(Console.ReadLine());

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

            Console.WriteLine("{0} {1} {2} - {3}",
                message[0], message[1], message[2], message[3]);
            
        }

    }
}
