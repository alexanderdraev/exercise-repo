using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var picturesCount = int.Parse(Console.ReadLine());
            var singlePictureFilterTimeSeconds = int.Parse(Console.ReadLine());
            var filterPersentage = int.Parse(Console.ReadLine());
            var singlePictureUploadTimeSeconds = int.Parse(Console.ReadLine());

            var filterTimeSeconds = (long)picturesCount * singlePictureFilterTimeSeconds;
            var picturesToUploadCount =(long)Math.Ceiling(picturesCount * 
                (filterPersentage /100d));
            var uploadTimeSeconds = (long)picturesToUploadCount * 
                singlePictureUploadTimeSeconds;

            var totalTimeNeededSeconds = filterTimeSeconds +
                uploadTimeSeconds;

            var totalTimeNeededTimeSpan = TimeSpan.FromSeconds(totalTimeNeededSeconds);

            Console.WriteLine(totalTimeNeededTimeSpan.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
