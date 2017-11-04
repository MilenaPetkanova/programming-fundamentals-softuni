using System;
using System.Globalization;

class SoftUniCoffeeOrders
{
    static void Main()
    {
        int ordersCount = int.Parse(Console.ReadLine());

        decimal totalPrice = 0;

        for (int i = 0; i < ordersCount; i++)
        {
            decimal pricePerCap = decimal.Parse(Console.ReadLine());
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            long capsCount = long.Parse(Console.ReadLine());

            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

            decimal price = daysInMonth * capsCount * pricePerCap;
            Console.WriteLine($"The price for the coffee is: ${price:f2}");

            totalPrice += price;
        }

        Console.WriteLine($"Total: ${totalPrice:f2}");
    }
}
