using System;
using System.Collections.Generic;
using System.Linq;

class Driver
{
    public string Name { get; set; }
    public bool IsFinished { get; set; }
    public double Fuel { get; set; }
    public int ReachedIndex { get; set; }
}

class EnduranceRally
{
    static void Main()
    {
        var allDrivers = new List<Driver>();

        string[] drivers = Console.ReadLine().Split(' ').ToArray();
        double[] zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        int[] checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        foreach (var newDriver in drivers)
        {
            var driver = new Driver();

            driver.Name = newDriver;
            driver.Fuel = newDriver.First();
            driver.IsFinished = true;

            for (int i = 0; i < zones.Length; i++)
            {

                if (checkpoints.Contains(i))
                {
                    driver.Fuel += zones[i];
                }
                else
                {
                    driver.Fuel -= zones[i];
                }

                if (driver.Fuel <= 0)
                {
                    driver.IsFinished = false;
                    driver.ReachedIndex = i;
                    break;
                }
                
            }

            allDrivers.Add(driver);
        }

        foreach (var driver in allDrivers)
        {
            if (driver.IsFinished)
            {
                Console.WriteLine("{0} - fuel left {1:f2}",
                    driver.Name, driver.Fuel);
            }
            else
            {
                Console.WriteLine("{0} - reached {1}",
                    driver.Name, driver.ReachedIndex);
            }
        }
    }
}
