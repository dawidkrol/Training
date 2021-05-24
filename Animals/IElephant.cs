using System;

namespace Animals
{
    public interface IAnimal
    {
        DateTime birthDate { get; }

        int age();
    }
}