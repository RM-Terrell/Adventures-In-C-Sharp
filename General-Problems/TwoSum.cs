using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Problems
{
    class TwoSum
    {
        static void Main()
        {           

            Console.WriteLine("Enter the array of numbers, each number separated by spaces or comma.");
            string text = Console.ReadLine();

            Console.WriteLine("Enter a target sum to find from the array.");
            int inputTarget = Convert.ToInt32((Console.ReadLine()));

            int[] numArray = StringSplit(text);

            int[] result = PerformTwoSum(numArray, inputTarget);

            foreach(var element in result)
            {
                Console.WriteLine(element);
            }


        }
        public static int[] PerformTwoSum(int[] numsArray, int targetValue)
        {
            int[] result = new int[2];
            for(int i = 0; i < numsArray.Length; i++)
            {
                for(int j = i + 1; j < numsArray.Length; j++)
                {
                    if( numsArray[i] + numsArray[j] == targetValue)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;                        
                    }
                }
            }
            
            throw new Exception("No values add to required sum.");            
        }

        public static int[] StringSplit(string text)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

            string[] stringArray = text.Split(delimiterChars);

            int[] numArray = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                numArray[i] = Int32.Parse(stringArray[i]);
            }

            return numArray;
        }
    }
}
