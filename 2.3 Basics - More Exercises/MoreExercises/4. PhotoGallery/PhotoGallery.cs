using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PhotoGallery
{
    class PhotoGallery
    {
        static void Main(string[] args)
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var dateDay = int.Parse(Console.ReadLine());
            var dateMonth = int.Parse(Console.ReadLine());
            var dateYear = int.Parse(Console.ReadLine());
            var dateHours = int.Parse(Console.ReadLine());
            var dateMinutes = int.Parse(Console.ReadLine());
            var photoSize = double.Parse(Console.ReadLine());
            var photoWidth = int.Parse(Console.ReadLine());
            var photoHeight = int.Parse(Console.ReadLine());

            var mode = "";
            var size = "B";

            if (photoWidth > photoHeight)
            {
                mode = "landscape";
            }
            else if (photoWidth < photoHeight)
            {
                mode = "portrait";
            }
            else
            {
                mode = "square";
            }

            if (photoSize > 1000)
            {
                photoSize /= 1000;
                size = "KB";
            }

            if (photoSize > 1000)
            {
                photoSize /= 1000;
                size = "MB";
            }

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {dateDay:D2}/{dateMonth:D2}/{dateYear} {dateHours:D2}:{dateMinutes:D2}");
            Console.WriteLine($"Size: {photoSize}{size}");
            Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} ({mode})");
        }
    }
}
