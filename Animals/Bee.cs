using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Bee
    {
        private static bool canI = true;
        public static Bee NewBee(string name)
        {
            Bee output = null;
            if (canI)
            {
                output = new Bee(name);
                canI = false;
            }
            return output;
        }
        private Bee(string name) => this.name = name;
        ~Bee() => Console.WriteLine("Finalizowanie");
        public string name { get; }
    }
}
