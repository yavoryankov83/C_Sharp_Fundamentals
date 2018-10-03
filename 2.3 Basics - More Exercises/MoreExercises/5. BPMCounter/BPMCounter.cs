using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BPMCounter
{
    class BPMCounter
    {
        static void Main(string[] args)
        {
            var beatsPerMinute = int.Parse(Console.ReadLine());
            var numberOfBeats = int.Parse(Console.ReadLine());

            var bars = Math.Round(numberOfBeats / 4.0, 1);
            var lengthInSeconds = ((double)numberOfBeats / beatsPerMinute) * 60;
            var lengthInMinutes = (int)lengthInSeconds / 60;
            lengthInSeconds = (int)lengthInSeconds % 60;

            Console.WriteLine($"{bars} bars - {lengthInMinutes}m {lengthInSeconds}s");
        }
    }
}
