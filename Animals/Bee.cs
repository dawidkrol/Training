using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Bee : Animal,IAnimal
    {
        private static bool canI = true;
        public static Bee NewBee(string name,DateTime dateTime)
        {
            Bee output = null;
            if (canI)
            {
                output = new Bee(name,dateTime);
                canI = false;
            }
            return output;
        }

        public int age()
        {
            return (int)((DateTime.Now - birthDate).Days / 360);
        }

        private Bee(string name, DateTime dateTime)
        {
            this.name = name;
            birthDate = dateTime;
        }
        ~Bee() => Console.WriteLine("Finalizowanie Bee");
        public string name { get; }

        public DateTime birthDate { get; }
    }
}
