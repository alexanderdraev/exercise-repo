using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstObject = Console.ReadLine();
            string secondObject = Console.ReadLine();

            string sum = "" + firstObject + " " + secondObject;
            Console.WriteLine(sum);
        }
    }
}
