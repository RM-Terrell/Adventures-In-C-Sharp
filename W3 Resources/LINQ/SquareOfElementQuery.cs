using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * 
 * Write a program in C# Sharp to find the number of an array and the square of each number.
Expected Output :
{ Number = 9, SqrNo = 81 }
{ Number = 8, SqrNo = 64 }
{ Number = 6, SqrNo = 36 }
{ Number = 5, SqrNo = 25 }

 */

// Problem instructions werent too clear to me at first. 
// Going to interpret this as "Make a program that finds all values in an array with a square value larger than a certain value.

namespace W3Resources.LINQ
{
    class SquareOfElementQuery
    {
        static void Main()
        {
            int[] sourceArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int upperSquare = 0;

            Console.WriteLine("Enter minimum squared value of array element");
            upperSquare = int.Parse(Console.ReadLine());

            var squareQuery = sourceArray.Where(n => (n * n) > upperSquare);                

            foreach (var value in squareQuery)
            {
                Console.WriteLine("{{ Number = {0}, Squared Number = {1} }}", value, (value*value));
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
