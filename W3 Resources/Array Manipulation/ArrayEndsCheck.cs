using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more.
Test Data:
Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
Sample Output
True 
*/

namespace W3Resources.Basics
{
    class ArrayEndsCheck
    {
        static void Main(string[] args)
        {
            int[] TestArray = { 1, 2, 3, 4, 5, 6, 4, 3, 5, 2 };

            Console.WriteLine("Arry for checking is " + String.Join("," , TestArray));

            if(TestArray[0] == TestArray[TestArray.Length-1]) // Dont forget the "-1" you scrub
            {
                Console.WriteLine("Array ends are equal!");
            }

            else
            {
                Console.WriteLine("Array ends are NOT equal!");
            }


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
