using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to convert a string array to a string.
Test Data :
Input number of strings to store in the array :3
Input 3 strings for the array :
Element[0] : cat
Element[1] : dog
Element[2] : rat
Expected Output:
Here is the string below created with elements of the above array :
cat, dog, rat
*/

namespace W3Resources.LINQ
{
    class StringArrayToString
    {
        static void Main()
        {
            int numberOfStrings = 0;
            string[] stringArray;
            bool run = true;

            while (run)
            { try
                {
                    Console.WriteLine("Input number of strings to store in the array: ");
                    numberOfStrings = int.Parse(Console.ReadLine());
                    run = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please enter numbers only");
                }
            }

            stringArray = new string[numberOfStrings];

            for (int i = 0; i < numberOfStrings; i++)
            {
                Console.WriteLine("Element {0}: ",i);
                stringArray[i] = Console.ReadLine();                
            }


            string joinedString = String.Join(" ", stringArray
                .Select(s => s.ToString()).ToArray());

            Console.WriteLine("Here is the string below created with elements of the above array :");
            Console.WriteLine(joinedString);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
