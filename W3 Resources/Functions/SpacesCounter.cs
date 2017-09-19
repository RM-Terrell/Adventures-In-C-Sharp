using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
Test Data :
Please input a string : This is a test string.
Expected Output :
"This is a test string." contains 4 spaces
*/
// Made space a variable instead of hard coded so this could be easily repurposed to search any character.

namespace W3Resources.Functions
{
    class SpacesCounter
    {
        static void Main()
        {

            Console.WriteLine("Enter string to count spaces: ");

            var inputString = Console.ReadLine();

            int spaces = spaceCounter(inputString);

            Console.WriteLine("Number of spaces in provided string is: {0} \nPress any key to exit", spaces);
            Console.ReadKey();
        }

        public static int spaceCounter(string stringToBeSpaceChecked)
        {
            int spaces = 0;
            var space = ' ';

            var spaceQuery =
                from items in stringToBeSpaceChecked
                where items == space
                select items;

            foreach (var elements in spaceQuery)
            {
                spaces += 1;
            }


            return spaces;
        }
    }
}
