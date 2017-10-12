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
            //---------------Basic equality practice-------------------//
            //Car Impreza = new Car("Impreza");
            //Car Impreza2 = new Car("Impreza");

            //Car Mustang = new Car("Mustang");

            //Console.WriteLine(Impreza.Equals(Mustang));
            //Console.WriteLine(Impreza.Equals(Impreza2)); // Returns false because Equals operator checks reference by default
            //// Console.WriteLine(null.Equals(Impreza)); //This will throw and exception due to calling method on a null

            //Console.WriteLine(object.Equals(null, Impreza)); // first value can be null without throwing exception
            //Console.WriteLine(object.Equals(null, null)); // Returns true

            //Console.WriteLine(ReferenceEquals(Impreza, Impreza2)); // returns false b/c checks by reference. Cant override

            ////---------------------//

            //Console.WriteLine("Method: " + OperatorVsMethod.MethodEquality(3,3) + 
            //    "Operator: " + OperatorVsMethod.OperatorEquality(3,3)); 
            //// Both give same results but with very different intermediate language processes


            //-----------Over riding equality testing---------------------------//
            // Steps: Override object.equals, IEquatable<t>, == and != overloads, override object.gethashcode()
            // Must do all 4

            FoodItem banana = new FoodItem("banana", FoodGroup.Fruit);
            FoodItem banana2 = new FoodItem("banana", FoodGroup.Fruit);
            FoodItem chocolate = new FoodItem("chocolate", FoodGroup.Sweets);

            Console.WriteLine(
                "banana    == banana2:   " + (banana == banana2));
            Console.WriteLine(
                "banana2   == chocolate: " + (banana2 == chocolate));
            Console.WriteLine(
                "chocolate == banana:    " + (chocolate == banana));
        }


    }
}
