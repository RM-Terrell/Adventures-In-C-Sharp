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

    // Basically just make a LINQ query that prints all elements in a string array

namespace MiscProblems.LINQ
{
    class PrintAll
    {
        static void Main()
        {
            string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            var allQuery =
                from words in daysOfTheWeek
                select words;

            foreach(var wordElements in allQuery)
            {
                Console.WriteLine(wordElements + "\n");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
