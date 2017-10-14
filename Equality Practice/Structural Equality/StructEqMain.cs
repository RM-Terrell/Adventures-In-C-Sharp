using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality_Practice.Structural_Equality
{
    class StructEqMain
    {
        static void Main(string[] args)
        {
            string[] arr1 = { "Hammer", "Saw", "Nail", "Drill" };
            string[] arr2 = { "Hammer", "Saw", "Nail", "Drill" };

            //Console.WriteLine(arr1 == arr2); // Returns false because reference equality
            //Console.WriteLine(arr1.Equals(arr2)); // Returns false because reference equality

            var arrayEq = (IStructuralEquatable)arr1;
            bool structEqual = arrayEq.Equals(arr2, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(structEqual);

            // structural comparison
            var arrayComp = (IStructuralComparable)arr1;
            int structComp = arrayComp.CompareTo(arr2, StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(structComp);
        }
    }
}
