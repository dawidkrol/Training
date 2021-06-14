using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Person :EventArgs, IPerson,IEquatable<Person>,IComparable<Person>
    {
        public Person(string Name,string LastName)
        {
            _name = Name;
            _lastName = LastName;
        }
        public Person(string LastName) : this("", LastName) { }

        public string _name { get;private set; }
        public string _lastName { get; private set; }

        public bool Equals(Person other)
        {
            if(other._name == _name && other._lastName == _lastName)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"{_name} {_lastName}";
        }

        public int CompareTo(Person other)
        {
            if(_name.CompareTo(other._name) == 1)
            {
                return 1;
            }
            else if(this.Equals(other))
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
