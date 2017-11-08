    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    class AnonymousDownsite
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            List<string> siteNames = new List<string>();
            decimal totalMoneyLoss = 0;
            BigInteger securityToken = new BigInteger(1);

            for (int i = 0; i < n; i++)
            {
                var website = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string siteName = website[0];
                siteNames.Add(siteName);

                long siteVisits = long.Parse(website[1]);
                decimal pricePerVisitor = decimal.Parse(website[2]);
                totalMoneyLoss += siteVisits * pricePerVisitor;

                securityToken *= securityKey;
            }

            foreach (var name in siteNames)
            {
                Console.WriteLine($"{name}");
            }
            Console.WriteLine($"Total Loss: {totalMoneyLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        
            //Another approach:
            //BigInteger securityToken = BigInteger.Pow(new BigInteger(securityKey), n);
        }
    }
