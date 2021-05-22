using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employer
{
    public class Employee : IEmployee
    {
        public string name { get; set; }
        public string surName { get; set; }
        private int _age;

        public int age
        {
            get { return _age; }

            private set
            {
                if (value >= 0 && value < 200)
                    _age = value;
            }
        }

        private DateTimeOffset _dateOfEmployment;

        public DateTimeOffset dateOfEmployment
        {
            get { return _dateOfEmployment; }
            private set { _dateOfEmployment = value; }
        }




    }
}
