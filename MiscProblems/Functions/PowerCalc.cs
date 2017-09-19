using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another.
Test Data :
Input Base number: 3
Input the Exponent : 2
Expected Output :
So, the number 3 ^ (to the power) 2 = 9
*/

// Base C# has no operator for power functions but .NET does. Opted to use .NET solution

namespace MiscProblems.Functions
{
    class PowerCalc
    {
        public static void Main()
        {
            double baseValue = 0;
            double expValue = 0;
            double result = 0;


            Console.WriteLine("Enter base value: ");
            baseValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter exponent value: ");
            expValue = double.Parse(Console.ReadLine());

            result = ExponentCalc(baseValue, expValue);

            Console.WriteLine("Result is: {0}\nPress any key to exit", result);
            Console.ReadKey();            
        }

        public static double ExponentCalc(double baseValue, double expValue)
        {
            double result = 0;

            result = Math.Pow(baseValue, expValue);

            return result;
        }
    }
}
