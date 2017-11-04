namespace _0204_Hotel
{
    using System;
    class Hotel
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;
            double discountStudio = 0.95;
            double discountDouble = 0.90;
            double discountSuite = 0.85;

            if (month == "May" || month == "October")
            {
                priceStudio += 50 * nightsCount;
                priceDouble += 65 * nightsCount;
                priceSuite += 75 * nightsCount;
                if (nightsCount > 7)
                {
                    priceStudio *= discountStudio;
                    if (month == "October")
                    {
                        priceStudio -= 50 * discountStudio;
                    }
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio += 60 * nightsCount;
                priceDouble += 72 * nightsCount;
                priceSuite += 82 * nightsCount;
                if (month == "June" && nightsCount > 14)
                {
                    priceDouble *= discountDouble;
                }
                else if (month == "September" && nightsCount > 14)
                {
                    priceDouble *= discountDouble;
                }
                else if (month == "September" && nightsCount > 7)
                {
                    priceStudio -= 60;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                priceStudio += 68 * nightsCount;
                priceDouble += 77 * nightsCount;
                priceSuite += 89 * nightsCount;
                if (nightsCount > 14)
                {
                    priceSuite *= discountSuite;
                }
            }
            Console.WriteLine("Studio: {0:0.00} lv.", priceStudio);
            Console.WriteLine("Double: {0:0.00} lv.", priceDouble);
            Console.WriteLine("Suite: {0:0.00} lv.", priceSuite);
        }
    }
}
