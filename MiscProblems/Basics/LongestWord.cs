using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/*
 * 
 * Write a C# program to find the longest word in a string. 
Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
Sample Output:
following

 */

namespace MiscProblems.Basics
{
    class LongestWord
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter string to be edited");
            var inputString = Console.ReadLine();

            var fixedInput = Regex.Replace(inputString, @"[^0-9a-zA-Z]+", " "); 
            // Trimming special characters before comparison. Found a few ways to do this, chose REGEX for practice

            var splitted = fixedInput.Split(' ');

            string word = "";
            int ctr = 0;
            foreach (String s in splitted)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
