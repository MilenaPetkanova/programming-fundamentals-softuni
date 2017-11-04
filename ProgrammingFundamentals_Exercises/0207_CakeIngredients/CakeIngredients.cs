using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0207_CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int counter = 0;

            while (input != "Bake!")
            {
                Console.WriteLine("Adding ingredient {0}.", input);
                counter++;
                input = Console.ReadLine();
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", counter);
        }
    }
}
