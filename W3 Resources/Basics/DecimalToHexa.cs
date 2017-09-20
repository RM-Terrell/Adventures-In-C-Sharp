using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a C# program to convert a decimal number to hexadecimal number. 
Sample Output:
Hexadecimal number: 4B0
Convert to-
Decimal number: 1200 
     */

namespace W3Resources.Basics
{
    class DecimalToHexa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hexadecimal value to be converted to decimal");

            string hexaVal = Console.ReadLine();
            
            int deciValue = int.Parse(hexaVal, System.Globalization.NumberStyles.HexNumber);
            
            Console.WriteLine("Decimal number is: " + deciValue);


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
