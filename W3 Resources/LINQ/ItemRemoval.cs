using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program in C# Sharp to Remove Items from List using remove function by passing the object.
Test Data :
Here is the list of items :
Char: m
Char: n
Char: o
Char: p
Char: q
Expected Output:
Here is the list after removing the item 'o' from the list :
Char: m
Char: n
Char: p
Char: q 
*/

namespace W3Resources.LINQ
{
    class ItemRemoval
    {
        static void Main()
        {
            IEnumerable<string> sourceList = new List<string> { "A", "B", "C", "D", "E", "F" };
            string toRemove;
            IEnumerable<string> finalList;
                        

            Console.WriteLine("Here is the list of items:");

            printByLine(sourceList);

            Console.WriteLine("Enter item to remove: ");
            toRemove = Console.ReadLine();
            //Uncomment below to to make the program not case sensitive
            //toRemove = toRemove.ToUpper();

            Console.WriteLine("\nNew List is: ");
            finalList = ElementRemove(toRemove, sourceList);
            printByLine(finalList);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static IEnumerable<string> ElementRemove(string toRemove, IEnumerable<string> sourceList)
        {
            var removeQuery =
                from items in sourceList
                where items != toRemove
                select items;

            return removeQuery;
        }

        static void printByLine(IEnumerable<string> input)
        {
            foreach (var element in input)
            {
                Console.WriteLine("Char: {0}", element);
            }
        }
    }
}
