using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// No need to implement IEqualtabile<t> for reference overiding like with values

namespace Equality_Practice
{
    public enum FoodGroup { Meat, Fruit, Vegetables, Sweets }

    public class Food
    {
        public static bool operator ==(Food x, Food y) // have to overload equality opertor just like with value overriding
        {
            return object.Equals(x, y);
            // DO NOT use operator equality in here to save performance and avoid a method call
            // Uncomment and run the below code to watch the hilarity 

            //return x._name == y._name && x._group == y._group;

            // Issue is that this base class has no knowledge of derived classes and operators are STATIC
        }

        public static bool operator !=(Food x, Food y)
        {
            return !object.Equals(x, y);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) // null checker
                return false;
            if (ReferenceEquals(obj, this)) //checking for if reference equals itself. performance optimization
                return true;
            if (obj.GetType() != this.GetType()) // type check
                return false;
            Food rhs = obj as Food;
            return this._name == rhs._name && this._group == rhs._group;
        }

        public override int GetHashCode() // have to override GetHashCode just like with value type
        {
            return this._name.GetHashCode() ^ this._group.GetHashCode();
        }

        string _name;
        FoodGroup _group;

        public string Name { get { return _name; } }

        public Food(string name, FoodGroup group)
        {
            this._name = name;
            this._group = group;
        }

        public override string ToString()
        {
            return _name;
        }

    }

    }
