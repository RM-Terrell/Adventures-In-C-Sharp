using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to display numbers, multiplication of number with frequency and frequency of a number of giving array.
Test Data :
The numbers in the array are :
5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2
Expected Output :
Number Number*Frequency Frequency
------------------------------------------------
5 15 3
1 1 1
9 9 1
2 4 2
*/

namespace MiscProblems.LINQ
{
    class FrequencyAndMultiples
    {
        static void Main()
        {
            int[] sourceArray = { 1, 3, 5, 8, 4, 55, 54, 1, 9, 239, 3, 912, 56, 43, 8, 1, 34, 5, 6, 8, 23, 9, 3, 6, 89 };

            int inputCheck = 0;
            int freqCount = 0;

            Console.WriteLine("Enter number to check appearance frequency and multiple.");

            inputCheck = int.Parse(Console.ReadLine());

            var freqQuery =
                from nums in sourceArray
                where nums == inputCheck
                select nums;

            foreach (var nums in freqQuery)
            {
                freqCount += 1;
            }

            int inputFreqMultiple = inputCheck * freqCount;

            Console.WriteLine("{0} {1} {2}", inputCheck, freqCount, inputFreqMultiple); // Reversed report order for better clarity. Put frequency after the multiple seemed counter intuitive

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
