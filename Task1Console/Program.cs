using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Logic;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double epsilon = 1e-05;
            double A = 3;
            double N = 2;

            double result = Algorithm.NeutonMethod(A, N, epsilon);

            if(Math.Pow(A, (double)(1/N)) - result < epsilon)
            {
                Console.WriteLine("True ");
            }
        }
    }
}
