using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var hexidecimal = Convert.ToString(num, 16).ToUpper();
            var binary = Convert.ToString(num, 2);

            Console.WriteLine(hexidecimal);
            Console.WriteLine(binary);

        }
    }
}
