using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to create a user define function. 
Expected Output :
Welcome Friends!
Have a nice day!
*/

// I didnt find the instructions for this very clear. 
// They want two functions made that log to the console, then call those two functions from Main.

namespace W3Resources.Functions
{
    class CallTwoFunctions
    {
        public static void firtFunction()
        {
            Console.WriteLine("Looks like the first funciton works.");
        }

        public static void secondFunction()
        {
            Console.WriteLine("Looks like the second function works.");
        }

        public static void Main()
        {
            Console.WriteLine("Testing out both functions.\n");
            firtFunction();
            secondFunction();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
