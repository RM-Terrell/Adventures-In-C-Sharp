using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to find the string which starts and ends with a specific character.
Test Data :
The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
Input starting character for the string : A
Input ending character for the string : M
Expected Output :
The city starting with A and ending with M is : AMSTERDAM
*/


namespace W3Resources.LINQ
{
    class StartAndEnd
    {
        static void Main()
        {
            string[] citiesArr = { "Rome", "London", "Nairobi", "Boulder", "Zurich", "New Dehli", "Amsterdam", "Oslo", "Paris" };
            string inputStart = "";
            string inputEnd = "";

            Console.WriteLine("Enter starting letter. Case sensitive");
            inputStart = Console.ReadLine();

            Console.WriteLine("Enter ending letter");
            inputEnd = Console.ReadLine();

            var wordQuery = 
                citiesArr.Where(n => n.StartsWith(inputStart) && n.EndsWith(inputEnd));                

            foreach (var city in wordQuery)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
