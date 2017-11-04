using System;

namespace _0214_MagicLetter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());

            char[] combinations = new char[3];
            
            int l1 = (int)letter1;
            int l2 = (int)letter2;
            int l3 = (int)letter3;


            for (int i = l1; i <= l2; i++) //first letter
            {
                if (i != l3)
                {
                    for (int j = l1; j <= l2; j++) //second letter
                    {
                        if (j != l3)
                        {
                            for (int z = l1; z <= l2; z++) //third letter
                            {
                                if (z != l3)
                                {
                                    combinations[0] = (char)i;
                                    combinations[1] = (char)j;
                                    combinations[2] = (char)z;
                                    Console.Write("{0}{1}{2} ", combinations[0], combinations[1], combinations[2]);
                                }
                                else
                                {
                                    continue; //means: stop current iteration, don't exit from loop
                                }
                            }
                        }
                        else
                        {
                            continue; //means: stop current iteration, don't exit from loop
                        }
                    }
                }
                else
                {
                    continue; //means: stop current iteration, don't exit from loop
                }
            }
        }
    }
}
