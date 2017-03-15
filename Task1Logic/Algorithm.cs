using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Logic
{
    /// <summary>
    /// Class which contain Neuton method of calculating the nth root
    /// </summary>
    public static class Algorithm
    {
        #region public methods
        /// <summary>
        /// Neuton method of calculating the nth root
        /// </summary>
        /// <param name="A">The number from which the root is extracted</param>
        /// <param name="n">Degree of extracted root</param>
        /// <param name="epsilon">accuracy</param>
        /// <returns>The value of the root nth degree</returns>
        public static double NeutonMethod(double A, double n, double epsilon = 0.000001)
        {
            if(A < 0)
            {
                throw new ArgumentException("You should use positive number");
            }
            if (n < 0)
            {
                throw new ArgumentException("You should use a positive degree");
            }
            if (epsilon < 0 || epsilon >= 1)
            {
               throw new ArgumentException("Epsilon must be double");
            }

            return NeutonNthRoot(A, n, epsilon);
        }
        #endregion

        #region private methods 
        /// <summary>
        /// Intermediate method of calculating the nth root
        /// </summary>
        /// <param name="A"></param>
        /// <param name="n"></param>
        /// <param name="epsilon"></param>
        /// <returns>The value of the root nth degree</returns>
        private static double NeutonNthRoot(double A, double n, double epsilon = 0.000001)
        {
            var xPrev = A / n;
            var xNext = (1 / n) * ((n - 1) * xPrev + A / Math.Pow(xPrev, (int)n - 1));

            while (Math.Abs(xNext - xPrev) > epsilon)
            {
                xPrev = xNext;
                xNext = (1 / n) * ((n - 1) * xPrev + A / Math.Pow(xPrev, (int)n - 1));
            }

            return xNext;
        }
        #endregion
    }
}
