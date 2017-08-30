using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a C# program remove specified a character from a non-empty string using index of a character. 
Test Data:
w3resource
Sample Output:
wresource
w3resourc
3resource
*/

namespace MiscProblems.Basics
{
    class StringCharacterRemove
    {
        static void Main(string[] args)
        {

            var finalString ="";
            Console.WriteLine("Enter string to be edited");
            var inputString = Console.ReadLine();

            Console.WriteLine("Enter character to be remove from string");
            var toBeRemoved = Console.ReadLine();

            if (inputString.Contains(toBeRemoved))
            {
                finalString = inputString.Replace(toBeRemoved, "");
            }
            else
            {
                finalString = inputString;
            }

            Console.WriteLine("String is now " + finalString);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

}

/*Treats caps and lower case as different. Might try to build a version that removes caps and lower, but maintains the original cap status.*/

