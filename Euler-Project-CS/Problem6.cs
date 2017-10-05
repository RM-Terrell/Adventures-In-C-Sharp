using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

The sum of the squares of the first ten natural numbers is,
12 + 22 + ... + 102 = 385

The square of the sum of the first ten natural numbers is,
(1 + 2 + ... + 10)2 = 552 = 3025

Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
*/

namespace Euler_Project_CS
{
    class Problem6
    {
        static void Main()
        {
            Console.WriteLine("Enter lower bound");
            int lowerN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter upper bound");
            int upperN = Convert.ToInt32(Console.ReadLine());
            long sumValue = 0;
            long result = 0;
            long squaredValue = 0;

            for(int i = lowerN; i<=upperN; i++)
            {
                sumValue += i;
                squaredValue += i * i;
            }

            result = sumValue * sumValue - squaredValue;


            Console.WriteLine("Sum of squares = " + squaredValue);
            Console.WriteLine("Square of sums = "+sumValue*sumValue);
            Console.WriteLine("Difference = "+result);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}