using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality_Practice.Comparison_Implementation
{
    public struct CalorieCount : IComparable<CalorieCount>, IEquatable<CalorieCount>, IComparable
    {
        public int CompareTo(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");
            if (!(obj is CalorieCount))
                throw new ArgumentException("Expected CalorieCount instance", "obj");
            return CompareTo((CalorieCount)obj);
        }

        public int CompareTo(CalorieCount other)
        {
            return this._value.CompareTo(other._value);
        }

        public bool Equals(CalorieCount other) // Need to give an equals override also in order to use "==" or code wont compile
        {
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is CalorieCount))
                return false;
            return _value == ((CalorieCount)obj)._value;
        }

        public override int GetHashCode() // Implement GetHashCode due to equality override
        {
            return _value.GetHashCode();
        }

        public static bool operator ==(CalorieCount x, CalorieCount y) // HAVE to implement all 6 of these
        {
            return x._value == y._value;
        }

        public static bool operator !=(CalorieCount x, CalorieCount y) // HAVE to implement all 6 of these
        {
            return x._value != y._value;
        }

        public static bool operator <(CalorieCount x, CalorieCount y) // HAVE to implement all 6 of these
        {
            return x._value < y._value;
        }

        public static bool operator <=(CalorieCount x, CalorieCount y) // HAVE to implement all 6 of these
        {
            return x._value <= y._value;
        }

        public static bool operator >(CalorieCount x, CalorieCount y) // HAVE to implement all 6 of these
        {
            return x._value > y._value;
        }

        public static bool operator >=(CalorieCount x, CalorieCount y) // HAVE to implement all 6 of these
        {
            return x._value >= y._value;
        }

        private float _value;
        public float Value { get { return _value; } }

        public CalorieCount(float value)
        {
            this._value = value;
        }

        public override string ToString()
        {
            return _value + " cal";
        }


    }
}
