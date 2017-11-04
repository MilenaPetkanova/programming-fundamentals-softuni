using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0209_CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            bool isNumeric = true;
            int value;
            int counter = 0;
            
            while (isNumeric == true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out value))
                {
                    counter++;
                }
                else
                {
                    isNumeric = false;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
