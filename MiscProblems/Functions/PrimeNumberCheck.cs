using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to create a function to check whether a number is prime or not. 
Test Data :
Input a number : 31
Expected Output :
31 is a prime number
*/

namespace MiscProblems.Functions
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            bool isPrime = false;
            bool run = true;

            while (run)
            {
                int inputValue = 0;

                Console.WriteLine("Enter a number to check if it is a prime number or not.");
                inputValue = int.Parse(Console.ReadLine());

                isPrime = PrimeCheck(inputValue);

                if (isPrime == true)
                {
                    Console.WriteLine("{0} is a prime number", inputValue);
                }

                else if (isPrime == false)
                {
                    Console.WriteLine("{0} is not a prime number", inputValue);
                }

                else
                {
                    Console.WriteLine("Something broke");
                }

                Console.WriteLine("Type 'Exit' to exit program. Press 'Enter' to continue.");
                var exitValue = Console.ReadLine();
                if(exitValue == "Exit")
                {
                    run = false;
                }                          
            }
        }

        public static bool PrimeCheck(int testValue)
        {
            bool isPrime = true;

            for(int i = 2; i < testValue; i++)
            // No need to start at 1 since all numbers divide by 1
            {
                if(testValue % i == 0)
                {
                    isPrime = false;
                }                
            }
            return isPrime;
        }
    }
}
