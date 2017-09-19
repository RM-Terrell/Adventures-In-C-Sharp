using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to create a function for the sum of two numbers. 
Test Data :
Enter a number: 15
Enter another number: 16
Expected Output :
The sum of two numbers is : 31
*/

namespace MiscProblems.Functions
{
    class Sums
    {
        public static int Sum(int numOne, int numTwo)
        {
            int sum;
            sum = numOne + numTwo;
            return sum;            
        }

        public static void Main()
        {
            int numOne;
            int numTwo;

            Console.WriteLine("Enter first number to sum: ");
            numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number to sum: ");
            numTwo = int.Parse(Console.ReadLine());

            Console.WriteLine(Sum(numOne, numTwo));

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }
}
