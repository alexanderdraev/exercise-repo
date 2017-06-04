using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceInMeters = int.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());

            var totalSeconds = seconds + minutes * 60 + (hours * 60 * 60);
            var meterPerSeconds = distanceInMeters / totalSeconds;
            var kilometersPerHour = (distanceInMeters / 1000) / (totalSeconds / 60 / 60);
            var milesPerHour = (distanceInMeters / 1609f) / (totalSeconds / 60 / 60);

            Console.WriteLine(meterPerSeconds);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
