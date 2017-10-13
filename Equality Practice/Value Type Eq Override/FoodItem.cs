using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equality_Practice
{
    public enum FoodGroup { Meat, Fruit, Vegetables, Sweets }

    public struct FoodItem : IEquatable<FoodItem>
    {
        public static bool operator ==(FoodItem lhs, FoodItem rhs) // overrides equality operator
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(FoodItem lhs, FoodItem rhs) // overrides inequality operator. MUST do this or wont build
        {
            return !lhs.Equals(rhs);
        }

        public override int GetHashCode() // must also be overriden to make the hash tables work the same for these types
        {
            return _name.GetHashCode() ^ _group.GetHashCode();
        }

        public bool Equals(FoodItem other)
        {
            return this._name == other.Name && this._group == other._group;
        }

        public override bool Equals(object obj)
        {
            if (obj is FoodItem)
                return Equals((FoodItem)obj); //Calls in strongly typed equals method
            else
                return false;
        }

        private readonly string _name;
        private readonly FoodGroup _group;

        public string Name { get { return _name; } }
        public FoodGroup Group { get { return _group; } }

        public FoodItem(string name, FoodGroup group)
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