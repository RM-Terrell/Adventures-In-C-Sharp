using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times
Test Data:
Input a string (conatins at least one 'w' char) : w3resource
Test the string contains 'w' character between 1 and 3 times:
Sample Output
True 
*/

// Going to tweak this a bit and prompt for user input for the string to be searched, the character they want to check. 

namespace W3Resources.Basics
{
    class StringSearch
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter string to be checked");
            var inputString = Console.ReadLine();

            Console.WriteLine("Enter substring to be searched");
            var inputSubString = Console.ReadLine();

            if(inputString.IndexOf(inputSubString) != -1)
            {
                Console.WriteLine("String contains the substring");
            }

            else
            {
                Console.WriteLine("Substring not contained in string");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
