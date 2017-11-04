using System;
using System.Collections.Generic;
using System.Linq;

namespace _0703_SearchForANumbre
{
    class SearchForANumbre
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();

            int[] elements = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();

            int elementsToTake = elements[0];
            int elementsToDelete = elements[1];
            int elementsToSearch = elements[2];

            var taken = nums.Take(elementsToTake).ToList();

            taken.RemoveRange(0, elementsToDelete);

            bool isFound = taken.Any(item => item == elementsToSearch);

            if (isFound)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }   
    }
}
