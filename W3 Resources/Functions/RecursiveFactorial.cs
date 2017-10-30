using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to create a recursive function to find the factorial of a given number. Go to the editor
Test Data :
Enter a number: 5
Expected Output :
The factorial of 5! is 120 
*/

namespace W3Resources.Functions
{
    class RecursiveFactorial
    {
        public static void Main()
        {
            int input = 0;

            Console.WriteLine("Enter a number to find the factorial: ");
            input = int.Parse(Console.ReadLine());

            int factorial = RecSum(input);
            Console.WriteLine("{0}! is equal to: {1}", input, factorial);
        }

        public static int RecSum(int input)
        {            
            if (input == 0)
            {
                return 1;
            }
            
            else
            {
                return input * RecSum(input - 1);
            }
        }
    }
}
