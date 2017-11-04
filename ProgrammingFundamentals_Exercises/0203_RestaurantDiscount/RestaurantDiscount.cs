namespace _0203_RestaurantDiscount
{
    using System;
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            double priceTotal = 0.00;
            string hallName = "";
            int priceSmallHall = 2500;
            int priceTerrace = 5000;
            int priceGreatHall = 7500;
            int priceNormalPac = 500;
            int priceGoldPac = 750;
            int pricePlatinumPac = 1000;
            double discountNormalPac = 0.95;
            double discountGoldPac = 0.90;
            double discountPlatinumlPac = 0.85;

            if (groupSize > 0 && groupSize <= 50)
            {
                hallName = "Small Hall";
                priceTotal += priceSmallHall;
                switch (package)
                {
                    case "Normal":
                        priceTotal += priceNormalPac;
                        priceTotal *= discountNormalPac;
                        break;
                    case "Gold":
                        priceTotal += priceGoldPac;
                        priceTotal *= discountGoldPac;
                        break;
                    case "Platinum":
                        priceTotal += pricePlatinumPac;
                        priceTotal *= discountPlatinumlPac;
                        break;
                }
                priceTotal /= groupSize;
                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:0.00}$", priceTotal);
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hallName = "Terrace";
                priceTotal += priceTerrace;
                switch (package)
                {
                    case "Normal":
                        priceTotal += priceNormalPac;
                        priceTotal *= discountNormalPac;
                        break;
                    case "Gold":
                        priceTotal += priceGoldPac;
                        priceTotal *= discountGoldPac;
                        break;
                    case "Platinum":
                        priceTotal += pricePlatinumPac;
                        priceTotal *= discountPlatinumlPac;
                        break;
                }
                priceTotal /= groupSize;
                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:0.00}$", priceTotal);
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hallName = "Great Hall";
                priceTotal += priceGreatHall;
                switch (package)
                {
                    case "Normal":
                        priceTotal += priceNormalPac;
                        priceTotal *= discountNormalPac;
                        break;
                    case "Gold":
                        priceTotal += priceGoldPac;
                        priceTotal *= discountGoldPac;
                        break;
                    case "Platinum":
                        priceTotal += pricePlatinumPac;
                        priceTotal *= discountPlatinumlPac;
                        break;
                }
                priceTotal /= groupSize;
                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:0.00}$", priceTotal);
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
