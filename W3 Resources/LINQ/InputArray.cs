using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to Accept the members of a list through the keyboard and display 
the members more than a specific value. 
Test Data :
Input the number of members on the List : 5
Member 0 : 10
Member 1 : 48
Member 2 : 52
Member 3 : 94
Member 4 : 63

Input the value above you want to display the members of the List : 59
Expected Output :
The numbers greater than 59 are :
94
63
*/


namespace W3Resources.LINQ
{
    class InputArray
    {
        static void Main()
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };            

            Console.WriteLine("Enter numbers to be placed in an array: ");
            string text = Console.ReadLine();

            Console.WriteLine("Input the value above which you want to display numbers: ");
            int lowerLimit = int.Parse(Console.ReadLine());

            string[] stringArray = text.Split(delimiterChars);
            int[] numArray = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                numArray[i] = Int32.Parse(stringArray[i]);
            }

            var limitBoundQuery = numArray.Where(n => n > lowerLimit);

            foreach (var items in limitBoundQuery)
            {
                Console.WriteLine(items);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
