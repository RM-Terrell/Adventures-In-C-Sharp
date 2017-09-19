using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to find the uppercase words in a string. 
Test Data :
Input the string : this IS a STRING
Expected Output :
The UPPER CASE words are :
IS
STRING
*/

namespace MiscProblems.LINQ
{
    class UpperCaseFinder
    {
        static void Main()
        {
            string testString = "The quick BROWN fox JUMPED over THE lazy dog.";

            Console.WriteLine("Upper case letters in the test string are: ");

            var upperQuery = 
                testString.Split(' ')
                .Where(x => String.Equals(x, x.ToUpper(), StringComparison.Ordinal));

            foreach (var results in upperQuery)
            {
                Console.WriteLine(results);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
