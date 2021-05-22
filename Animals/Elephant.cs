using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Elephant
    {
        public static uint population
        {
            get;
            private set;
        } = 0;
        public DateTime birthDate
        {
            get;
            private set;
        }
        public Elephant(DateTime birthDay)
        {
            population++;
            birthDate = birthDay;
        }
        public void Deconstruct(out int bY,out DateTime bD)
        {
            bY = age();
            bD = birthDate;
        }
        ~Elephant() => Console.WriteLine("Finalizowanie");
        public int age() => (int)((DateTime.Now - birthDate).Days / 360);
        public static void ElephantPresentation(Elephant elephant)
        {
            Console.WriteLine($"Elephant was born on {elephant.birthDate.ToShortDateString()}, so he has {elephant.age()} years");
        }
        public static void ElephantsPopulationPresentation()
        {
            if(Elephant.population == 0)
                Console.WriteLine("We haven't elephants.");
            else if(Elephant.population == 1)
                Console.WriteLine($"We have {Elephant.population} elephant");
            else
                Console.WriteLine($"We have {Elephant.population} elephants");
        }
    }
}
