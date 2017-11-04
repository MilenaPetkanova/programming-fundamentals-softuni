using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0202_ChooseDrink._2._0
{
    class ChooseDrink2
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = 0.00;

            switch (profession)
            {
                case "Athlete":
                    price = 0.70 * quantity;
                    Console.WriteLine("The {0} has to pay {1:0.00}.", profession, price);
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = 1.00 * quantity;
                    Console.WriteLine("The {0} has to pay {1:0.00}.", profession, price);
                    break;
                case "SoftUni Student":
                    price = 1.70 * quantity;
                    Console.WriteLine("The {0} has to pay {1:0.00}.", profession, price);
                    break;
                default:
                    price = 1.20 * quantity;
                    Console.WriteLine("The {0} has to pay {1:0.00}.", profession, price);
                    break;
            }
        }
    }
}
