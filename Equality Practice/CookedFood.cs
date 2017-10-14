using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality_Practice
{
    public sealed class CookedFood : Food
    {
        public static bool operator ==(CookedFood x, CookedFood y) // same operator methods as base class. could be left out
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(CookedFood x, CookedFood y)
        {
            return !object.Equals(x, y);
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj)) // check base class checks first
                return false;
            CookedFood rhs = (CookedFood)obj;
            return this._cookingMethod == rhs._cookingMethod;
        }

        public override int GetHashCode() // and have to deal with GetHashCode here too
        {
            return base.GetHashCode() ^ this._cookingMethod.GetHashCode();
        }

        private string _cookingMethod;

        public string CookingMethod { get { return _cookingMethod; } }

        public CookedFood(string cookingMethod, string name, FoodGroup group)
            : base(name, group)
        {
            this._cookingMethod = cookingMethod;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", _cookingMethod, Name);
        }



    }
}
