using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to display the characters and frequency of character from giving string. 
Test Data:
Input the string: apple
Expected Output:
The frequency of the characters are :
Character a: 1 times
Character p: 2 times
Character l: 1 times
Character e: 1 times
     */

    // Had to look this one up to solve. Was able to devolope a solution by cutting up the string and using array searching, but that didnt involve LINQ.
    // Learned about group. Also that I can call .key ad . count to do the things i was trying to do with arrays manually

namespace W3Resources.LINQ
{
    class LetterFrequency
    {
        static void Main()
        {
            string inputString = "";

            Console.WriteLine("Enter a string to find letter frequency");
            inputString = Console.ReadLine();

            var characterCheck =
                from character in inputString
                group character by character into output
                select output;

            foreach(var stringElement in characterCheck)
            {
                Console.WriteLine("Character: {0} Apears: {1}", stringElement.Key, stringElement.Count());
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();  
        }
    }
}
