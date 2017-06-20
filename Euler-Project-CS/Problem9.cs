using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
a2 + b2 = c2

For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
 */

namespace Euler_Project_CS
{
    class Problem9
    {
        static void Main(string[] args)
        {

            new Problem9().PythTriplet();

        }

        public void PythTriplet()
        {
            //First attempt before realizing that A B and C didnt need to be consecutive. Below code finds that sure enough there is no solution to the problem if A B and C are consecutive. 

            //int FinalProduct = 0;
            //for(int i = 1; i < 1000; i++)
            //{
            //    int TestA = i;
            //    int TestB = i + 1;
            //    int TestC = i + 2;

            //    if ((TestA * TestA + TestB * TestB == TestC * TestC) && TestA + TestB + TestC == 1000){
            //        FinalProduct = TestA * TestB * TestC;
            //    }
            //}            
            //Console.WriteLine("Product of Pyth Tripet is {0}", FinalProduct);

            //So i need a way to iterate through all combinations of A and B.

            int TestA = 0;
            int TestB = 0;
            int TestC = 0;
            bool found = false;

            for (TestA = 1; TestA < 1000; TestA++)
            {
                for (TestB = TestA; TestB < 1000; TestB++)
                {
                    TestC = 1000 - TestA - TestB;

                    if (TestA * TestA + TestB * TestB == TestC * TestC)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            };

            int FinalSum = TestA + TestB + TestC;
            int FinalProduct = TestA * TestB * TestC;

            Console.WriteLine("The pythagorean triple is {0}, {1}, {2}, and the sum is {3}", TestA, TestB, TestC, FinalSum);
            Console.WriteLine("The product is {0}", FinalProduct);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}