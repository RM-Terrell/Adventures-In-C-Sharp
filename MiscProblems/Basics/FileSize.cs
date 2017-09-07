using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 * 
 * Write a C# program to find the size of a specified file in bytes.
Sample Output:
Size of a file: 31 
*/

namespace MiscProblems.Basics
{
    class FileSize
    {
        class HelloWorld
        {
            static void Main()
            {
                Console.WriteLine("Enter file path for file to chek size of: ");
                var filePath = Console.ReadLine();

                FileInfo f = new FileInfo(filePath); // Enter file path here
                Console.WriteLine("\nSize of a file: " + f.Length.ToString());


                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }

    }
}
