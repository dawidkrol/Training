using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public static void Presentation(IAnimal animal)
        {
            Console.WriteLine($"{animal.GetType().Name} was born on {animal.birthDate.ToShortDateString()}, so he has {animal.age()} years");
        }
    }
}
