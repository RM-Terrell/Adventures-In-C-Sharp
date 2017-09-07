using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Write a C# program to check if an array contains an odd number.
Test Data:
Original array: [2, 4, 7, 8, 6]
Check if an array contains an odd number? True 
*/
namespace MiscProblems.Array_Manipulation
{
    class ArrayOddCheck
    {
        static void Main(string[] args)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            bool oddCheck = true;

            Console.WriteLine("Enter number array to check for odd numbers");
            string text = Console.ReadLine();

            string[] stringArray = text.Split(delimiterChars);
            int[] numArray = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                numArray[i] = Int32.Parse(stringArray[i]);
                if(numArray[i] % 2 != 0)
                {
                    oddCheck = false;
                    break;
                }
            }

            if(oddCheck == true)
            {
                Console.WriteLine("Array contains no odd numbers");
            }

            else
            {
                Console.WriteLine("Array contains odd numbers");
            }


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
