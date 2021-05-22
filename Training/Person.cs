using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Person : IPerson
    {
        public Person(string Name,string LastName)
        {
            _name = Name;
            _lastName = LastName;
        }
        public Person(string LastName) : this("", LastName) { }

        public string _name { get; private set; }
        public string _lastName { get; private set; }
    }
}
