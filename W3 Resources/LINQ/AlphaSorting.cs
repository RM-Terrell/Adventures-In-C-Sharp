using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Write a program in C# Sharp to arrange the distinct elements in the list in ascending order. 
Expected Output :
Biscuit
Brade
Butter
Honey
*/

namespace W3Resources.LINQ
{
    class AlphaSorting
    {
        static void Main()
        {
            string[] citiesArr = { "Rome", "London", "Nairobi", "Boulder", "Zurich", "New Dehli", "Amsterdam", "Oslo", "Paris" };

            var alphaSorted = citiesArr.OrderBy(n => n);

            foreach (var city in alphaSorted)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
