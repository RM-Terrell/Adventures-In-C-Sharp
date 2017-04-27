using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?*/

namespace Euler_Project_CS
{
    public class Problem3
    {
        public static void Main(string[] args)
        {
            long number = 600851475143; // Desired number to find largest prime factor
            long result = largestPrimeFactorOf(number);

            Console.WriteLine(result);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static long largestPrimeFactorOf(long n)
        {
            long largestFactor = 1;

            
            for (long i = 2; i * i <= n; ++i)
            {
                if (n % i == 0) // check if divisor
                {
                    largestFactor = i;
                    
                    while (n > 1 && n % i == 0)
                    {
                        n /= i;
                    }
                }
            }

            if (n > 1)
            {                
                largestFactor = n;
            }
            return largestFactor;
        }

    }
}