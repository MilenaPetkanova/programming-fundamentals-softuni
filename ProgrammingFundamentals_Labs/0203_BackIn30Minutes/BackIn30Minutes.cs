using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0203_BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                minutes -= 60;
                hours++;
            }

            if (hours > 23)
            {
                hours = 0;
            }

            Console.WriteLine("{0}:{1:D2}", hours, minutes);
        }
    }
}
