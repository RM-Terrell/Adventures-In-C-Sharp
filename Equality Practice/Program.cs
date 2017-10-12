using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// "==" operator is part of C#. Equals method is part of the .NET framework. 

namespace Equality_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Car Impreza = new Car("Impreza");
            Car Impreza2 = new Car("Impreza");

            Car Mustang = new Car("Mustang");

            Console.WriteLine(Impreza.Equals(Mustang));
            Console.WriteLine(Impreza.Equals(Impreza2)); // Returns false because Equals operator checks reference by default
            // Console.WriteLine(null.Equals(Impreza)); //This will throw and exception due to calling method on a null

            Console.WriteLine(object.Equals(null, Impreza)); // first value can be null without throwing exception
            Console.WriteLine(object.Equals(null, null)); // Returns true

            Console.WriteLine(ReferenceEquals(Impreza, Impreza2)); // returns false b/c checks by reference. Cant override

        }
    }
}
