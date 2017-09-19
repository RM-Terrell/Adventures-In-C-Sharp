using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 Write a C# program to compute the sum of the first 500 prime numbers.
Sample Output:
Sum of the first 500 prime numbers:
3682913
 */

namespace MiscProblems.Basics
{
    class PrimeNumberSum
    {
        static void Main(string[] args)
        {

            long totalSum = 0;
            int n = 2;

            Console.WriteLine("Enter how many prime numbers you wish to sum ");
            int sumLimit = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i <= sumLimit; i++)
            {
                if (isPrime(n))
                {
                    totalSum += n;                    
                }
                n++;
            }
            // Learning moment. The above for loop sums prime numbers *below* totalSum. Not the first prime numbers equal to totalSum. 
            // To fix this all i need to do is only move on the for loop if it hits a prime number. Meaning it sums n numbers. Not primes below the n given.

            Console.WriteLine("Total sum of primes is " + totalSum);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n)); 
            // Reduces computation time by only checking up to the square root. Also excludes division by self.         

            if(n == 1)
            {
                return false;
            }
            // In case code reused and 1 ever gets passed in. Current context starts at 2.

            if(n == 2)
            {
                return true;
            }
            // 2 is a prime number but will return false by the below loop because it divides equally by 2 (itself)

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }
            // All integers divide without remainder by 1 so no need to check that.

            return true;
        }
    }

}
