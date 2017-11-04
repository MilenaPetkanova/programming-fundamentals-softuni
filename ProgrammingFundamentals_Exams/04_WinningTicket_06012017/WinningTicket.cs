using System;
using System.Linq;
using System.Text.RegularExpressions;

class WinningTicket
{
    static void Main()
    {
        string[] input = Console.ReadLine()
            .Split(new char[] {',', ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        foreach (var ticket in input)
        {
            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
                return;
            }

            else if (Regex.IsMatch(ticket, @"([@]{20})")
                    || Regex.IsMatch(ticket, @"([#]{20})")
                    || Regex.IsMatch(ticket, @"([$]{20})")
                    || Regex.IsMatch(ticket, @"([/^]{20})"))
            {
                Console.WriteLine(@"ticket ""{0}"" - 10{1} Jackpot!",
                    ticket, ticket.First());
            }

            else if (Regex.IsMatch(ticket, @"([@$#^]{6,9})(.*?)?\1"))
            {
                var match = Regex.Match(ticket, @"[@$#^]{6,9}");
                int matchesCounter = match.Length;

                Console.WriteLine(@"ticket ""{0}"" - {1}{2}",
                    ticket, matchesCounter, ticket.ElementAt(5));
            }

            else
            {
                Console.WriteLine(@"ticket ""{0}"" - no match", ticket);
            }
        }
    }
}
