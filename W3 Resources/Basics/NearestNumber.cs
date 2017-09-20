using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.
Test Data:
Input first integer:
15
Input second integer:
12
Sample Output
15
*/

namespace W3Resources.Basics
{
    class NearestNumber
    {
        static void Main(string[] args)
        {
            const int constraint = 20;
            int firstNum = 0;
            int secondNum = 0;
            int firstNumDiff = 0;
            int secondNumDiff = 0;


            Console.WriteLine("Enter first number to check");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number to check");
            secondNum = Convert.ToInt32(Console.ReadLine());

            firstNumDiff = Math.Abs(firstNum - constraint);
            secondNumDiff = Math.Abs(secondNum - constraint);

           if(firstNumDiff == secondNumDiff)
            {
                Console.WriteLine("0");
            }
           if(firstNumDiff < secondNumDiff)
            {
                Console.WriteLine(firstNum);
            }
           if(firstNumDiff > secondNumDiff)
            {
                Console.WriteLine(secondNum);
            }


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
