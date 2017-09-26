using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
Write a program in C# Sharp to display the name of the days of a week. 
Expected Output:
Sunday
Monday
Tuesday
Wednesday
Thursday
Friday
Saturday
*/

// Understood this as make a LINQ query that prints all elements in a string array. 
// LINQ query is not even needed here to print all elements from an array but did anyways to follow problem

namespace W3Resources.LINQ
{
    class PrintAll
    {
        static void Main()
        {
            string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            var allQuery = daysOfTheWeek.Select(n => n);                

            foreach(var wordElements in allQuery)
            {
                Console.WriteLine(wordElements + "\n");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
