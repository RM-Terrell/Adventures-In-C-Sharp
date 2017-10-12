using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality_Practice
{
    public /*struct*/ class Car 
        // chaging this to a structure overrides reference equality behavior 
        //because struct derives from system.valuetype. This auto behavior is a bit slow though
    {
        private string _name;
        public string Name { get { return _name; } }

        public Car(string name)
        {
            this._name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
