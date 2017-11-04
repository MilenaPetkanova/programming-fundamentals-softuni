using System;

namespace _0102_RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            var width = float.Parse(Console.ReadLine());
            var height = float.Parse(Console.ReadLine());

            // First solution
            var area = width * height;
            Console.WriteLine(String.Format("{0:0.00}", area));

            // Second solution
            //var result = area.ToString("0.00");
            //Console.WriteLine(result);

            // Third solution:
            //var area = width * height;
            //Console.WriteLine("{0:f2}", area);
        }
    }
}
