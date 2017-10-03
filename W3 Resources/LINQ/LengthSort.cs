using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to display the list of items in the array according to the length of the string,
then by name in ascending order.

Expected Output :
Here is the arranged list :
ROME
PARIS
LONDON
ZURICH
NAIROBI
ABU DHABI
AMSTERDAM
NEW DELHI
CALIFORNIA
*/

namespace W3Resources.LINQ
{
    class LengthSort
    {
        static void Main()
        {
            string[] citiesArr = { "Rome","New York", "Fort Collins", "Chicago", "Moscow", "London",
                "Nairobi", "Boulder", "Zurich", "New Dehli", "Amsterdam", "Oslo", "Paris" };

            var lengthSorted = citiesArr.OrderBy(n => n.Length);

            foreach (var cities in lengthSorted)
            {
                Console.WriteLine(cities);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
