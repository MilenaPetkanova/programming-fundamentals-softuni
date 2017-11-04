using System;

namespace _0605_CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().Replace(" ", "");
            char[] firstCharArr = first.ToCharArray();

            string second = Console.ReadLine().Replace(" ", "");
            char[] secondCharArr = second.ToCharArray();

            int shorter = Math.Min(firstCharArr.Length, secondCharArr.Length);

            for (int i = 0; i < shorter; i++)
            {
                if (firstCharArr[i] == secondCharArr[i])
                {
                    if (i == shorter - 1)
                    {
                        if (firstCharArr.Length >= secondCharArr.Length)
                        {
                            PrintCharArray(secondCharArr);
                            PrintCharArray(firstCharArr);
                        }
                        else
                        {
                            PrintCharArray(firstCharArr);
                            PrintCharArray(secondCharArr);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (firstCharArr[i] <= secondCharArr[i])
                {
                    PrintCharArray(firstCharArr);
                    PrintCharArray(secondCharArr);
                    break;
                }
                else if (firstCharArr[i] > secondCharArr[i])
                {
                    PrintCharArray(secondCharArr);
                    PrintCharArray(firstCharArr);
                    break;
                }
            }
        }

        private static void PrintCharArray(char[] charArr)
        {
            for (int i = 0; i < charArr.Length; i++)
            {
                Console.Write("{0}", (char)charArr[i]);
            }
            Console.WriteLine();
        }
    }
}
