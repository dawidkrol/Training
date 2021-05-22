using System;

namespace Employer
{
    public interface IEmployee
    {
        int age { get; }
        DateTimeOffset dateOfEmployment { get; }
        string name { get; set; }
        string surName { get; set; }
    }
}