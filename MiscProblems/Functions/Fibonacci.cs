using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to create a function to display the n number Fibonacci sequence.
Test Data :
Input number of Fibonacci Series : 5
Expected Output :
The Fibonacci series of 5 numbers is :
0 1 1 2 3
*/

namespace MiscProblems.Functions
{
    class Fibonacci
    {
        public static void Main()
        {
            int fibN = 0;

            Console.WriteLine("How may elemenents of the Fibonacci sequence should be generated?");
            fibN = int.Parse(Console.ReadLine());

            int[] fibReadOut = calcFib(fibN);
            foreach (int i in fibReadOut)
            {
                Console.WriteLine(i);                
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }

        public static int[] calcFib(int fibN)
        {
            int[] fibCalced = new int[fibN];
            fibCalced[0] = 0;
            fibCalced[1] = 1;

            for(int i=2; i<fibN; i++)
            {
                fibCalced[i] = fibCalced[i - 1] + fibCalced[i - 2];
            }            
            return fibCalced;
        }
    }
}
