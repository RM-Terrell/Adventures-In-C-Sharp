using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * Write a C# Sharp program to swap two numbers. 
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output:
After Swapping :
First Number : 6
Second Number : 5

 */

namespace MiscProblems.Basics
{
    class NumberSwap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number to swap");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number to swap");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            int tempNum = secondNum;
            secondNum = firstNum;
            firstNum = tempNum;

            Console.WriteLine("First number is now " + firstNum);
            Console.WriteLine("Second number is now " + secondNum);



            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}