using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Write a program in C# Sharp to create a user define function with parameters.
Test Data :
Please input a name : John
Expected Output :
Welcome friend John !
Have a nice day!
*/

namespace W3Resources.Functions
{
    class SimpleParams
    {
        public static void nameFunction(string name)
        {
            Console.WriteLine("Welcome " + name);
        }

        public static void greetingFunction()
        {
            Console.WriteLine("Have a nice day");
        }

        public static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Please enter a name: ");
            name = Console.ReadLine();

            nameFunction(name);
            greetingFunction();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
