using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Write a C# program to compute the sum of all the elements of an array of integers. 
Test Data:
Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
Sample Output
Sum: 69 
*/

//Updated to take an input array from a user and cut out special characters. 

namespace W3Resources.Basics
{
    class ArraySum
    {
        static void Main()
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            int arraySum = 0;

            Console.WriteLine("Enter numbers separated to sum");
            string text = Console.ReadLine();

            Console.WriteLine("Input: '{0}'", text);

            string[] stringArray = text.Split(delimiterChars);
            int[] numArray = new int[stringArray.Length];

            for(int i = 0; i < stringArray.Length; i++)
            {
                numArray[i] = Int32.Parse(stringArray[i]);               
            }

            foreach (int i in numArray)
            {
                arraySum += i;
            }

            Console.WriteLine("Sum is {0}", arraySum);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
