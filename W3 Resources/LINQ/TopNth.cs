using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to display the top n-th records.
Test Data :
The members of the list are :
5
7
13
24
6
9
8
7
How many records you want to display ? : 3
Expected Output :
The top 3 records from the list are :
24
13
9 
*/

namespace W3Resources.LINQ
{
    class TopNth
    {
        static void Main()
        {
            int[] sourceArray = { 1, 2, -4, -8, 10, 29, 4, 1, 1, -56, -7, 12, -9, -20, 50, 99, 1, 2, 76, 9, -20, -21, 55 };
            int topN = 0;
            

            Console.WriteLine("How many top results records to do you want to see?");
            topN = int.Parse(Console.ReadLine());

            // Alternate version

            //Array.Sort<int>(sourceArray, 
            //    new Comparison<int>(
            //                (i2, i1) => i1.CompareTo(i2)));

            sourceArray = sourceArray.OrderByDescending(c => c).ToArray();

            foreach (int record in sourceArray.Take(topN))
            {
                Console.WriteLine(record);
            }   

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
