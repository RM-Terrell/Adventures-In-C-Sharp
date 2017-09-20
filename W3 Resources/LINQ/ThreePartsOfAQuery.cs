using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program in C# Sharp to shows how the three parts of a query operation execute. 
Expected Output:
The numbers which produce the remainder 0 after divided by 2 are :
0 2 4 6 8 */

namespace W3Resources.LINQ
{
    class ThreePartsOfAQuery
    {
        static void Main()
        {
            /*Three parts to be demonstrated:
             Data Source
             Query Creation
             Query Execution
             */

            //Data source
            int[] queryArray = new int[8] { 1, 3, 2, 8, 43, 32, 4, 19 };

            // Query creation
            // Check for odd numbers in the array
            var newQuery =
                from nums in queryArray
                where (nums % 2) != 0
                select nums;

            // Query Execution
            Console.WriteLine("Odd numbers are: \n");

            foreach(int nums in newQuery)
            {
                Console.Write("{0} ", nums);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

    }
}
