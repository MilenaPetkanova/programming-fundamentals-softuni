﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.IO;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string ISBN { get; set; }
    public decimal Price { get; set; }
}

class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}

class BookLibrary
{
    static void Main()
    {
        string[] input = File.ReadAllLines(@"test files\input.txt");

        Library library = new Library
        {
            Name = "",
            Books = new List<Book>()
        };

        int bookCounter = int.Parse(input[0]);

        for (int i = 0; i < bookCounter; i++)
        {
            string[] bookArgs = input[i + 1].Split(' ').ToArray();

            Book currentBook = new Book
            {
                Title = bookArgs[0],
                Author = bookArgs[1],
                Publisher = bookArgs[2],
                ReleaseDate = DateTime.ParseExact(bookArgs[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN = bookArgs[4],
                Price = decimal.Parse(bookArgs[5])
            };

            library.Books.Add(currentBook);
        }

        var orderedLibrary = library.Books
            .GroupBy(x => x.Author)
            .Select(x => new
            {
                Author = x.Key,
                Price = x.Sum(y => y.Price)
            })
            .OrderByDescending(x => x.Price)
            .ThenBy(x => x.Author)
            .ToList();

        File.Delete(@"test files\output.txt");
        foreach (var author in orderedLibrary)
        {
            string newLine = $"{author.Author} -> {author.Price:f2}" + Environment.NewLine;
            File.AppendAllText(@"test files\output.txt", newLine);
        }

    }
}
