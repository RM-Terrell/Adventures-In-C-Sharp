using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Write a C# program to print the odd numbers from 1 to 99. Prints one number per line. 
Sample Output:
Odd numbers from 1 to 99. Prints one number per line.
1
3
5
7
9
...
95
97
99 
*/

namespace MiscProblems.Basics
{
    class OddNumbers
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input number to start odd counting from:");
            int numStart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input upper bound on counting");
            int upperBound = Convert.ToInt32(Console.ReadLine());

            for(int i = numStart; i<=upperBound; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine(i);
                    i++;
                }    
            
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
