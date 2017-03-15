using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Task2Logic;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan time = TimeSpan.Zero;

            int result = Algorithms.GreatestCommonDivisorByEuclid(out time, -12345, 555);

            Console.WriteLine($"The greatest common divisor is {result}," +
                                                   $" it cost us {time.TotalSeconds:0} seconds" +
                                                   $" {time.TotalMilliseconds} milliseconds...");

            result = Algorithms.GreatestCommonDivisorByEuclid(out time, 50, 10, 15,20, 445);

            Console.WriteLine($"The greatest common divisor is {result}," +
                                                   $" it cost us {time.TotalSeconds:0} seconds" +
                                                   $" {time.TotalMilliseconds} milliseconds...");

            result = Algorithms.BinaryGreatestCommonDivision(out time, 50, 10);

            Console.WriteLine($"The greatest common divisor is {result}," +
                                                   $" it cost us {time.TotalSeconds:0} seconds" +
                                                   $" {time.TotalMilliseconds} milliseconds...");

            result = Algorithms.BinaryGreatestCommonDivision(out time, 50, 100,150,350,400,550);

            Console.WriteLine($"The greatest common divisor is {result}," +
                                                   $" it cost us {time.TotalSeconds:0} seconds" +
                                                   $" {time.TotalMilliseconds} milliseconds...");


        }
    }
}
