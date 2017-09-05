using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Write a C# program to compute the sum of all the elements of an array of integers. Go to the editor
Test Data:
Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
Sample Output
Sum: 69 
*/

namespace MiscProblems.Basics
{
    class ArraySum
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

            int ArraySum = 0;

            foreach(int i in Array1)
            {
                ArraySum += i;
            }

            Console.WriteLine("Array sum is {0}", ArraySum);


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
