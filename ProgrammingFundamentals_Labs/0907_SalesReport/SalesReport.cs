using System;
using System.Collections.Generic;
using System.Linq;

class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
}

class SalesReport
{
    static void Main()
    {
        Sale[] sales = ReadSales();

        //Approach I -> Dictionary{town -> sales} 
        var totalSales = new SortedDictionary<string, decimal>();
        foreach (var sale in sales)
        {
            if (!totalSales.ContainsKey(sale.Town))
            {
                totalSales.Add(sale.Town, sale.Price * sale.Quantity);
            }
            else
            {
                totalSales[sale.Town] += sale.Price * sale.Quantity;
            }
        }
        PrintTotalSales(totalSales);

        //Approach II -> LINQ
        var towns = sales
            .Select(s => s.Town)
            .Distinct()
            .OrderBy(t => t).ToList();
        foreach (string town in towns)
        {
            var salesByTown = sales
              .Where(s => s.Town == town)
              .Select(s => s.Price * s.Quantity);

            Console.WriteLine("{0} -> {1:f2}", town, salesByTown.Sum());
        }

    }

    private static void PrintTotalSales(SortedDictionary<string, decimal> totalSales)
    {

        foreach (var sale in totalSales)
        {
            Console.WriteLine("{0} -> {1:f2}", sale.Key, sale.Value);
        }
    }

    private static Sale[] ReadSales()
    {
        int n = int.Parse(Console.ReadLine());

        Sale[] sales = new Sale[n];
        for (int i = 0; i < n; i++)
        {
            sales[i] = ReadSale();
        }
        return sales;
    }

    private static Sale ReadSale()
    {
        var saleArgs = Console.ReadLine().Split(' ').ToArray();
        Sale sale = new Sale();
        sale.Town = saleArgs[0].ToString();
        sale.Product = saleArgs[1].ToString();
        sale.Price = decimal.Parse(saleArgs[2]);
        sale.Quantity = decimal.Parse(saleArgs[3]);
        return sale;
    }
}
