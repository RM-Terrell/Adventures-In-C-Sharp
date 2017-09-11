using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * 
 * Write a program in C# Sharp to find the number of an array and the square of each number. Go to the editor
Expected Output :
{ Number = 9, SqrNo = 81 }
{ Number = 8, SqrNo = 64 }
{ Number = 6, SqrNo = 36 }
{ Number = 5, SqrNo = 25 }

 */
// Problem instructions werent too clear to me at first. 
// Going to interpret this as "Make a program that finds all values in an array with a square value larger than a certain value.

namespace MiscProblems.LINQ
{
    class SquareOfElementQuery
    {
        static void Main()
        {
            int[] sourceArray = { 1, 2, -4, -8, 10, 29, 4, 1, 1, -56, -7, 12, -9, -20, 50, 99 };
            int upperSquare = 0;

            Console.WriteLine("Enter minimum square value of array element");
            upperSquare = int.Parse(Console.ReadLine());

            var squareQuery =
                from nums in sourceArray
                let square = nums * nums
                where square > upperSquare
                select new { nums, square };

            foreach(var objects in squareQuery)
            {
                Console.WriteLine(objects);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            

        }
    }
}
