using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Template for testing solutions, printing to console and keeping open until key is pressed*/

namespace Euler_Project_CS
{
    class Template
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lower bound");
            int lowerN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter upper bound");
            int upperN = Convert.ToInt32(Console.ReadLine());
            long sumValue = 0;
            long result = 0;
            long squaredValue = 0;

            for(int i = lowerN; i<=upperN; i++)
            {
                sumValue += i;
                squaredValue += i * i;
            }

            result = sumValue * sumValue - squaredValue;


            Console.WriteLine("Sum of squares = " + squaredValue);
            Console.WriteLine("Square of sums = "+sumValue*sumValue);
            Console.WriteLine("Difference = "+result);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}