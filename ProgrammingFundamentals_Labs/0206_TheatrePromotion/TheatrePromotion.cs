using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0206_TheatrePromotion
{
    class TheatrePromotion
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            int price = 0;

            switch (day)
            {
                case "Weekday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 12;
                    }
                    if (age > 18 && age <= 64)
                    {
                        price = 18;
                    }
                    if (age > 64 && age <= 122)
                    {
                        price = 12;
                    }
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        price = 15;
                    }
                    if (age > 18 && age <= 64)
                    {
                        price = 20;
                    }
                    if (age > 64 && age <= 122)
                    {
                        price = 15;
                    }
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                    }
                    if (age > 18 && age <= 64)
                    {
                        price = 12;
                    }
                    if (age > 64 && age <= 122)
                    {
                        price = 10;
                    }
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
            if (price != 0)
            {
                Console.WriteLine(price + "$");
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}