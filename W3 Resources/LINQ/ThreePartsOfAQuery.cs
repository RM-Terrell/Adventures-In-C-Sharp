using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program in C# Sharp to shows how the three parts of a query operation execute. 
Expected Output:
The numbers which produce the remainder 0 after divided by 2 are :
0 2 4 6 8 */

/*Three parts to be demonstrated:
         Data Source
         Query Creation
         Query Execution
         */

namespace W3Resources.LINQ
{
    class ThreePartsOfAQuery
    {
        static void Main()
        {
            //Data source
            int[] queryArray = new int[9] { 1, 3, 2, 8, 43, 32, 4, 19, 21 };
            IEnumerable<int> queryResult;

            queryResult = lambdaQuery(queryArray);
            
            Console.WriteLine("Odd numbers are: \n");

            printByLine(queryResult);

            Console.WriteLine("\n");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static IEnumerable<int> statementQuery(int[] queryArray)
        {
            // Query creation
            // Check for odd numbers in the array

            // Statement version
            var newQuery =
                from nums in queryArray
                where (nums % 2) != 0
                select nums;

            return newQuery;
        }

        static IEnumerable<int> lambdaQuery(int[] queryArray)
        {
            // Query creation
            // Check for odd numbers in the array

            // Lambda expression version
            var newQuery = queryArray.Where(n => n % 2 != 0);
            return newQuery;
        }

        static void printByLine(IEnumerable<int> input)
        {
            // Query Execution

            foreach (var element in input)
            {
                Console.Write("{0} ", element);
            }
        }
    }
}
