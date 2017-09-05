using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Write a C# program to multiply corresponding elements of two arrays of integers. 
Sample Output:
Array1: [1, 3, -5, 4]
Array2: [1, 4, -5, -2]
Multiply corresponding elements of two arrays:
1 12 25 -8

 */

namespace MiscProblems.Basics
{
    class ArrayMultiplication
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 3, -5, 4 };
            int[] secondArray = { 1, 4, -5, -2 };

            int biggestArraySize = Math.Max(firstArray.Length, secondArray.Length);


            Console.WriteLine("First array is: [{0}]", string.Join(", ",firstArray ));
            Console.WriteLine("SEcond Array is: [{0}]", string.Join(", ", secondArray));

            int[] multipliedArray = new int[4];

            for (int i = 0; i < biggestArraySize; i++)
            {
                multipliedArray[i] = firstArray[i] * secondArray[i];
            }

            Console.WriteLine("Mulitplied array is: [{0}]", string.Join(", ", multipliedArray));

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
