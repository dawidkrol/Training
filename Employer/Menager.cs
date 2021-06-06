using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employer
{
    public class Menager : Employee
    {
        public bool Managment { get; set; }
        public void Deconstruct(out string name,out string surname)
        {
            name = this.name;
            surname = this.surName;
        }
    }
}
