using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Write a program in C# Sharp to find the psotive numbers from a list of numbers using two where conditions in LINQ Query.
Expected Output:
The numbers within the range of 1 to 11 are :
1 3 6 9 10
*/

// Works for more than just pure positive numbers and runs off user input instead of hard coded


namespace MiscProblems.LINQ
{
    class NumbersWithinRange
    {
        static void Main()
        {
            int[] sourceArray = { 1, 2, -4, -8, 10, 29, 4, 1, 1, -56, -7, 12, -9, -20, 50, 99 };
            int lowerRange = 0;
            int upperRange = 0;

            Console.WriteLine("Enter lower range to query.");
            lowerRange = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter upper range to query");
            upperRange = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            var rangeQuery =
                from nums in sourceArray
                where nums <= upperRange
                where nums >= lowerRange
                select nums;

            Console.WriteLine("Numbers within range of query are \n");
            foreach(var nums in rangeQuery)
            {
                Console.Write("{0} ", nums);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();                             
        }
    }
}
