﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Each new term in the Fibonacci sequence is generated by adding the previous two terms.By starting with 1 and 2, the first 10 terms will be:
1, 2, 3, 5, 8, 13, 21, 34, 55, 89, …
Find the sum of all the even-valued terms in the sequence which do not exceed four million.*/

namespace Euler_Project_CS
{
    class Problem2
    {
        static void Main(string[] args)
        {

            long alpha = 1;
            long beta = 1;
            long gamma = 0;
            long summed = 0;

            while(gamma < 4000000)
            {
                if((gamma % 2) == 0) //checks if value is even. remove for normal fibonacci
                {
                    summed += gamma;
                }

                gamma = alpha + beta;
                beta = alpha;
                alpha = gamma;
            }

            Console.WriteLine(summed);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}