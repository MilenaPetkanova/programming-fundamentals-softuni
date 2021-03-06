﻿using System;

class BlankReceipt
{
    static void Main()
    {
        PrintBlankReceipt();
    }

    static void PrintBlankReceipt()
    {
        PrintHeader();
        PrintBody();
        PrintFooter();
    }

    private static void PrintHeader()
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine(new string('-', 30));
    }

    private static void PrintBody()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
    }

    private static void PrintFooter()
    {
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("© SoftUni");
    }
}
