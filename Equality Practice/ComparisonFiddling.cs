using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality_Practice
{
    class ComparisonFiddling
    {
        static void Main()
        {
            string Subaru = "Subaru";
            string Ford = "Ford";

            //Console.WriteLine(Subaru.CompareTo(Ford)); // Compares based on alphabet order. 1 meaning "S" comes after "F"
            //Console.WriteLine(Subaru.CompareTo(Subaru));
            //Console.WriteLine(Ford.CompareTo(Subaru));

            //Console.WriteLine("String".CompareTo("String")); // 0
            //Console.WriteLine("Atring".CompareTo("String")); // -1
            //Console.WriteLine("StringBigger".CompareTo("String")); // 1
            //Console.WriteLine("String".CompareTo("StringBigger")); // -1

            Console.WriteLine(String.Compare("Subaru", "Ford", StringComparison.Ordinal)); // returns unicode difference
            Console.WriteLine(String.Compare("subaru", "subaru", StringComparison.Ordinal)); 
            Console.WriteLine(String.Compare("subaru", "SUBARU", StringComparison.Ordinal));

            Console.WriteLine(String.Compare("subaru", "SUBARU", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(String.Compare("Subaru", "subaru", StringComparison.CurrentCulture)); // Cultural ordering is different from ordinal
            Console.WriteLine(String.Compare("Subaru", "subaru", StringComparison.Ordinal));

            var areEqual = ("Subaru" == "Ford"); // Case sensitive, unicode comparison
            Console.WriteLine(areEqual);


        }
    }
}
