// !!!-UNFINISHED-!!!

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class SoftUniCoffeeSupplies
//{
//    static void Main()
//    {
//        var report = new Dictionary<string, Dictionary<string, int>>();

//        var keywords = Console.ReadLine().Split(' ').ToArray();
//        string personCoffee = keywords[0];
//        string coffeQuantity = keywords[1];

//        string info = Console.ReadLine();
//        while (info != "end of info")
//        {
//            string coffee = null;
//            string personName = null;
//            int quantity = 0;

//            if (info.Contains(personCoffee))
//            {
//                var infoArgs = info.Split(personCoffee).ToArray();
//                personName = infoArgs[0];
//                coffee = infoArgs[1];

//                if (!report.ContainsKey(coffee))
//                {
//                    report.Add(coffee, new Dictionary<string, int>());
//                    report[coffee].Add(personName, quantity);
//                }
//                if (!report[coffee].ContainsKey(personName))
//                {
//                    report[coffee].Add(personName, quantity);
//                }
//                report[coffee][personName] += quantity;

//                info = Console.ReadLine();
//            }

//            else 
//            {
//                var infoArgs = info.Split(coffeQuantity).ToArray();
//                coffee = infoArgs[0];
//                quantity = int.Parse(infoArgs[1]);

//                if (!report.ContainsKey(coffee))
//                {
//                    continue;
//                }

//                report[coffee]

//                info = Console.ReadLine();
//            }



//        }

//        var outOfCoffee = report.Values.Select(x => x.Where(y => y.Value == 0));
//        foreach (var item in outOfCoffee)
//        {
//            Console.WriteLine($"Out of {item.Select(x => x.Key)}");
//        }

//        //string info = Console.ReadLine();
//        //while (info != "end of info")
//        //{
//        //    info = Console.ReadLine();
//        //}

//    }
//}
