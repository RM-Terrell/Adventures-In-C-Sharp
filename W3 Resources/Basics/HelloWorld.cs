using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Back to basics! Print Hello World! to console and print a new line under it without resorting to just another console.writeline*/

namespace W3Resources.Basics
{
    class HelloWorld
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!{0}Enviorment new line here", Environment.NewLine);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
