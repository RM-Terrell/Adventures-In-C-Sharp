using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. Go to the editor
Test Data :
Enter a number: 1234
Expected Output :
The sum of the digits of the number 1234 is : 10
*/

namespace W3Resources.Functions
{
    class DigitSum
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to sum the digits: ");
            var userInput = Console.ReadLine();

            var splitInput = Split(userInput);
            var summedSplitInput = Sum(splitInput);

            Console.WriteLine("The sum of {0} is {1}.", userInput, summedSplitInput);            
        }

        public static Char[] Split(string input)
        {
            char[] result = new Char[input.Length];
            result = input.ToCharArray();
            return result;
        }

        public static int Sum(Char[] input)
        {
            int sum = 0;

            for(int i = 0; i < input.Length; i++)
            {
                sum += (int)Char.GetNumericValue((input[i]));
            }

            return sum;
        }
    }
}
