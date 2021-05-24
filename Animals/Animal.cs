using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public static void Presentation(IAnimal elephant)
        {
            Console.WriteLine($"{elephant.GetType().Name} was born on {elephant.birthDate.ToShortDateString()}, so he has {elephant.age()} years");
        }
    }
}
