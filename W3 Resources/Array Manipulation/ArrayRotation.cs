using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Write a C# program to rotate an array (length 3) of integers in left direction.
Test Data:
Array1: [1, 2, 8]
After rotating array becomes: [2, 8, 1]
*/

//Expanded to handle arrays larger than 3 and take user input instead of fixed.

namespace MiscProblems.Array_Manipulation
{
    class ArrayRotation
    {
        static void Main(string[] args)
        {

            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };            

            Console.WriteLine("Enter numbers to rotate left by 1");
            string text = Console.ReadLine();           

            string[] stringArray = text.Split(delimiterChars);
            int[] numArray = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                numArray[i] = Int32.Parse(stringArray[i]);
            }

            Console.WriteLine("Arry before rotation is " + String.Join(",", numArray));

            int firstElementStorage = numArray[0];

            for(int i = 0; i < numArray.Length - 1; i++)
            {
                numArray[i] = numArray[i + 1];
            }

            numArray[numArray.Length - 1] = firstElementStorage;

            Console.WriteLine("Array after rotation is " + String.Join(",", numArray));


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
