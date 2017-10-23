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
        public int xValue;
        public int yValue;
    }
    class SimpleStruct
    {
        public static void Main()
        {
            Console.Write("\n\nDeclare a simple structure :\n");
            Console.Write("--------------------------------\n");
            SimpStruct _simpStruct = new SimpStruct();

            _simpStruct.xValue = 20;
            _simpStruct.yValue = 30;
            int sum = _simpStruct.yValue + _simpStruct.xValue;

            Console.WriteLine("Sum of x and y is: {0}", sum);
        }

    }
}
