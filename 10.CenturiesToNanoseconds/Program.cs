using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal centuries = decimal.Parse(Console.ReadLine());

            var years = centuries * 100;
            var days = Math.Floor(years * 365.2422m);
            var hours = days * 24;
            var minutes = hours * 60;
            var seconds = minutes * 60;
            var milliseconds = seconds * 1000;
            var mircroSeconds = milliseconds * 1000;
            var nanoseconds = mircroSeconds * 1000;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                centuries, years, days, hours, minutes, seconds, milliseconds, mircroSeconds, nanoseconds);

        }
    }
}
