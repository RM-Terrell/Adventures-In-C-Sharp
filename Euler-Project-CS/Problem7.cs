﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?
*/

namespace Euler_Project_CS
{
    class Problem7
    {
        static void Main()
        {
            new Problem7().BruteForce(); 
        }

        public void BruteForce()
        {
            
            int numPrimes = 1;
            int numm = 1;
            Console.WriteLine("Numbered sequentially from 0, which prime number would you like to know?");
            var nThPrime = int.Parse(Console.ReadLine());

            while (numPrimes < nThPrime)
            {
                numm = numm + 2;

                if (isPrime(numm))
                {
                    numPrimes++;
                }
            }
                        
            Console.WriteLine("Prime number {0} is {1} ", numPrimes, numm);        
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        private bool isPrime(int numm)
        {
            if (numm <= 1)
            {
                return false;
            }

            if (numm == 2)
            {
                return true; // 2 is a prime number and the only even prime number, can handle it right away
            }

            if (numm % 2 == 0)
            {
                return false; // If the taken int is even, it can be excluded
            }

            int counter = 3; //Thus we can start at 3

            while ((counter * counter) <= numm) // Can start at the square root of the number directly saving computational load
            {
                if (numm % counter == 0)
                {
                    return false;
                }
                else
                {
                    counter += 2; 
                }
            }

            return true;
        }

    }

}