using System;

namespace _0511_PriceChangeAlert
{
    class PriceChangeAlert
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine()); 
            double previousSum = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double nextPrice = double.Parse(Console.ReadLine()); 
                double difference = GetDifference(previousSum, nextPrice);  
                bool isMinor = isDifferent(difference, threshold);

                string message = Get(nextPrice, previousSum, difference, isMinor);
                Console.WriteLine(message);

                previousSum = nextPrice;
            }
        }

        private static string Get(double nextPrice, double previousSum, double difference, bool isMinor)
        {
            string message = "";
            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", nextPrice);
            }
            else if (!isMinor)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousSum, nextPrice, difference * 100);
            }
            else if (isMinor && (difference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousSum, nextPrice, difference * 100);
            }
            else if (isMinor && (difference < 0))
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousSum, nextPrice, difference * 100);
            }
            return message;
        }

        private static bool isDifferent(double threshold, double difference)
        {
            if (Math.Abs(threshold) >= difference)
            {
                return true;
            }
            return false;
        }

        private static double GetDifference(double previousSum, double nextSum) 
        {
            double result = (nextSum - previousSum) / previousSum;
            return result;
        }
    }
}


