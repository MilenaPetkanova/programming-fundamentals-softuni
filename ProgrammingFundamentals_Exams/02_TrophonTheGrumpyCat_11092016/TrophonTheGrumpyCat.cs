using System;
using System.Linq;

class TrophonTheGrumpyCat
{
    static void Main()
    {
        int[] priceRatings = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int entryPoint = int.Parse(Console.ReadLine());
        string itemsType = Console.ReadLine();
        string ratingType = Console.ReadLine();

        long sumLeft = 0;
        long sumRight = 0;

        for (int i = 0; i < entryPoint; i++)
        {
            if (itemsType == "cheap")
            {
                if (priceRatings[i] < priceRatings[entryPoint])
                {
                    if (ratingType == "positive")
                    {
                        if (priceRatings[i] > 0)
                        {
                            sumLeft += priceRatings[i];
                        }
                    }
                    else if (ratingType == "negative")
                    {
                        if (priceRatings[i] < 0)
                        {
                            sumLeft += priceRatings[i];
                        }
                    }
                    else if (ratingType == "all")
                    {
                        sumLeft += priceRatings[i];
                    }
                }
            }

            else if (itemsType == "expensive")
            {
                if (priceRatings[i] >= priceRatings[entryPoint])
                {
                    if (ratingType == "positive")
                    {
                        if (priceRatings[i] > 0)
                        {
                            sumLeft += priceRatings[i];
                        }
                    }
                    else if (ratingType == "negative")
                    {
                        if (priceRatings[i] < 0)
                        {
                            sumLeft += priceRatings[i];
                        }
                    }
                    else if (ratingType == "all")
                    {
                        sumLeft += priceRatings[i];
                    }
                }
            }

        }

        for (int i = entryPoint + 1; i < priceRatings.Length; i++)
        {
            if (itemsType == "cheap")
            {
                if (priceRatings[i] < priceRatings[entryPoint])
                {
                    if (ratingType == "positive")
                    {
                        if (priceRatings[i] > 0)
                        {
                            sumRight += priceRatings[i];
                        }
                    }
                    else if (ratingType == "negative")
                    {
                        if (priceRatings[i] < 0)
                        {
                            sumRight += priceRatings[i];
                        }
                    }
                    else if (ratingType == "all")
                    {
                        sumRight += priceRatings[i];
                    }
                }
            }

            else if (itemsType == "expensive")
            {
                if (priceRatings[i] >= priceRatings[entryPoint])
                {
                    if (ratingType == "positive")
                    {
                        if (priceRatings[i] > 0)
                        {
                            sumRight += priceRatings[i];
                        }
                    }
                    else if (ratingType == "negative")
                    {
                        if (priceRatings[i] < 0)
                        {
                            sumRight += priceRatings[i];
                        }
                    }
                    else if (ratingType == "all")
                    {
                        sumRight += priceRatings[i];
                    }
                }
            }
            
        }

        if (sumLeft >= sumRight)
        {
            Console.WriteLine("Left - {0}", sumLeft);
        }
        else
        {
            Console.WriteLine("Right - {0}", sumRight);
        }
                
    }
}
