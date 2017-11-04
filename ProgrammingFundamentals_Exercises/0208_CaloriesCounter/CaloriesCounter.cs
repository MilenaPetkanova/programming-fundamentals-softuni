using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0208_CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int caloriesTotal = 0;

            for (int i = 0; i < n; i++)
            {
                var ingredient = Console.ReadLine();
                ingredient = ingredient.ToLower();

                if (ingredient == "cheese")
                {
                    caloriesTotal += 500;
                }
                else if (ingredient == "tomato sauce")
                {
                    caloriesTotal += 150;
                }
                else if (ingredient == "salami")
                {
                    caloriesTotal += 600;
                }
                else if (ingredient == "pepper")
                {
                    caloriesTotal += 50;
                }
            }
            Console.WriteLine("Total calories: {0}", caloriesTotal);
        }
    }
}
