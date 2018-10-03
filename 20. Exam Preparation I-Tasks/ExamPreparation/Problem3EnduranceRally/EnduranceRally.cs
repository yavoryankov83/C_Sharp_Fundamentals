using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3EnduranceRally
{
    class EnduranceRally
    {
        static void Main(string[] args)
        {
            var driversList = new List<string>();

            var driversNames = Console.ReadLine().Split();
            var track = Console.ReadLine().Split().Select(double.Parse).ToList();
            var checkpointIndexes = Console.ReadLine().Split().Select(double.Parse).ToList();

            var isAlive = true;
            var state = "";

            foreach (var driver in driversNames)
            {
                double startFuel = driver[0];

                for (int i = 0; i < track.Count; i++)
                {
                    if (!checkpointIndexes.Contains(i))
                    {
                        startFuel -= track[i];

                        if (startFuel <= 0)
                        {
                            isAlive = false;
                            state = $"{driver} - reached {i}";
                            driversList.Add(state);

                            break;
                        }
                    }
                    else
                    {
                        startFuel += track[i];
                    }
                }
                if (isAlive)
                {
                    Console.WriteLine($"{driver} - fuel left {startFuel:F2}");
                }
                else
                {
                    foreach (var deadDriver in driversList)
                    {
                        Console.WriteLine(deadDriver);
                    }
                    driversList.Clear();
                    isAlive = true;
                }
            }
        }
    }
}
