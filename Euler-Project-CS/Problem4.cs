using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
  */

namespace Euler_Project_CS
{
    class Template
    {
        static void Main(string[] args)
        {
            
            int maxPalindrome = 0;
            int multipleI = 0;
            int multipleJ = 0;

            // Direct approach looping through numbers to find pallindrome. Using helper method.
            // First tried to do this with one giant class with pallindrome checking inside loops. Results were....not good.

            for (int i = 100; i < 1000; i++)
            {

                for (int j = i; j < 1000; j++)
                {
                    int product = i * j;

                    if (product.IsPalindrome()

                         && product > maxPalindrome)
                    {
                        maxPalindrome = product;
                        multipleI = i;
                        multipleJ = j;
                    }
                }
            }

            Console.WriteLine(maxPalindrome);
            Console.WriteLine(multipleI);
            Console.WriteLine(multipleJ);



            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
    public static class Extensions

    {
        public static bool IsPalindrome(this int i)

        {
            List<char> chars =

                new List<char>(i.ToString().ToCharArray());

            chars.Reverse(); //Cheated and used ths instead of loop reconstruction like i tried before


            return i == int.Parse(new string(chars.ToArray()));
        }
    }
}