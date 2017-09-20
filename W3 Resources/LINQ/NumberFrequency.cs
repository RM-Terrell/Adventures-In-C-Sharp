using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Write a program in C# Sharp to display the number and frequency of number from giving array.
Expected Output :
The number and the Frequency are :
Number 5 appears 3 times
Number 9 appears 2 times
Number 1 appears 1 times
*/

namespace W3Resources.LINQ
{
    class NumberFrequency
    {
        static void Main()
        {
            int[] sourceArray = { 1, 2, -4, -8, 10, 29, 4, 1, 1, -56, -7, 12, -9, -20, 50, 99, 1, 2, 76, 9, -20, -21, 55 };
            int inputFreqCheck = 0;
            int freqCount = 0;

            Console.WriteLine("Enter number to check appearance frequency.");
             inputFreqCheck = int.Parse(Console.ReadLine());

            var freqQuery =
                from nums in sourceArray
                where nums == inputFreqCheck
                select nums;

            foreach (var nums in freqQuery)
            {
                freqCount += 1;
            }

            Console.WriteLine("{0} apears {1} times(s) in the array", inputFreqCheck, freqCount);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
