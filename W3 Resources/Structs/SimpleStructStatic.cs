using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to declare a simple structure. 
Expected Output:

Declare a simple structure :
-------------------------------- 
The sum of x and y is 40  
*/

namespace W3Resources.Structs
{
    struct SimpStruct
    {
        public static int xValue = 55;
        public static int yValue = 33;
    }
    class SimpleStruct
    {
        public static void Main()
        {
            Console.Write("\n\nDeclare a simple structure :\n");
            Console.Write("--------------------------------\n");

            int sum = SimpStruct.xValue + SimpStruct.yValue;

            Console.WriteLine("Sum of x and y is: {0}", sum);
        }

    }
}
