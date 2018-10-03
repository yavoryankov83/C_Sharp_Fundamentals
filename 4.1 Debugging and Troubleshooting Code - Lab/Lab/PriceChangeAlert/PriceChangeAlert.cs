using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceChangeAlert
{
    class PriceChangeAlert
    {
        static void Main(string[] args)
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double difference = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double findDifference = CalcDiff(lastPrice, currentPrice);
                bool isSignificantDifference = imaliDif(findDifference, difference);

                string message = Get(currentPrice, lastPrice, findDifference, isSignificantDifference);
                Console.WriteLine(message);
                lastPrice = currentPrice;
            }
        }

        private static string Get(double currentPrice, double lastPrice, double findDifference, bool isSignificantDifference)
        {
            string to = "";
            if (findDifference == 0)
            {
                to = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:0.00%})", lastPrice, currentPrice, findDifference);
            }
            else if (isSignificantDifference && (findDifference > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:0.00%})", lastPrice, currentPrice, findDifference);
            }
            else if (isSignificantDifference && (findDifference < 0))
            {
                to = string.Format("PRICE DOWN: {0} to {1} ({2:0.00%})", lastPrice, currentPrice, findDifference);
            }

            return to;
        }

        private static bool imaliDif(double findDifference, double difference)
        {
            if (Math.Abs(findDifference) >= difference)
            {
                return true;
            }
            return false;
        }

        private static double CalcDiff(double lastPrice, double currentPrice)
        {
            double result = (currentPrice - lastPrice) / lastPrice;
            return result;
        }
    }
}