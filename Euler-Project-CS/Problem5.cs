using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/

namespace Euler_Project_CS
{
    class Problem5
    {
        public static void Main()
        {

            Console.WriteLine("Enter upper limit");
            int divisorMax = Convert.ToInt32(Console.ReadLine());

            new Problem5().PrimeFactoring(divisorMax);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public void PrimeFactoring(int divisorMax)
        {
            //Struggled to develop a solution that didnt involve brute forcing with for loops. Those solutions were very slow.
            //Was pointd towards prime factorization via a google search and implemented it below. High school math all over again
            //Goal now is to find the small set of primes to make all numbers. 

            
            int[] p = generatePrimes(divisorMax);
            int result = 1;

            for (int i = 0; i < p.Length; i++)
            {
                int a = (int)Math.Floor(Math.Log(divisorMax) / Math.Log(p[i]));
                result = result * ((int)Math.Pow(p[i], a));
            }

            
            Console.WriteLine("");
            Console.WriteLine(result);
        }
        private int[] generatePrimes(int upperLimit)
        {
            List<int> primes = new List<int>();
            bool isPrime;
            int j;

            primes.Add(2);

            for (int i = 3; i <= upperLimit; i += 2)
            {
                j = 0;
                isPrime = true;
                while (primes[j] * primes[j] <= i)
                {
                    if (i % primes[j] == 0) //check odd numbers for being divisible with prime number set
                    {
                        isPrime = false;
                        break;
                    }
                    j++;
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
            }

            return primes.ToArray<int>();
        }
    }

}