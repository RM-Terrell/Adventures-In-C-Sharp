using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Write a C# Sharp program that takes a number as input and print its multiplication table. Go to the editor
Test Data:
Enter the number: 5
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
....
5 * 10 = 50

 */

namespace MiscProblems.Basics
{
    class MultipleTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to generate multiplication table.");
            int numMultiple = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter upper bound of multiplication table.");
            int upperBound = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<=upperBound; i++)
            {
                int tempResult = numMultiple * i;
                Console.WriteLine("{0} x {1} = {2}", numMultiple, i, tempResult);
            };



            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
