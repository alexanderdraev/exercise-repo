using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());

            for (int currentNum = 2; currentNum <= endNum; currentNum++)
            {
                bool isPrime = true;
                for (int num = 2; num <= Math.Sqrt(currentNum); num++)
                {
                    if (currentNum % num == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", currentNum, isPrime);
            }
        }
    }
}