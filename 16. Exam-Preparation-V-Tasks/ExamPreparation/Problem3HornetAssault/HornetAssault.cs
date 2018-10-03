using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem3HornetAssault
{
    class HornetAssault
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            var hornets = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count <= 0)
                {
                    break;
                }
                if (hornets.Sum() > beehives[i])
                {
                    beehives.RemoveAt(i);
                    i--;
                }
                else
                {
                    beehives[i] -= hornets.Sum();
                    hornets.RemoveAt(0);
                }
            }
            if (beehives.Where(h =>  h > 0).ToList().Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehives.Where(h => h > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
            
            //var result = new List<long>();

            //var beehives = Console.ReadLine()
            //    .Split(' ')
            //    .Select(long.Parse)
            //    .ToList();

            //var hornets = Console.ReadLine()
            //    .Split(' ')
            //    .Select(long.Parse)
            //    .ToList();

            //var power = hornets.Sum();

            //for (int i = 0; i < beehives.Count; i++)
            //{
            //    if (power <= beehives[i])
            //    {
            //        var difference = beehives[i] - power;
            //        if (difference != 0)
            //        {
            //            result.Add(difference);
            //        }
            //        if (hornets.Count <= 0)
            //        {
            //            break;
            //        }

            //        hornets.RemoveAt(0);

            //        power = hornets.Sum();
            //    }
            //}
            //Console.WriteLine(result.Count > 0
            //    ? string.Join(" ", result)
            //    : string.Join(" ", hornets));
        }
    }
}
